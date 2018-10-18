namespace RockPaperScissorsTristanK
{
    partial class frmRockPaperScissors
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
            this.radUChoiceRock = new System.Windows.Forms.RadioButton();
            this.radUChoicePaper = new System.Windows.Forms.RadioButton();
            this.radUChoiceScissors = new System.Windows.Forms.RadioButton();
            this.grbUsersChoice = new System.Windows.Forms.GroupBox();
            this.radCChoiceRock = new System.Windows.Forms.RadioButton();
            this.radCChoicePaper = new System.Windows.Forms.RadioButton();
            this.radCChoiceScissors = new System.Windows.Forms.RadioButton();
            this.grbComputersChoice = new System.Windows.Forms.GroupBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbUsersChoice.SuspendLayout();
            this.grbComputersChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // radUChoiceRock
            // 
            this.radUChoiceRock.AutoSize = true;
            this.radUChoiceRock.Location = new System.Drawing.Point(6, 19);
            this.radUChoiceRock.Name = "radUChoiceRock";
            this.radUChoiceRock.Size = new System.Drawing.Size(51, 17);
            this.radUChoiceRock.TabIndex = 0;
            this.radUChoiceRock.TabStop = true;
            this.radUChoiceRock.Text = "Rock";
            this.radUChoiceRock.UseVisualStyleBackColor = true;
            // 
            // radUChoicePaper
            // 
            this.radUChoicePaper.AutoSize = true;
            this.radUChoicePaper.Location = new System.Drawing.Point(6, 42);
            this.radUChoicePaper.Name = "radUChoicePaper";
            this.radUChoicePaper.Size = new System.Drawing.Size(53, 17);
            this.radUChoicePaper.TabIndex = 1;
            this.radUChoicePaper.TabStop = true;
            this.radUChoicePaper.Text = "Paper";
            this.radUChoicePaper.UseVisualStyleBackColor = true;
            // 
            // radUChoiceScissors
            // 
            this.radUChoiceScissors.AutoSize = true;
            this.radUChoiceScissors.Location = new System.Drawing.Point(6, 65);
            this.radUChoiceScissors.Name = "radUChoiceScissors";
            this.radUChoiceScissors.Size = new System.Drawing.Size(64, 17);
            this.radUChoiceScissors.TabIndex = 2;
            this.radUChoiceScissors.TabStop = true;
            this.radUChoiceScissors.Text = "Scissors";
            this.radUChoiceScissors.UseVisualStyleBackColor = true;
            // 
            // grbUsersChoice
            // 
            this.grbUsersChoice.Controls.Add(this.radUChoiceRock);
            this.grbUsersChoice.Controls.Add(this.radUChoiceScissors);
            this.grbUsersChoice.Controls.Add(this.radUChoicePaper);
            this.grbUsersChoice.Location = new System.Drawing.Point(12, 27);
            this.grbUsersChoice.Name = "grbUsersChoice";
            this.grbUsersChoice.Size = new System.Drawing.Size(162, 93);
            this.grbUsersChoice.TabIndex = 3;
            this.grbUsersChoice.TabStop = false;
            this.grbUsersChoice.Text = "Player\'s Choice";
            // 
            // radCChoiceRock
            // 
            this.radCChoiceRock.AutoSize = true;
            this.radCChoiceRock.Enabled = false;
            this.radCChoiceRock.Location = new System.Drawing.Point(6, 19);
            this.radCChoiceRock.Name = "radCChoiceRock";
            this.radCChoiceRock.Size = new System.Drawing.Size(51, 17);
            this.radCChoiceRock.TabIndex = 4;
            this.radCChoiceRock.TabStop = true;
            this.radCChoiceRock.Text = "Rock";
            this.radCChoiceRock.UseVisualStyleBackColor = true;
            this.radCChoiceRock.CheckedChanged += new System.EventHandler(this.radCChoiceRock_CheckedChanged);
            // 
            // radCChoicePaper
            // 
            this.radCChoicePaper.AutoSize = true;
            this.radCChoicePaper.Enabled = false;
            this.radCChoicePaper.Location = new System.Drawing.Point(6, 42);
            this.radCChoicePaper.Name = "radCChoicePaper";
            this.radCChoicePaper.Size = new System.Drawing.Size(53, 17);
            this.radCChoicePaper.TabIndex = 5;
            this.radCChoicePaper.TabStop = true;
            this.radCChoicePaper.Text = "Paper";
            this.radCChoicePaper.UseVisualStyleBackColor = true;
            // 
            // radCChoiceScissors
            // 
            this.radCChoiceScissors.AutoSize = true;
            this.radCChoiceScissors.Enabled = false;
            this.radCChoiceScissors.Location = new System.Drawing.Point(6, 65);
            this.radCChoiceScissors.Name = "radCChoiceScissors";
            this.radCChoiceScissors.Size = new System.Drawing.Size(64, 17);
            this.radCChoiceScissors.TabIndex = 6;
            this.radCChoiceScissors.TabStop = true;
            this.radCChoiceScissors.Text = "Scissors";
            this.radCChoiceScissors.UseVisualStyleBackColor = true;
            // 
            // grbComputersChoice
            // 
            this.grbComputersChoice.Controls.Add(this.radCChoiceRock);
            this.grbComputersChoice.Controls.Add(this.radCChoiceScissors);
            this.grbComputersChoice.Controls.Add(this.radCChoicePaper);
            this.grbComputersChoice.Enabled = false;
            this.grbComputersChoice.Location = new System.Drawing.Point(12, 155);
            this.grbComputersChoice.Name = "grbComputersChoice";
            this.grbComputersChoice.Size = new System.Drawing.Size(162, 93);
            this.grbComputersChoice.TabIndex = 3;
            this.grbComputersChoice.TabStop = false;
            this.grbComputersChoice.Text = "Computer\'s Choice";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(12, 263);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(74, 13);
            this.lblOutcome.TabIndex = 4;
            this.lblOutcome.Text = "The Winner Is";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(48, 126);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 289);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.grbComputersChoice);
            this.Controls.Add(this.grbUsersChoice);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors";
            this.grbUsersChoice.ResumeLayout(false);
            this.grbUsersChoice.PerformLayout();
            this.grbComputersChoice.ResumeLayout(false);
            this.grbComputersChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radUChoiceRock;
        private System.Windows.Forms.RadioButton radUChoicePaper;
        private System.Windows.Forms.RadioButton radUChoiceScissors;
        private System.Windows.Forms.GroupBox grbUsersChoice;
        private System.Windows.Forms.RadioButton radCChoiceRock;
        private System.Windows.Forms.RadioButton radCChoicePaper;
        private System.Windows.Forms.RadioButton radCChoiceScissors;
        private System.Windows.Forms.GroupBox grbComputersChoice;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnPlay;
    }
}

