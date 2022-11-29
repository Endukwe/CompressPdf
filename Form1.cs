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

namespace Compresspdfghost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Multiselect = true;
            openfile.Title = "Select your PDF files";
            openfile.Filter = "PDF Files (*.PDF)|*.PDF";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openfile.FileNames)
                {
                    listBoxPdf.Items.Add(file);
                }
            }
        }
        private bool CompressPdf(string InputFile, string OutPutFile, string CompressValue)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.ErrorDialog = false;
                startInfo.UseShellExecute = false;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = string.Concat(Path.GetDirectoryName(Application.ExecutablePath), "\\gswin64.exe");

                string args = "-sDEVICE=pdfwrite -dCompatibilitylevel=1.4" + " -dPDFSETTINGS=/" + CompressValue + " -dNOPAUSE -dQUITE -dBATCH" + " -sOutputFile=\"" + OutPutFile + "\" " + "\"" + InputFile + "\"";

                startInfo.Arguments = args;

                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                return true;
            }
            catch
            {
                return false;
            }

        }
        string outputDir = string.Empty;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            foreach (string pdffile in listBoxPdf.Items)
            {
                string outputfile = outputDir + "\\" + Path.GetFileNameWithoutExtension(pdffile) +"_compress.pdf";
                string quality = string.Empty;
                if (comboBox1.InvokeRequired)
                {
                    comboBox1.Invoke(new Action(() => quality = comboBox1.Text));
                }
                else
                {
                    quality = comboBox1.Text;
                }
                CompressPdf(pdffile, outputfile, quality);
                if (progressBar1.InvokeRequired)
                {
                    progressBar1.Invoke(new Action(() => progressBar1.Increment(1)));
                }
                else
                {
                    progressBar1.Increment(1); 
                }
                
            }
        }

        private void Compress_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                outputDir = folder.SelectedPath;
            }
            progressBar1.Maximum = listBoxPdf.Items.Count;
           // Compress.Enabled = false;

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Done");
           // Compress.Enabled=true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
