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
    public partial class Maze1 : Form
    {
        public Maze1()
        {
            InitializeComponent();
                     
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
        }
        int ErrorCounter = 0;
        private void Maze1_KeyPress(object sender, KeyPressEventArgs e)
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
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label2.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label3.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label4.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label5.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label6.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label7.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label8.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label9.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label10.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label11.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label12.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label13.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label14.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label15.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label16.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label17.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label18.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label19.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label20.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label21.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label22.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label23.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label24.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label25.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label26.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label27.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label28.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }


            if (pictureBox1.Bounds.IntersectsWith(label29.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label30.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label31.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label32.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label33.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label34.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label35.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label36.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label37.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label38.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label39.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label40.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label41.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label42.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label43.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label44.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label45.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label46.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            if (pictureBox1.Bounds.IntersectsWith(label47.Bounds))
            {
                MessageBox.Show("Ooops");
                ErrorCounter = ErrorCounter + 1;
                pictureBox1.Top = 28;
                pictureBox1.Left = 282;
            }

            //End Of Intersect Btween Lables and PictureBox

            //End
            if (pictureBox1.Bounds.IntersectsWith(End_label.Bounds))
            {
            MessageBox.Show("CONGRATULATION! :) ... You had hit the lines ( " + ErrorCounter+" ) times.");
            //new Maze2().Visible = true;
            new Maze2().Show();
            this.Hide();
            }


        }

        private void Maze1_Load(object sender, EventArgs e)
        {
           
        }

        private void h2_label_Click(object sender, EventArgs e)
        {

        }

        private void h1_label_Click(object sender, EventArgs e)
        {

        }

        private void h3_label_Click(object sender, EventArgs e)
        {

        }

        private void Time_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Time_label_Click_1(object sender, EventArgs e)
        {   
        }

        private void score_lable_Click(object sender, EventArgs e)
        {
            
        }

        private void End_label_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Maze1().Show();
        }

        private void End_label_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Congreatulations :) , move to level 2 now");
            //new Maze2().Show();
            //this.Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
