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
    public partial class Game : Form 
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
        
        }

      string player, player2;

       private void button2_Click(object sender, EventArgs e)
       {
           player = textBox1.Text;
           player2 = textBox2.Text;

           Form1 frm = new Form1();
           frm.mesaj = player;
           frm.mesaj2 = player2;
           frm.Show();
           this.Hide();

      


       }

       private void button1_Click(object sender, EventArgs e)
       {
           Application.Exit();
       } 

    }
}
