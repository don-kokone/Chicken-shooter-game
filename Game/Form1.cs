using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
                    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fn_shots();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void fn_Sound ()
        {
            System.Media.SoundPlayer soundEffect = new System.Media.SoundPlayer(@"C: \Users\Hristina\Desktop\shotgun-sound.wav");
            soundEffect.Play();

        }
        Random r = new Random();
        int score = 0;
        int totalShots = 0;
        int missedShots = 0;

        void fn_shots()
        {
            
            score++;
            Score.Text = "Score: " + score;

            totalShots++;
            TotalShots.Text = "Total shots: " + totalShots;
            fn_Sound();
            
        }

        void fn_missedShots()
        {
            missedShots++;
            MissShots.Text = "Missed shots: " + missedShots;
            totalShots++;
            TotalShots.Text = "Total shots: " + totalShots;
            fn_Sound();
        }
        void resetGame()
        {
            score = 0;
            totalShots = 0;
            missedShots = 0;
            Score.Text = "Score: " + score;
            MissShots.Text = "Missed shots: " + missedShots;
            TotalShots.Text = "Total shots: " + totalShots;
            timer1.Start();
            GameOverLabel.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(100, 900 );
            y = r.Next(100, 450);
            pictureBox2.Location = new Point(x, y);

            if (missedShots >= 25)
            {
                
                timer1.Stop();
                GameOverLabel.Text = "Game over!";
                
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            fn_missedShots();
            
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
