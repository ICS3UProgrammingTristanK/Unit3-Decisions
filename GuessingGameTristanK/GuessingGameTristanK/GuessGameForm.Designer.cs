namespace GuessingGameTristanK
{
    partial class frmGuessGame
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
            this.lblWhatNumber = new System.Windows.Forms.Label();
            this.nudGuess = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.picRightWrong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWhatNumber
            // 
            this.lblWhatNumber.AutoSize = true;
            this.lblWhatNumber.Font = new System.Drawing.Font("GOST Common", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatNumber.Location = new System.Drawing.Point(12, 38);
            this.lblWhatNumber.Name = "lblWhatNumber";
            this.lblWhatNumber.Size = new System.Drawing.Size(353, 26);
            this.lblWhatNumber.TabIndex = 0;
            this.lblWhatNumber.Text = "Guess a number between 1 and 10.";
            // 
            // nudGuess
            // 
            this.nudGuess.Location = new System.Drawing.Point(408, 44);
            this.nudGuess.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGuess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGuess.Name = "nudGuess";
            this.nudGuess.Size = new System.Drawing.Size(120, 20);
            this.nudGuess.TabIndex = 1;
            this.nudGuess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("GOST Common", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(97, 155);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 51);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Check";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(157, 279);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(177, 25);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "You Guessed XX";
            // 
            // picRightWrong
            // 
            this.picRightWrong.Image = global::GuessingGameTristanK.Properties.Resources.red_x;
            this.picRightWrong.Location = new System.Drawing.Point(421, 231);
            this.picRightWrong.Name = "picRightWrong";
            this.picRightWrong.Size = new System.Drawing.Size(136, 106);
            this.picRightWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRightWrong.TabIndex = 4;
            this.picRightWrong.TabStop = false;
            // 
            // frmGuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 386);
            this.Controls.Add(this.picRightWrong);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudGuess);
            this.Controls.Add(this.lblWhatNumber);
            this.Name = "frmGuessGame";
            this.Text = "Number Guessing Game";
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhatNumber;
        private System.Windows.Forms.NumericUpDown nudGuess;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.PictureBox picRightWrong;
    }
}

