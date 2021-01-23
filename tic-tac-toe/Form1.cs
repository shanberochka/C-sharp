using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Project
{
    public partial class Form1 : Form
    {
        bool gameStarted;
        bool xTurn = true;
        bool end = false;
        public Form1()
        {
            
            InitializeComponent();
            label1.Text = "Ходят Х" ;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                (sender as Button).Text = "X";
                label1.Text = "Ходят О";
                this.BackColor = System.Drawing.Color.SlateGray;
            }
            else
            {
                (sender as Button).Text = "O";
                label1.Text = "Ходят Х";
                this.BackColor = System.Drawing.Color.RoyalBlue;
            }
            xTurn = !xTurn;
            (sender as Button).Enabled = false;
            gameStarted = true;
            
            CheckWin((sender as Button));
        }

        void CheckWin(Button pressedButton)
        {
          //  Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            if (button1.Text == button2.Text && button2.Text == button3.Text && button2.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                end = true;
                // foreach (var button in buttons)Enabled = false;
                Application.Restart();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                end = true;
                // foreach (var button in buttons) Enabled = false;
                Application.Restart();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                end = true;
                // foreach (var button in buttons) Enabled = false;
                Application.Restart();
            }


            if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                end = true;
                // foreach (var button in buttons)Enabled = false;
                Application.Restart();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                end = true;
                // this.Enabled = false;
                Application.Restart();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button6.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                end = true;
                // this.Enabled = false;
                Application.Restart();
            }

            if (button1.Text == button5.Text && button5.Text == button9.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                end = true;
                // this.Enabled = false;
                Application.Restart();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text);
                end = true;
                // this.Enabled = false;
                Application.Restart();
            }
            if (end == false && button1.Text != " " && button2.Text != " " && button3.Text != " " && button4.Text != " " && button5.Text != " " && button6.Text != " " && button7.Text != " " && button8.Text != " " && button9.Text != " ")
            {
                MessageBox.Show("Ничья ");
                end = true;
                Application.Restart();
            }

        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                xTurn = true;
            }
           
        }

        private void OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                xTurn = false;
            }
        }

        private void CreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Alsu");
        }
    }
}
