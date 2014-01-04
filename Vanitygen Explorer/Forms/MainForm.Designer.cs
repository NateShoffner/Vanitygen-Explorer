using System;
using System.Windows.Forms;
using BrightIdeasSoftware;

using BrightIdeasSoftware;

namespace Vanitygen_Explorer.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.rbPlain = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numAddresses = new System.Windows.Forms.NumericUpDown();
            this.rbRegex = new System.Windows.Forms.RadioButton();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.txtPatterns = new System.Windows.Forms.TextBox();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numVersion = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.exportMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.autoScrollMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.panelRate = new System.Windows.Forms.StatusBarPanel();
            this.panelTotal = new System.Windows.Forms.StatusBarPanel();
            this.panelFound = new System.Windows.Forms.StatusBarPanel();
            this.panelTime = new System.Windows.Forms.StatusBarPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listResults = new BrightIdeasSoftware.ObjectListView();
            this.olvColPattern = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTime)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelControls);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 350);
            this.panel1.TabIndex = 3;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.rbPlain);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.numAddresses);
            this.panelControls.Controls.Add(this.rbRegex);
            this.panelControls.Controls.Add(this.chkCase);
            this.panelControls.Controls.Add(this.txtPatterns);
            this.panelControls.Controls.Add(this.numThreads);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.numVersion);
            this.panelControls.Location = new System.Drawing.Point(3, 3);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(194, 292);
            this.panelControls.TabIndex = 20;
            // 
            // rbPlain
            // 
            this.rbPlain.AutoSize = true;
            this.rbPlain.Checked = true;
            this.rbPlain.Location = new System.Drawing.Point(2, 3);
            this.rbPlain.Name = "rbPlain";
            this.rbPlain.Size = new System.Drawing.Size(103, 17);
            this.rbPlain.TabIndex = 0;
            this.rbPlain.TabStop = true;
            this.rbPlain.Text = "Plain-text search";
            this.rbPlain.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Addresses to Generate:\r\n(0 = infinite)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patterns (one per line):";
            // 
            // numAddresses
            // 
            this.numAddresses.Location = new System.Drawing.Point(126, 251);
            this.numAddresses.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numAddresses.Name = "numAddresses";
            this.numAddresses.Size = new System.Drawing.Size(52, 20);
            this.numAddresses.TabIndex = 18;
            // 
            // rbRegex
            // 
            this.rbRegex.AutoSize = true;
            this.rbRegex.Location = new System.Drawing.Point(2, 23);
            this.rbRegex.Name = "rbRegex";
            this.rbRegex.Size = new System.Drawing.Size(150, 17);
            this.rbRegex.TabIndex = 1;
            this.rbRegex.Text = "Regular expression search";
            this.rbRegex.UseVisualStyleBackColor = true;
            this.rbRegex.CheckedChanged += new System.EventHandler(this.rbRegex_CheckedChanged);
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(2, 168);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(103, 17);
            this.chkCase.TabIndex = 17;
            this.chkCase.Text = "Case-Insensitive";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // txtPatterns
            // 
            this.txtPatterns.Location = new System.Drawing.Point(2, 71);
            this.txtPatterns.Multiline = true;
            this.txtPatterns.Name = "txtPatterns";
            this.txtPatterns.Size = new System.Drawing.Size(180, 91);
            this.txtPatterns.TabIndex = 2;
            // 
            // numThreads
            // 
            this.numThreads.Location = new System.Drawing.Point(53, 225);
            this.numThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(52, 20);
            this.numThreads.TabIndex = 11;
            this.numThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Threads:";
            // 
            // numVersion
            // 
            this.numVersion.Location = new System.Drawing.Point(53, 199);
            this.numVersion.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numVersion.Name = "numVersion";
            this.numVersion.Size = new System.Drawing.Size(52, 20);
            this.numVersion.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(113, 301);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(113, 301);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.exitMenuItem});
            this.menuItem1.Text = "&File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 0;
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.exportMenuItem});
            this.menuItem4.Text = "&Edit";
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.Index = 0;
            this.exportMenuItem.Text = "Export";
            this.exportMenuItem.Click += new System.EventHandler(this.exportMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.autoScrollMenuItem});
            this.menuItem2.Text = "&View";
            // 
            // autoScrollMenuItem
            // 
            this.autoScrollMenuItem.Index = 0;
            this.autoScrollMenuItem.Text = "Auto Scroll";
            this.autoScrollMenuItem.Click += new System.EventHandler(this.autoScrollMenuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.aboutMenuItem});
            this.menuItem3.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 0;
            this.aboutMenuItem.Text = "About...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 350);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.panelRate,
            this.panelTotal,
            this.panelFound,
            this.panelTime});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(984, 22);
            this.statusBar1.TabIndex = 4;
            // 
            // panelRate
            // 
            this.panelRate.Name = "panelRate";
            this.panelRate.Text = "Rate: Stopped";
            this.panelRate.Width = 125;
            // 
            // panelTotal
            // 
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Text = "Total: 0";
            this.panelTotal.Width = 120;
            // 
            // panelFound
            // 
            this.panelFound.Name = "panelFound";
            this.panelFound.Text = "Found: 0";
            this.panelFound.Width = 110;
            // 
            // panelTime
            // 
            this.panelTime.Name = "panelTime";
            this.panelTime.Text = "Time: 00:00:00";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAddressToolStripMenuItem,
            this.copyPatternToolStripMenuItem,
            this.copyPrivateKeyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 70);
            // 
            // copyAddressToolStripMenuItem
            // 
            this.copyAddressToolStripMenuItem.Name = "copyAddressToolStripMenuItem";
            this.copyAddressToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.copyAddressToolStripMenuItem.Text = "Copy Address";
            this.copyAddressToolStripMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // copyPatternToolStripMenuItem
            // 
            this.copyPatternToolStripMenuItem.Name = "copyPatternToolStripMenuItem";
            this.copyPatternToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.copyPatternToolStripMenuItem.Text = "Copy Pattern";
            this.copyPatternToolStripMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // copyPrivateKeyToolStripMenuItem
            // 
            this.copyPrivateKeyToolStripMenuItem.Name = "copyPrivateKeyToolStripMenuItem";
            this.copyPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.copyPrivateKeyToolStripMenuItem.Text = "Copy Private Key";
            this.copyPrivateKeyToolStripMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // listResults
            // 
            this.listResults.AllColumns.Add(this.olvColPattern);
            this.listResults.AllColumns.Add(this.olvColAddress);
            this.listResults.AllColumns.Add(this.olvColKey);
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColPattern,
            this.olvColAddress,
            this.olvColKey});
            this.listResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listResults.FullRowSelect = true;
            this.listResults.GridLines = true;
            this.listResults.HasCollapsibleGroups = false;
            this.listResults.HeaderUsesThemes = true;
            this.listResults.HideSelection = false;
            this.listResults.Location = new System.Drawing.Point(200, 0);
            this.listResults.MenuLabelGroupBy = "Group by \'{1}\'";
            this.listResults.MultiSelect = false;
            this.listResults.Name = "listResults";
            this.listResults.RowHeight = 18;
            this.listResults.ShowGroups = false;
            this.listResults.ShowHeaderInAllViews = false;
            this.listResults.Size = new System.Drawing.Size(784, 350);
            this.listResults.TabIndex = 21;
            this.listResults.TintSortColumn = true;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.UseExplorerTheme = true;
            this.listResults.View = System.Windows.Forms.View.Details;
            // 
            // olvColPattern
            // 
            this.olvColPattern.Text = "Pattern";
            this.olvColPattern.Width = 150;
            // 
            // olvColAddress
            // 
            this.olvColAddress.Text = "Address";
            this.olvColAddress.Width = 330;
            // 
            // olvColKey
            // 
            this.olvColKey.Text = "Private Key";
            this.olvColKey.Width = 300;
            // 
            // exportDialog
            // 
            this.exportDialog.Title = "Export Results";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 372);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar1);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(800, 410);
            this.Name = "MainForm";
            this.Text = "Vanitygen Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTime)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPlain;
        private System.Windows.Forms.TextBox txtPatterns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem aboutMenuItem;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel panelRate;
        private System.Windows.Forms.StatusBarPanel panelTotal;
        private System.Windows.Forms.StatusBarPanel panelTime;
        private System.Windows.Forms.StatusBarPanel panelFound;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton rbRegex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAddresses;
        private ObjectListView listResults;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colPattern;
        private System.Windows.Forms.ColumnHeader colPrivate;
        private System.Windows.Forms.ToolStripMenuItem copyAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPrivateKeyToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem autoScrollMenuItem;
        private System.Windows.Forms.Panel panelControls;
        private BrightIdeasSoftware.OLVColumn olvColPattern;
        private BrightIdeasSoftware.OLVColumn olvColAddress;
        private BrightIdeasSoftware.OLVColumn olvColKey;
        private MenuItem menuItem4;
        private MenuItem exportMenuItem;
        private SaveFileDialog exportDialog;
    }
}