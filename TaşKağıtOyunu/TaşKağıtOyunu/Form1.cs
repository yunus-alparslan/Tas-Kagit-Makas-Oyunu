using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaşKağıtOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int player=0,player2=0,player1puan=0,playerpuan=0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random randomat = new Random();
            player = randomat.Next(1, 8);
            player2 = randomat.Next(1, 8);

            if (player == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player == 6)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player == 7)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }  


            if (player2 == 1)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;

            }
            else if (player2 == 2)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player2 == 3)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player2 == 4)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player2 == 5)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player2 == 6)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
            else if (player2 == 7)
            {
                pictureBox3.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                //en başta gösterilen
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }

                

            // player1

            // kağıt                      // makas           
            if (pictureBox6.Visible == true & pictureBox2.Visible == true)
            {
                playerpuan++;
                label1.Text = playerpuan.ToString();
                
            }
            else if (pictureBox5.Visible == true & pictureBox1.Visible == true)
            {
                playerpuan++;
                label1.Text = playerpuan.ToString();
            }
            else if (pictureBox3.Visible == true & pictureBox4.Visible == true)
            {
                playerpuan++;
                label1.Text = playerpuan.ToString();
            }



            //PLAYER2


            if (pictureBox4.Visible == true & pictureBox6.Visible == true)
            {
                player1puan++;
                label2.Text = player1puan.ToString();

            }
            else if (pictureBox2.Visible == true & pictureBox5.Visible == true)
            {
                player1puan++;
                label2.Text = player1puan.ToString();
            }
            else if (pictureBox1.Visible == true & pictureBox3.Visible == true)
            {
                player1puan++;
                label2.Text = player1puan.ToString();
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
  
        }


        public string mesaj, mesaj2;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtPlayer.Text = mesaj;
            txtPlayer1.Text = mesaj2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
