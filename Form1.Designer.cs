namespace Compresspdfghost
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxPdf = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Compress = new System.Windows.Forms.Button();
            this.AddPdf = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPdf
            // 
            this.listBoxPdf.FormattingEnabled = true;
            this.listBoxPdf.ItemHeight = 32;
            this.listBoxPdf.Location = new System.Drawing.Point(47, 215);
            this.listBoxPdf.Name = "listBoxPdf";
            this.listBoxPdf.Size = new System.Drawing.Size(1403, 388);
            this.listBoxPdf.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDF Files";
            // 
            // Compress
            // 
            this.Compress.Location = new System.Drawing.Point(47, 609);
            this.Compress.Name = "Compress";
            this.Compress.Size = new System.Drawing.Size(150, 46);
            this.Compress.TabIndex = 2;
            this.Compress.Text = "Compress";
            this.Compress.UseVisualStyleBackColor = true;
            this.Compress.Click += new System.EventHandler(this.Compress_Click);
            // 
            // AddPdf
            // 
            this.AddPdf.Location = new System.Drawing.Point(1267, 163);
            this.AddPdf.Name = "AddPdf";
            this.AddPdf.Size = new System.Drawing.Size(150, 46);
            this.AddPdf.TabIndex = 3;
            this.AddPdf.Text = "Add";
            this.AddPdf.UseVisualStyleBackColor = true;
            this.AddPdf.Click += new System.EventHandler(this.AddPdf_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(215, 609);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1235, 46);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Screen",
            "Ebook",
            "Printer"});
            this.comboBox1.Location = new System.Drawing.Point(215, 687);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 40);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 695);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quality";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 852);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.AddPdf);
            this.Controls.Add(this.Compress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPdf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Compress;
        private System.Windows.Forms.Button AddPdf;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}
