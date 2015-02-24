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
            this.rtbConsoleOutput = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.rbMaterialNotResponding = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMaterialWorkingCorrectly = new MaterialSkin.Controls.MaterialRadioButton();
            this.labelDescribeState = new MaterialSkin.Controls.MaterialLabel();
            this.btnMaterialDiagnostics = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbConsoleOutput
            // 
            this.rtbConsoleOutput.Location = new System.Drawing.Point(12, 215);
            this.rtbConsoleOutput.Name = "rtbConsoleOutput";
            this.rtbConsoleOutput.ReadOnly = true;
            this.rtbConsoleOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtbConsoleOutput.Size = new System.Drawing.Size(512, 339);
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
            // rbMaterialNotResponding
            // 
            this.rbMaterialNotResponding.AutoSize = true;
            this.rbMaterialNotResponding.Checked = true;
            this.rbMaterialNotResponding.Depth = 0;
            this.rbMaterialNotResponding.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbMaterialNotResponding.Location = new System.Drawing.Point(13, 90);
            this.rbMaterialNotResponding.Margin = new System.Windows.Forms.Padding(0);
            this.rbMaterialNotResponding.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMaterialNotResponding.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMaterialNotResponding.Name = "rbMaterialNotResponding";
            this.rbMaterialNotResponding.Ripple = true;
            this.rbMaterialNotResponding.Size = new System.Drawing.Size(246, 30);
            this.rbMaterialNotResponding.TabIndex = 4;
            this.rbMaterialNotResponding.TabStop = true;
            this.rbMaterialNotResponding.Text = "GameVox currently not responding.";
            this.rbMaterialNotResponding.UseVisualStyleBackColor = true;
            // 
            // rbMaterialWorkingCorrectly
            // 
            this.rbMaterialWorkingCorrectly.AutoSize = true;
            this.rbMaterialWorkingCorrectly.Depth = 0;
            this.rbMaterialWorkingCorrectly.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbMaterialWorkingCorrectly.Location = new System.Drawing.Point(13, 120);
            this.rbMaterialWorkingCorrectly.Margin = new System.Windows.Forms.Padding(0);
            this.rbMaterialWorkingCorrectly.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMaterialWorkingCorrectly.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMaterialWorkingCorrectly.Name = "rbMaterialWorkingCorrectly";
            this.rbMaterialWorkingCorrectly.Ripple = true;
            this.rbMaterialWorkingCorrectly.Size = new System.Drawing.Size(301, 30);
            this.rbMaterialWorkingCorrectly.TabIndex = 5;
            this.rbMaterialWorkingCorrectly.Text = "GameVox is working correctly, but will hang.";
            this.rbMaterialWorkingCorrectly.UseVisualStyleBackColor = true;
            // 
            // labelDescribeState
            // 
            this.labelDescribeState.AutoSize = true;
            this.labelDescribeState.Depth = 0;
            this.labelDescribeState.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDescribeState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescribeState.Location = new System.Drawing.Point(9, 71);
            this.labelDescribeState.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescribeState.Name = "labelDescribeState";
            this.labelDescribeState.Size = new System.Drawing.Size(302, 19);
            this.labelDescribeState.TabIndex = 6;
            this.labelDescribeState.Text = "Please best describe the state of GameVox:";
            // 
            // btnMaterialDiagnostics
            // 
            this.btnMaterialDiagnostics.Depth = 0;
            this.btnMaterialDiagnostics.Enabled = false;
            this.btnMaterialDiagnostics.Location = new System.Drawing.Point(12, 163);
            this.btnMaterialDiagnostics.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMaterialDiagnostics.Name = "btnMaterialDiagnostics";
            this.btnMaterialDiagnostics.Primary = true;
            this.btnMaterialDiagnostics.Size = new System.Drawing.Size(302, 35);
            this.btnMaterialDiagnostics.TabIndex = 7;
            this.btnMaterialDiagnostics.Text = "Start GameVox Diagnostics";
            this.btnMaterialDiagnostics.UseVisualStyleBackColor = true;
            this.btnMaterialDiagnostics.Click += new System.EventHandler(this.btnMaterialDiagnostics_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameVoxHanging.Properties.Resources.GameVox_icon_bw_black1;
            this.pictureBox1.Location = new System.Drawing.Point(331, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // HangingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 566);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMaterialDiagnostics);
            this.Controls.Add(this.labelDescribeState);
            this.Controls.Add(this.rbMaterialWorkingCorrectly);
            this.Controls.Add(this.rbMaterialNotResponding);
            this.Controls.Add(this.label);
            this.Controls.Add(this.rtbConsoleOutput);
            this.Name = "HangingForm";
            this.Text = "GameVox Hanging Diagnostics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConsoleOutput;
        private System.Windows.Forms.Label label;
        private MaterialSkin.Controls.MaterialRadioButton rbMaterialNotResponding;
        private MaterialSkin.Controls.MaterialRadioButton rbMaterialWorkingCorrectly;
        private MaterialSkin.Controls.MaterialLabel labelDescribeState;
        private MaterialSkin.Controls.MaterialRaisedButton btnMaterialDiagnostics;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

