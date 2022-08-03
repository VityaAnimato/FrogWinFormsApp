using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogWinFormsApp
{
    public partial class MainForm : Form
    {


        public int score;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

            if (distance > 2)
            {
                MessageBox.Show("Так нельзя!");
            }
            else
            {
                (emptyPictureBox.Location, clickedPicture.Location) = (clickedPicture.Location, emptyPictureBox.Location);
                score++;
                scoreLabel.Text = score.ToString();

                EndGame();
            }

        }

        private void EndGame()
        {
            bool isEnd = false;

            if (rightPictureBox1.Location.X < emptyPictureBox.Location.X)
                if (rightPictureBox2.Location.X < emptyPictureBox.Location.X)
                    if (rightPictureBox3.Location.X < emptyPictureBox.Location.X)
                        if (rightPictureBox4.Location.X < emptyPictureBox.Location.X)
                            if (leftPictureBox1.Location.X > emptyPictureBox.Location.X)
                                if (leftPictureBox2.Location.X > emptyPictureBox.Location.X)
                                    if (leftPictureBox3.Location.X > emptyPictureBox.Location.X)
                                        if (leftPictureBox4.Location.X > emptyPictureBox.Location.X)
                                            isEnd = true;



            if (isEnd)
            {
                var winGameForm = new WinGameForm();
                winGameForm.score = score;
                winGameForm.ShowDialog();
                Application.Restart();
            }

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поменяй лягушек местами 🐸🐸🐸🐸🐸\nнаименьшим количеством передвижений.\n\nПрыгать можно на кувшинку или через 1 лягушку!!!");
        }
    }
}
