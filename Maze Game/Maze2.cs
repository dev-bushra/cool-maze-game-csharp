using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Maze2 : Form
    {
        public Maze2()
        {
            InitializeComponent();
        }

        private void Maze2_Load(object sender, EventArgs e)
        {

        }
        int ErrorCounter = 0;
        private void Maze2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Get The Key That User Press
            char UserPressedKey = e.KeyChar;
            ////'Up Move
            if (UserPressedKey == 'w' || UserPressedKey == 'W')
            {
                pictureBox1.Top = pictureBox1.Top - 3;
            }
            ////'Down Move
            if (UserPressedKey == 's' || UserPressedKey == 'S')
            {
                pictureBox1.Top = pictureBox1.Top + 3;
            }
            ////'Right Move
            if (UserPressedKey == 'd' || UserPressedKey == 'D')
            {
                pictureBox1.Left = pictureBox1.Left + 3;
            }
            ////'Left Move
            if (UserPressedKey == 'a' || UserPressedKey == 'A')
            {
                pictureBox1.Left = pictureBox1.Left - 3;
            }
            //End Of Get The Key That User Press

            //Intersect Btween Lables and PictureBox
            if (pictureBox1.Bounds.IntersectsWith(label1.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label2.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label4.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label5.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

      
            if (pictureBox1.Bounds.IntersectsWith(label7.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label8.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label9.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label10.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label11.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label13.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }


            if (pictureBox1.Bounds.IntersectsWith(label15.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label16.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label17.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label18.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label19.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label20.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label21.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label22.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label23.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label24.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label25.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label26.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label27.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label28.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label32.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }


            if (pictureBox1.Bounds.IntersectsWith(label34.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label35.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label36.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label37.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }


            if (pictureBox1.Bounds.IntersectsWith(label40.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label40.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label41.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label42.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

  
            if (pictureBox1.Bounds.IntersectsWith(label45.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label46.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            if (pictureBox1.Bounds.IntersectsWith(label47.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 40;
                pictureBox1.Left = 30;
            }

            //End Of Intersect Btween Lables and PictureBox

            //End
            if (pictureBox1.Bounds.IntersectsWith(End_label.Bounds))
            {
                MessageBox.Show("You had hit the lines ( " + ErrorCounter + " ) times ...  CONGRATULATION!  :) You Fully Finshed This Game, Suport Us Down Below.");
                //new Maze3().Visible = true;
                new About().Show();
                this.Hide();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void End_label_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
