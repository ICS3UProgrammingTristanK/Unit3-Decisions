namespace SumOfNumbersTristanK
{
    partial class frmSumOfNumbers
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.lstSumOfNumAnswer = new System.Windows.Forms.ListBox();
            this.lblSumAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(196, 123);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumber.Location = new System.Drawing.Point(12, 44);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(440, 18);
            this.lblEnterNumber.TabIndex = 1;
            this.lblEnterNumber.Text = "Enter a positive number you want to know the sum of numbers to:";
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(196, 65);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(89, 20);
            this.txtUserNumber.TabIndex = 2;
            // 
            // lstSumOfNumAnswer
            // 
            this.lstSumOfNumAnswer.FormattingEnabled = true;
            this.lstSumOfNumAnswer.Location = new System.Drawing.Point(187, 195);
            this.lstSumOfNumAnswer.Name = "lstSumOfNumAnswer";
            this.lstSumOfNumAnswer.Size = new System.Drawing.Size(120, 95);
            this.lstSumOfNumAnswer.TabIndex = 3;
            // 
            // lblSumAnswer
            // 
            this.lblSumAnswer.AutoSize = true;
            this.lblSumAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumAnswer.Location = new System.Drawing.Point(130, 347);
            this.lblSumAnswer.Name = "lblSumAnswer";
            this.lblSumAnswer.Size = new System.Drawing.Size(66, 20);
            this.lblSumAnswer.TabIndex = 4;
            this.lblSumAnswer.Text = "Answer:";
            // 
            // frmSumOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 402);
            this.Controls.Add(this.lblSumAnswer);
            this.Controls.Add(this.lstSumOfNumAnswer);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.lblEnterNumber);
            this.Controls.Add(this.btnStart);
            this.Name = "frmSumOfNumbers";
            this.Text = "Sum Of Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.ListBox lstSumOfNumAnswer;
        private System.Windows.Forms.Label lblSumAnswer;
    }
}

