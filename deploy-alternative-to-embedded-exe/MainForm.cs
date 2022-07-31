using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace read_stream_embedded_exe_onclick
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btScreenshot_Click(object sender, EventArgs e)
        {
            string sourceFileName = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Properties",
                "Resources",
                "AndroidBSPInstaller",
                "adb.exe"
            );

            string exePath = "c:\\tmp\\adb.exe";
            var exeDir = Path.GetDirectoryName(exePath);

            Directory.CreateDirectory(exeDir);
            File.Copy(sourceFileName, exePath, overwrite: true);

            // Open the folder to see the result
            Process.Start("explorer.exe", Path.GetDirectoryName(exePath));
        }
    }
}
