namespace ChocolateBoxesTristanK
{
    partial class frmChocolateBoxes
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
            this.nudBoxesSold = new System.Windows.Forms.NumericUpDown();
            this.lblHowmany = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxesSold)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBoxesSold
            // 
            this.nudBoxesSold.Location = new System.Drawing.Point(158, 43);
            this.nudBoxesSold.Name = "nudBoxesSold";
            this.nudBoxesSold.Size = new System.Drawing.Size(120, 20);
            this.nudBoxesSold.TabIndex = 0;
            // 
            // lblHowmany
            // 
            this.lblHowmany.AutoSize = true;
            this.lblHowmany.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowmany.Location = new System.Drawing.Point(73, 9);
            this.lblHowmany.Name = "lblHowmany";
            this.lblHowmany.Size = new System.Drawing.Size(275, 21);
            this.lblHowmany.TabIndex = 1;
            this.lblHowmany.Text = "How many boxes did you sell?:";
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(111, 136);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(85, 21);
            this.lblPrize.TabIndex = 2;
            this.lblPrize.Text = "You Won";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(158, 83);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 33);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 176);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblHowmany);
            this.Controls.Add(this.nudBoxesSold);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes";
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxesSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudBoxesSold;
        private System.Windows.Forms.Label lblHowmany;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Button btnCalculate;
    }
}

