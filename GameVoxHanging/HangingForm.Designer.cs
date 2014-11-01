namespace GameVoxHanging
{
    partial class HangingForm
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
            this.btnMemoryDump = new System.Windows.Forms.Button();
            this.rtbConsoleOutput = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.gbGameVoxStatus = new System.Windows.Forms.GroupBox();
            this.rbGameVoxNotResponding = new System.Windows.Forms.RadioButton();
            this.rbGameVoxOperational = new System.Windows.Forms.RadioButton();
            this.gbGameVoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMemoryDump
            // 
            this.btnMemoryDump.Location = new System.Drawing.Point(219, 13);
            this.btnMemoryDump.Name = "btnMemoryDump";
            this.btnMemoryDump.Size = new System.Drawing.Size(141, 72);
            this.btnMemoryDump.TabIndex = 0;
            this.btnMemoryDump.Text = "Start diagnostics now";
            this.btnMemoryDump.UseVisualStyleBackColor = true;
            this.btnMemoryDump.Click += new System.EventHandler(this.btnMemoryDump_Click);
            // 
            // rtbConsoleOutput
            // 
            this.rtbConsoleOutput.Location = new System.Drawing.Point(13, 91);
            this.rtbConsoleOutput.Name = "rtbConsoleOutput";
            this.rtbConsoleOutput.Size = new System.Drawing.Size(347, 339);
            this.rtbConsoleOutput.TabIndex = 1;
            this.rtbConsoleOutput.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(160, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 2;
            // 
            // gbGameVoxStatus
            // 
            this.gbGameVoxStatus.Controls.Add(this.rbGameVoxOperational);
            this.gbGameVoxStatus.Controls.Add(this.rbGameVoxNotResponding);
            this.gbGameVoxStatus.Location = new System.Drawing.Point(13, 13);
            this.gbGameVoxStatus.Name = "gbGameVoxStatus";
            this.gbGameVoxStatus.Size = new System.Drawing.Size(200, 72);
            this.gbGameVoxStatus.TabIndex = 3;
            this.gbGameVoxStatus.TabStop = false;
            this.gbGameVoxStatus.Text = "GameVox is";
            // 
            // rbGameVoxNotResponding
            // 
            this.rbGameVoxNotResponding.AutoSize = true;
            this.rbGameVoxNotResponding.Checked = true;
            this.rbGameVoxNotResponding.Location = new System.Drawing.Point(7, 20);
            this.rbGameVoxNotResponding.Name = "rbGameVoxNotResponding";
            this.rbGameVoxNotResponding.Size = new System.Drawing.Size(141, 17);
            this.rbGameVoxNotResponding.TabIndex = 0;
            this.rbGameVoxNotResponding.TabStop = true;
            this.rbGameVoxNotResponding.Text = "currently not responding.";
            this.rbGameVoxNotResponding.UseVisualStyleBackColor = true;
            // 
            // rbGameVoxOperational
            // 
            this.rbGameVoxOperational.AutoSize = true;
            this.rbGameVoxOperational.Location = new System.Drawing.Point(7, 44);
            this.rbGameVoxOperational.Name = "rbGameVoxOperational";
            this.rbGameVoxOperational.Size = new System.Drawing.Size(173, 17);
            this.rbGameVoxOperational.TabIndex = 1;
            this.rbGameVoxOperational.Text = "working correctly, but will hang.";
            this.rbGameVoxOperational.UseVisualStyleBackColor = true;
            // 
            // HangingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 443);
            this.Controls.Add(this.gbGameVoxStatus);
            this.Controls.Add(this.label);
            this.Controls.Add(this.rtbConsoleOutput);
            this.Controls.Add(this.btnMemoryDump);
            this.Name = "HangingForm";
            this.Text = "Form1";
            this.gbGameVoxStatus.ResumeLayout(false);
            this.gbGameVoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMemoryDump;
        private System.Windows.Forms.RichTextBox rtbConsoleOutput;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox gbGameVoxStatus;
        private System.Windows.Forms.RadioButton rbGameVoxOperational;
        private System.Windows.Forms.RadioButton rbGameVoxNotResponding;
    }
}

