using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameVoxHanging
{
    public partial class HangingForm : Form
    {
        private Process memoryDumpProcess;
        public HangingForm()
        {
            InitializeComponent();
        }

        private void btnMemoryDump_Click(object sender, EventArgs e)
        {
            // Clear the old output from any previous runs
            rtbConsoleOutput.Clear();

            // Disable the button so people don't click it a bunch of times
            btnMemoryDump.Enabled = false;

            // Create a new Process object
            memoryDumpProcess = new Process();
            memoryDumpProcess.StartInfo.FileName = "procdump.exe";
            memoryDumpProcess.StartInfo.Arguments = "-accepteula -ma GameVox.exe";
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
            rtbConsoleOutput.BeginInvoke(new MethodInvoker(delegate { btnMemoryDump.Enabled = true; }));
            memoryDumpProcess.Dispose();
        }

        private void MemoryDumpOutputHandler(object sender, DataReceivedEventArgs output)
        {
            if (!String.IsNullOrEmpty(output.Data))
            {
                rtbConsoleOutput.BeginInvoke(new MethodInvoker(() => rtbConsoleOutput.AppendText(output.Data)));
            }
        }
    }
}