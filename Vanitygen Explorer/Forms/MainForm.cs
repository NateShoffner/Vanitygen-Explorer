#region

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Vanitygen_Explorer.Exporters;

#endregion

namespace Vanitygen_Explorer.Forms
{
    public partial class MainForm : Form
    {
        private readonly List<IVanitygenExporter> _exporters = new List<IVanitygenExporter>();
        private readonly List<VanitygenResult> _results = new List<VanitygenResult>();
        private readonly Vanitygen _vanitygen;
        private DateTime _genStarted;
        private int _maxAddresses;

        public MainForm()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            PopulateExporters();

            _exporters = new List<IVanitygenExporter>() { new XmlExporter() };

            _vanitygen = new Vanitygen(Program.VanityGenPath) {SynchronizingObject = this};

            olvColPattern.AspectGetter = x => ((VanitygenResult) x).Pattern;
            olvColAddress.AspectGetter = x => ((VanitygenResult) x).Address;
            olvColKey.AspectGetter = x => ((VanitygenResult) x).Key;

            _vanitygen.HashRateChanged += _vanitygen_HashRateChanged;
            _vanitygen.Stopped += _vanitygen_Stopped;
            _vanitygen.AddressGenerated += _vanitygen_AddressGenerated;
        }

        private void PopulateExporters()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < _exporters.Count; i++)
            {
                var exporter = _exporters[i];
                if (exporter.Name != null && exporter.Extension != null)
                {
                    sb.AppendFormat("{0} (*{1})|*{1}", exporter.Name, exporter.Extension);
                }

                if (i + 1 < _exporters.Count)
                    sb.Append("|");
            }

            exportDialog.Filter = sb.ToString();
        }

        private void _vanitygen_AddressGenerated(object sender, AddressGeneratedEventArgs e)
        {
            _results.Add(e.Result);

            listResults.AddObject(e.Result);

            if (_maxAddresses > 0 && _results.Count == _maxAddresses)
            {
                StopGen();
            }

            if (autoScrollMenuItem.Checked)
                listResults.GetLastItemInDisplayOrder().EnsureVisible();
        }

        private void _vanitygen_HashRateChanged(object sender, VanitygenUpdateEventArgs e)
        {
            UpdateStats(e.HashRate, e.Total);
        }

        private void _vanitygen_Stopped(object sender, EventArgs e)
        {
            StopGen();
        }

        private void UpdateStats(string rate, long total)
        {
            var duration = DateTime.Now.Subtract(_genStarted);
            panelRate.Text = string.Format("Rate: {0}", rate);
            panelTotal.Text = string.Format("Total: {0:N0}", total);
            panelFound.Text = string.Format("Found: {0:N0}", _results.Count);
            panelTime.Text = string.Format("Time: {0:00}:{1:00}:{2:00}", duration.Hours, duration.Minutes, duration.Seconds);
        }

        private void StartGen()
        {
            btnStop.BringToFront();

            _maxAddresses = (int) numAddresses.Value;

            UpdateStats(null, 0);

            _genStarted = DateTime.Now;

            panelControls.Enabled = false;

            _vanitygen.Start((int) numVersion.Value, txtPatterns.Text, rbRegex.Checked, (chkCase.Enabled && chkCase.Checked), true, (int) numThreads.Value);
        }

        private void StopGen()
        {
            if (_vanitygen != null && _vanitygen.IsRunning())
                _vanitygen.Stop();

            panelRate.Text = "Rate: Stopped";

            panelControls.Enabled = true;

            btnStart.BringToFront();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_vanitygen != null)
            {
                _vanitygen.Stop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGen();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopGen();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            numThreads.Value = Environment.ProcessorCount;
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutDialog().ShowDialog();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == copyAddressToolStripMenuItem)
                Clipboard.SetText(listResults.Items[listResults.SelectedIndices[0]].SubItems[colAddress.Index].Text);
            else if (sender == copyPatternToolStripMenuItem)
                Clipboard.SetText(listResults.Items[listResults.SelectedIndices[0]].SubItems[colPattern.Index].Text);
            else if (sender == copyPrivateKeyToolStripMenuItem)
                Clipboard.SetText(listResults.Items[listResults.SelectedIndices[0]].SubItems[colPrivate.Index].Text);
        }

        private void rbRegex_CheckedChanged(object sender, EventArgs e)
        {
            chkCase.Enabled = !rbRegex.Checked;
        }

        private void autoScrollMenuItem_Click(object sender, EventArgs e)
        {
            autoScrollMenuItem.Checked = !autoScrollMenuItem.Checked;
        }

        private void exportMenuItem_Click(object sender, EventArgs e)
        {
            if (_results.Count == 0)
            {
                MessageBox.Show("There is nothing to export.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                var exporter = _exporters[exportDialog.FilterIndex - 1];
                exporter.Export(exportDialog.FileName, _results);
            }
        }
    }
}