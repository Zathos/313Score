namespace _313Score
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
            this.Player1Score = new System.Windows.Forms.TextBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.TextBox();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1Score
            // 
            this.Player1Score.Location = new System.Drawing.Point(12, 54);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(45, 20);
            this.Player1Score.TabIndex = 0;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(12, 22);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(45, 13);
            this.Player1.TabIndex = 1;
            this.Player1.Text = "Player 1";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(63, 22);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(45, 13);
            this.Player2.TabIndex = 3;
            this.Player2.Text = "Player 2";
            // 
            // Player2Score
            // 
            this.Player2Score.Location = new System.Drawing.Point(66, 54);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(42, 20);
            this.Player2Score.TabIndex = 2;
            // 
            // ScoreButton
            // 
            this.ScoreButton.Location = new System.Drawing.Point(12, 80);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(96, 31);
            this.ScoreButton.TabIndex = 4;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 122);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player1Score);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Player1Score;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.TextBox Player2Score;
        private System.Windows.Forms.Button ScoreButton;

    }
}

