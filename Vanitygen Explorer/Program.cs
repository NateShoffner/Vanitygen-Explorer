#region

using System;
using System.IO;
using System.Windows.Forms;
using Vanitygen_Explorer.Forms;

#endregion

namespace Vanitygen_Explorer
{
    internal static class Program
    {
        internal static string VanityGenPath;

        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
                VanityGenPath = GetVanitygenPath(args[0]);
            if (VanityGenPath == null)
                VanityGenPath = GetVanitygenPath(Environment.CurrentDirectory);

            if (VanityGenPath != null)
            {
                Application.Run(new MainForm());
            }

            else
            {
                MessageBox.Show(string.Format("Failed to locate Vanitygen executable.{0}Place Vanitygen Explorer in the Vanitygen directory.", Environment.NewLine), "Vanitygen Missing");
            }
        }

        private static string GetVanitygenPath(string path)
        {
            string exePath;

            if ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory)
            {
                const string exe32 = "vanitygen.exe";
                const string exe64 = "vanitygen64.exe";

                var is64bit = IntPtr.Size == 8;

                exePath = is64bit ? Path.Combine(path, exe32) : Path.Combine(path, exe64);
            }

            else
            {
                exePath = path;
            }

            return File.Exists(exePath) ? exePath : null;
        }
    }
}