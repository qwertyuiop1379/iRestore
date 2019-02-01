using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace iRestore
{
    public partial class FormMain : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        SynchronizationContext _syncContext;
        private string ipsw = "", blob = "", sep = "", baseband = "", bm = "";

        public FormMain()
        {
            InitializeComponent();
            if (!File.Exists(Application.StartupPath + "\\futurerestore.exe"))
            {
                using (var client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile("http://github.com/s0uthwest/futurerestore/releases/download/224/futurerestore_win64_v224.zip", Application.StartupPath + "\\futurerestore.zip");
                        ZipFile.ExtractToDirectory(Application.StartupPath + "\\futurerestore.zip", Application.StartupPath + "\\tmp");
                        File.Move(Application.StartupPath + "\\tmp\\futurerestore.exe", Application.StartupPath + "\\futurerestore.exe");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Failed to download futurerestore.\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    File.Delete(Application.StartupPath + "\\futurerestore.zip");
                    Directory.Delete(Application.StartupPath + "\\tmp");
                }
            }
            _syncContext = SynchronizationContext.Current;
        }

        private void LabelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void LabelSupport_Click(object sender, EventArgs e)
        {
            Process.Start("https://paypal.me/qwertyuiop1379");
        }

        private void CheckSEP_CheckedChanged(object sender, EventArgs e)
        {
            ButtonSEP.Enabled = !CheckSEP.Checked;
            TextSEP.Text = CheckSEP.Checked ? "Automatic" : Path.GetFileName(sep);
        }

        private void CheckBaseband_CheckedChanged(object sender, EventArgs e)
        {
            ButtonBaseband.Enabled = !CheckBaseband.Checked;
            TextBaseband.Text = CheckBaseband.Checked ? "Automatic" : Path.GetFileName(baseband);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonIPSW_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "IPSW File";
            fileDialog.Filter = "IPSW Files|*.ipsw";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ipsw = fileDialog.FileName;
                TextIPSW.Text = Path.GetFileName(ipsw);
            }
        }

        private void ButtonRestore_Click(object s, EventArgs e)
        {
            if (ipsw == "")
            {
                MessageBox.Show("Please choose an IPSW file.");
                return;
            }

            if (blob == "")
            {
                MessageBox.Show("Please choose an SHSH2 file.");
                return;
            }

            if (!CheckSEP.Checked)
            {
                if (sep == "" || bm == "")
                {
                    MessageBox.Show("Please choose an SEP file and manifest.");
                    return;
                }
            }

            if (!CheckBaseband.Checked && !CheckNoBaseband.Checked)
            {
                if (baseband == "" || bm == "")
                {
                    MessageBox.Show("Please choose a baseband file and manifest.");
                    return;
                }
            }

            if (MessageBox.Show("Make sure your nonce is set!\nThis process is not always safe and can lose your jailbreak.\nAre you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = Application.StartupPath + "\\futurerestore.exe",
                        Arguments = $"-t \"{blob}\" " +
                            $"{(CheckSEP.Checked ? "--latest-sep" : $"-s \"{sep}\" -m \"{bm}\"")} " +
                            $"{(CheckNoBaseband.Checked ? "--no-baseband" : (CheckBaseband.Checked ? "--latest-baseband" : $"-b \"{baseband}\" -p \"{bm}\""))} " +
                            $"{(CheckDebug.Checked ? "-d" : "")} {(CheckUpdate.Checked ? "-u" : "")} {(CheckWait.Checked ? "-w" : "")} \"{ipsw}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                process.OutputDataReceived += (sender, args) => Display(args.Data);

                AllocConsole();

                Console.WriteLine("[iRestore] Execute command: futurerestore " + process.StartInfo.Arguments);
                
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
        }

        void Display(string output)
        {
            _syncContext.Post(_ => Console.Out.WriteLine(output), null);
        }

        private void CheckNoBaseband_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNoBaseband.Checked)
            {
                MessageBox.Show("Only use this option if you know what you are doing. Using this on devices that require baseband will cause a non working restore.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CheckBaseband.Enabled = false;
                ButtonBaseband.Enabled = false;
                TextBaseband.Text = "None";
            }
            else
            {
                CheckBaseband.Enabled = true;
                ButtonBaseband.Enabled = true;
                TextBaseband.Text = CheckBaseband.Checked ? "Automatic" : Path.GetFileName(baseband);
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("IPSW: The version you wish to restore to. Can be downloaded from https://ipsw.me.\n\n" +
                "SEP: Specify a custom version of SEP (stores passwords, touch id, etc) to restore. Must be compatible with restore version.\n\n" +
                "SEP Manifest: Required if you are using a custom SEP.\n\n" +
                "SHSH2 Blob: The saved blob for the selected restore version.\n\n" +
                "Baseband: Specify a custom version of baseband to restore. Must be compatible with restore version.\n\n" +
                "Baseband Manifest: Required if you are using a custom baseband.\n\n" +
                "Would you like more help?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start("https://www.reddit.com/r/jailbreak/comments/alw5dd/tutorial_update_futurerestore_101_and_irestore/");
            }
        }

        private void ButtonBManifest_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Manifest File";
            fileDialog.Filter = "Plist Files|*.plist";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                bm = fileDialog.FileName;
                TextBManifest.Text = Path.GetFileName(bm);
            }
        }

        private void ButtonBlob_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "SHSH2 File";
            fileDialog.Filter = "SHSH2 Files|*.shsh2";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                blob = fileDialog.FileName;
                TextBlob.Text = Path.GetFileName(blob);
            }
        }

        private void ButtonSEP_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "SEP File";
            fileDialog.Filter = "SEP Files|*.im4p";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                sep = fileDialog.FileName;
                TextSEP.Text = Path.GetFileName(sep);
            }
        }

        private void ButtonBaseband_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Baseband File";
            fileDialog.Filter = "Baseband Files|*.bbfw";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                baseband = fileDialog.FileName;
                TextBaseband.Text = Path.GetFileName(baseband);
            }
        }
    }
}