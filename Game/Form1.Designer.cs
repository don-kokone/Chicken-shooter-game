namespace Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.MissShots = new System.Windows.Forms.Label();
            this.TotalShots = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameOverLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(178, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 107);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Score.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Red;
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(96, 36);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score";
            // 
            // MissShots
            // 
            this.MissShots.AutoSize = true;
            this.MissShots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MissShots.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissShots.ForeColor = System.Drawing.Color.Red;
            this.MissShots.Location = new System.Drawing.Point(12, 45);
            this.MissShots.Name = "MissShots";
            this.MissShots.Size = new System.Drawing.Size(196, 36);
            this.MissShots.TabIndex = 3;
            this.MissShots.Text = "Missed shots";
            // 
            // TotalShots
            // 
            this.TotalShots.AutoSize = true;
            this.TotalShots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TotalShots.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalShots.ForeColor = System.Drawing.Color.Red;
            this.TotalShots.Location = new System.Drawing.Point(12, 81);
            this.TotalShots.Name = "TotalShots";
            this.TotalShots.Size = new System.Drawing.Size(170, 36);
            this.TotalShots.TabIndex = 4;
            this.TotalShots.Text = "Total shots";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(900, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(111, 40);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RestartButton.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.Color.Red;
            this.RestartButton.Location = new System.Drawing.Point(900, 58);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(111, 40);
            this.RestartButton.TabIndex = 6;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.GameOverLabel.Location = new System.Drawing.Point(372, 17);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(0, 71);
            this.GameOverLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1023, 550);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TotalShots);
            this.Controls.Add(this.MissShots);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1039, 589);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1039, 589);
            this.Name = "Form1";
            this.Text = "Chicken marksman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label MissShots;
        private System.Windows.Forms.Label TotalShots;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label GameOverLabel;
    }
}

