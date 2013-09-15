using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _313Score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            var player1Score = Int32.Parse(Player1Score.Text);
            var player2Score = Int32.Parse(Player2Score.Text);

            if (player1Score > player2Score)
            {
                MessageBox.Show("Player 1 Wins");
            }
            else if (player1Score < player2Score)
            {
                MessageBox.Show("Player 2 Wins");
            }
            else
            {
                MessageBox.Show("Tie");
            }
        }
    }
}
