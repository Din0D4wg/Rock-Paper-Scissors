using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Rock_Paper_Scissors
{
    public partial class Pick10 : Form
    {
        int rounds10 = 1;
        int Time10 = 5;
        bool gameover10 = false;

        string[] Choices10 = { "rock", "paper", "scissors", "scissors", "paper", "rock" };

        int rannum10 = 0;
        Random ran10 = new Random();

        string Comp10;
        string User10;

        int userscore10;
        int compscore10;


        public Pick10()
        {
            InitializeComponent();

            pbbg10.Controls.Add(txtComp10);
            pbbg10.Controls.Add(txtround10);
            pbbg10.Controls.Add(txtScore10);
            pbbg10.Controls.Add(txttime10);
            pbbg10.Controls.Add(txtuser10);
            txtComp10.BackColor = Color.Transparent;
            txtround10.BackColor = Color.Transparent;
            txtScore10.BackColor = Color.Transparent;
            txttime10.BackColor = Color.Transparent;
            txtuser10.BackColor = Color.Transparent;

            CountDown10.Enabled = true;

            User10 = "none";
            txttime10.Text = "5";
        }

        private void Pick10_Load(object sender, EventArgs e)
        {

        }

        private void btnrock10_Click(object sender, EventArgs e)
        {
            pbuser10.Image = Properties.Resources.rock;
            User10 = "rock";
        }

        private void btnpaper10_Click(object sender, EventArgs e)
        {
            pbuser10.Image = Properties.Resources.paper;
            User10 = "paper";
        }

        private void btnscissors10_Click(object sender, EventArgs e)
        {
            pbuser10.Image = Properties.Resources.scissors;
            User10 = "scissors";
        }

        private void countdownevent10(object sender, EventArgs e)
        {
            Time10--;
            txttime10.Text = Time10.ToString();

            txtround10.Text = "Round: " + rounds10;

            if (Time10 <= 0)
            {
                CountDown10.Enabled = false;

                Time10 = 5;

                rannum10 = ran10.Next(0, Choices10.Length);

                Comp10 = Choices10[rannum10];

                switch (Comp10)
                {
                    case "rock":
                        pbcomp10.Image = Properties.Resources.rock;
                        break;

                    case "paper":
                        pbcomp10.Image = Properties.Resources.paper;
                        break;

                    case "scissors":
                        pbcomp10.Image = Properties.Resources.scissors;
                        break;


                }
                if (rounds10 <= 9)
                {
                    checkgame10();

                    Time10 = 5;
                    CountDown10.Enabled = true;
                }
                else
                {
                    if (userscore10 > compscore10)
                    {
                        MessageBox.Show("User wins!");

                    }
                    else if (userscore10 < compscore10)
                    {
                        MessageBox.Show("Computer wins!");

                    }
                    else
                    {
                        MessageBox.Show("It's a tie!! Last Round, Winner takes all...");

                        rounds10++;
                        Time10 = 5;
                        CountDown10.Enabled = true;
                    }

                        gameover10 = true;
                }
            }
        }

        private void checkgame10()
        {
            switch (User10)
            {
                case "rock":
                    if (Comp10 == "rock")
                    {
                        MessageBox.Show("It's a draw!");

                    }
                    else if (Comp10== "paper")
                    {
                        compscore10 += 1;
                        rounds10 += 1;
                        MessageBox.Show("You lose!");

                    }
                    else
                    {
                        userscore10 += 1;
                        rounds10 += 1;
                        MessageBox.Show("You win!");

                    }
                    break;

                case "paper":
                    if (Comp10 == "paper")
                    {
                        MessageBox.Show("It's a draw!");
                    }
                    else if (Comp10 == "scissors")
                    {
                        compscore10 += 1;
                        rounds10 += 1;
                        MessageBox.Show("You lose!");
                    }
                    else
                    {
                        userscore10 += 1;
                        rounds10 += 1;
                        MessageBox.Show("You win!");
                    }
                    break;

                case "scissors":
                    if (Comp10 == "scissors")
                    {
                        MessageBox.Show("It's a draw!");
                    }
                    else if (Comp10 == "rock")
                    {
                        compscore10 += 1;
                        rounds10 += 1;
                        MessageBox.Show("You lose!");
                    }
                    else
                    {
                        userscore10 += 1;
                        rounds10 += 1;
                        MessageBox.Show("You win!");
                    }
                    break;

                default:
                    MessageBox.Show("Please make a choice");
                    break;


            }

            NextGame10();
        }

        private void NextGame10()
        {
            if (gameover10 == true)
            {
                return;
            }

            txtScore10.Text = "User: " + userscore10 + "                              " + "Computer: " + compscore10;

            User10 = "none";

            CountDown10.Enabled = true;

            pbuser10.Image = Properties.Resources.question_mark;
            pbcomp10.Image = Properties.Resources.question_mark;




        }

        private void btnhome10_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
