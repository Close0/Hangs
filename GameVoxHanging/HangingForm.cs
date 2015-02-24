using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameVoxHanging
{
    public partial class HangingForm : MaterialForm
    {
        private Process memoryDumpProcess;
        private string lastConsoleLine;
        public HangingForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnMemoryDump_Click(object sender, EventArgs e)
        {
            // Clear the old output from any previous runs
            rtbConsoleOutput.Clear();

            bool isGameVoxRunning = DetectIfGameVoxIsRunning();
            if(!isGameVoxRunning)
            {
                MessageBox.Show("Please start GameVox before running the diagnostics.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // Disable the button so people don't click it a bunch of times
            btnMemoryDump.Enabled = false;

            // Create a new Process object
            memoryDumpProcess = new Process();
            memoryDumpProcess.StartInfo.FileName = "procdump.exe";

            // We need to detect what type of hanging this will be -- so we need to see what's checked
            var radioButton = gbGameVoxStatus.Controls.OfType<RadioButton>().SingleOrDefault(btn => btn.Checked == true);
            switch(radioButton.Name)
            {
                case "rbGameVoxOperational":
                    memoryDumpProcess.StartInfo.Arguments = "-accepteula -ma -h GameVox.exe";
                    break;
                case "rbGameVoxNotResponding":
                default:
                    memoryDumpProcess.StartInfo.Arguments = "-accepteula -ma GameVox.exe";
                    break;
            }
            
            // Set UseShellExecute to false for redirection.
            memoryDumpProcess.StartInfo.UseShellExecute = false;

            // We don't want a command prompt window showing so hide it
            memoryDumpProcess.StartInfo.CreateNoWindow = true;

            // We need to raise this so we can listen for things like Exited
            memoryDumpProcess.EnableRaisingEvents = true;

            // Redirect the standard output of the sort command.   
            // This stream is read asynchronously using an event handler.
            memoryDumpProcess.StartInfo.RedirectStandardOutput = true;

            // Set our event handler to asynchronously read the sort output.
            memoryDumpProcess.OutputDataReceived += new DataReceivedEventHandler(MemoryDumpOutputHandler);
            // Set our event handler to asynchronously exit when finished
            memoryDumpProcess.Exited += new EventHandler(MemoryDumpProcessExited);

            // Need to start the process before I can start the reading
            memoryDumpProcess.Start();

            // Start the asynchronous read of the sort output stream.
            memoryDumpProcess.BeginOutputReadLine();
        }

        private void MemoryDumpProcessExited(object sender, EventArgs e)
        {
            // Release our console program
            memoryDumpProcess.Dispose();

            // We are going to compress the dump file for a great size reduction and clean up the actual file
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(currentDirectory, "GameVox.exe*.dmp");
            foreach (string file in files)
            {
                rtbConsoleOutput.BeginInvoke(new MethodInvoker(() => rtbConsoleOutput.AppendText("Compressing and zipping the diagnostic files, please wait ..." + Environment.NewLine)));
                string zipFileOutput = @currentDirectory + "\\GameVox Diagnostic - " + DateTime.Now.ToString("hh mm ss tt") + ".zip";
                // http://stackoverflow.com/questions/25042141/compress-a-single-file-using-c-sharp
                using (var zip = ZipFile.Open(zipFileOutput, ZipArchiveMode.Create))
                {
                    var entry = zip.CreateEntry("GameVoxDump.dmp");
                    entry.LastWriteTime = DateTimeOffset.Now;

                    using (var stream = File.OpenRead(file))
                    using (var entryStream = entry.Open())
                    {
                        // Write the contents of the dump to the zip file
                        stream.CopyTo(entryStream);
                    }
                    // Clean up the large dump file
                    File.Delete(file);

                    // Renable the button
                    btnMemoryDump.BeginInvoke(new MethodInvoker(delegate { btnMemoryDump.Enabled = true; }));
                }
                rtbConsoleOutput.BeginInvoke(new MethodInvoker(() => rtbConsoleOutput.AppendText("Please upload " + zipFileOutput + " to your preferred file hosting location and give GameVox the link to download the diagnostic file. " + Environment.NewLine)));
            }
        }

        private void MemoryDumpOutputHandler(object sender, DataReceivedEventArgs output)
        {
            if (!String.IsNullOrEmpty(output.Data))
            {
                rtbConsoleOutput.BeginInvoke(new MethodInvoker(() => rtbConsoleOutput.AppendText(output.Data + Environment.NewLine)));
                // We are going to store the last console line so that way if we need it we can pull data out
                lastConsoleLine = output.Data;
            }
        }

        private bool DetectIfGameVoxIsRunning()
        {
            Process[] processes = Process.GetProcessesByName("GameVox");
            foreach(Process process in processes)
            {
                if(process.MainModule.ModuleName == "GameVox.exe")
                {
                    return true;
                }
            }
            return false;
        }
    }
}