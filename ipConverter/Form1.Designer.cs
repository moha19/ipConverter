namespace ipConverter
{
    partial class frmMain
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
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.radioButtonIP = new System.Windows.Forms.RadioButton();
            this.radioButtonNumber = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHex
            // 
            this.textBoxHex.Enabled = false;
            this.textBoxHex.Location = new System.Drawing.Point(89, 100);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(203, 20);
            this.textBoxHex.TabIndex = 0;
            this.textBoxHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Enabled = false;
            this.textBoxIP.Location = new System.Drawing.Point(89, 67);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(203, 20);
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(23, 176);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(280, 34);
            this.btn_Convert.TabIndex = 2;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Enabled = false;
            this.textBoxNumber.Location = new System.Drawing.Point(89, 129);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(203, 20);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Location = new System.Drawing.Point(23, 103);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(47, 17);
            this.radioButtonHex.TabIndex = 8;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "Hex:";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            this.radioButtonHex.CheckedChanged += new System.EventHandler(this.radioButtonHex_CheckedChanged);
            // 
            // radioButtonIP
            // 
            this.radioButtonIP.AutoSize = true;
            this.radioButtonIP.Location = new System.Drawing.Point(23, 71);
            this.radioButtonIP.Name = "radioButtonIP";
            this.radioButtonIP.Size = new System.Drawing.Size(38, 17);
            this.radioButtonIP.TabIndex = 8;
            this.radioButtonIP.TabStop = true;
            this.radioButtonIP.Text = "IP:";
            this.radioButtonIP.UseVisualStyleBackColor = true;
            this.radioButtonIP.CheckedChanged += new System.EventHandler(this.radioButtonIP_CheckedChanged);
            // 
            // radioButtonNumber
            // 
            this.radioButtonNumber.AutoSize = true;
            this.radioButtonNumber.Location = new System.Drawing.Point(23, 132);
            this.radioButtonNumber.Name = "radioButtonNumber";
            this.radioButtonNumber.Size = new System.Drawing.Size(65, 17);
            this.radioButtonNumber.TabIndex = 8;
            this.radioButtonNumber.TabStop = true;
            this.radioButtonNumber.Text = "Number:";
            this.radioButtonNumber.UseVisualStyleBackColor = true;
            this.radioButtonNumber.CheckedChanged += new System.EventHandler(this.radioButtonDecimal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP Converter";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonNumber);
            this.Controls.Add(this.radioButtonIP);
            this.Controls.Add(this.radioButtonHex);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.textBoxHex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private System.Windows.Forms.RadioButton radioButtonIP;
        private System.Windows.Forms.RadioButton radioButtonNumber;
        private System.Windows.Forms.Label label1;
    }
}

