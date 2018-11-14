namespace RunningAverageTristanK
{
    partial class frmRunningAverage
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblEnterMark = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lblHowToEnd = new System.Windows.Forms.Label();
            this.lblAverageIs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(76, 78);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 33);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEnterMark
            // 
            this.lblEnterMark.AutoSize = true;
            this.lblEnterMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterMark.Location = new System.Drawing.Point(0, 9);
            this.lblEnterMark.Name = "lblEnterMark";
            this.lblEnterMark.Size = new System.Drawing.Size(199, 16);
            this.lblEnterMark.TabIndex = 1;
            this.lblEnterMark.Text = "Enter a number from 0 - 100:";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(134, 28);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 2;
            // 
            // lblHowToEnd
            // 
            this.lblHowToEnd.AutoSize = true;
            this.lblHowToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToEnd.Location = new System.Drawing.Point(0, 28);
            this.lblHowToEnd.Name = "lblHowToEnd";
            this.lblHowToEnd.Size = new System.Drawing.Size(104, 16);
            this.lblHowToEnd.TabIndex = 3;
            this.lblHowToEnd.Text = "(Enter -1 to end )";
            // 
            // lblAverageIs
            // 
            this.lblAverageIs.AutoSize = true;
            this.lblAverageIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageIs.Location = new System.Drawing.Point(12, 157);
            this.lblAverageIs.Name = "lblAverageIs";
            this.lblAverageIs.Size = new System.Drawing.Size(130, 18);
            this.lblAverageIs.TabIndex = 4;
            this.lblAverageIs.Text = "Your average is:";
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 261);
            this.Controls.Add(this.lblAverageIs);
            this.Controls.Add(this.lblHowToEnd);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.lblEnterMark);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblEnterMark;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblHowToEnd;
        private System.Windows.Forms.Label lblAverageIs;
    }
}

