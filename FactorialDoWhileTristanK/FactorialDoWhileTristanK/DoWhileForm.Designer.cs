namespace FactorialDoWhileTristanK
{
    partial class frmDoWhile
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
            this.lstListBox = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListBox
            // 
            this.lstListBox.FormattingEnabled = true;
            this.lstListBox.Location = new System.Drawing.Point(0, 0);
            this.lstListBox.Name = "lstListBox";
            this.lstListBox.Size = new System.Drawing.Size(120, 95);
            this.lstListBox.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(152, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 47);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstListBox);
            this.Name = "frmDoWhile";
            this.Text = "Factorial Do While";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListBox;
        private System.Windows.Forms.Button btnStart;
    }
}

