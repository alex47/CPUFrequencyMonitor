namespace CPUFrequencyMonitor
{
    partial class Form1
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
            this.labelHintCpuFrequencyConst = new System.Windows.Forms.Label();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.labelHintMhzConst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHintCpuFrequencyConst
            // 
            this.labelHintCpuFrequencyConst.AutoSize = true;
            this.labelHintCpuFrequencyConst.Location = new System.Drawing.Point(12, 15);
            this.labelHintCpuFrequencyConst.Name = "labelHintCpuFrequencyConst";
            this.labelHintCpuFrequencyConst.Size = new System.Drawing.Size(82, 13);
            this.labelHintCpuFrequencyConst.TabIndex = 1;
            this.labelHintCpuFrequencyConst.Text = "CPU frequency:";
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Enabled = false;
            this.textBoxFrequency.Location = new System.Drawing.Point(100, 12);
            this.textBoxFrequency.MaxLength = 5;
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(57, 20);
            this.textBoxFrequency.TabIndex = 2;
            this.textBoxFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelHintMhzConst
            // 
            this.labelHintMhzConst.AutoSize = true;
            this.labelHintMhzConst.Location = new System.Drawing.Point(163, 15);
            this.labelHintMhzConst.Name = "labelHintMhzConst";
            this.labelHintMhzConst.Size = new System.Drawing.Size(29, 13);
            this.labelHintMhzConst.TabIndex = 3;
            this.labelHintMhzConst.Text = "MHz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 43);
            this.Controls.Add(this.labelHintMhzConst);
            this.Controls.Add(this.textBoxFrequency);
            this.Controls.Add(this.labelHintCpuFrequencyConst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHintCpuFrequencyConst;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.Label labelHintMhzConst;
    }
}

