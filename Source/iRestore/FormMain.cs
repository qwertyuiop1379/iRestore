using System;
using System.Diagnostics;
using System.IO;
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
        private string ipsw = "", blob = "", sep = "", baseband = "";

        public FormMain()
        {
            InitializeComponent();
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
                if (sep == "")
                {
                    MessageBox.Show("Please choose an SEP file.");
                    return;
                }
            }

            if (!CheckBaseband.Checked)
            {
                if (baseband == "")
                {
                    MessageBox.Show("Please choose a baseband file.");
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
                        Arguments =$"-t \"{blob}\" " +
                            $"{(CheckSEP.Checked ? "--latest-sep" : $"-s \"{sep}\"")} " +
                            $"{(CheckBaseband.Checked ? "--latest-baseband" : $"-b \"{baseband}\"")} " +
                            $"{(CheckDebug.Checked ? "-d" : "")} \"{ipsw}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                process.OutputDataReceived += (sender, args) => Display(args.Data);

                AllocConsole();
                
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();

                FreeConsole();
            }
        }

        void Display(string output)
        {
            _syncContext.Post(_ => Console.Out.WriteLine(output), null);
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