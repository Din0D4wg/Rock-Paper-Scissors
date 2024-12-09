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
    public partial class Pick5 : Form
    {
        int rounds5 = 1;
        int Time5 = 5;
        bool gameover5 = false;

        string[] Choices5 = { "rock", "paper", "scissors", "scissors", "paper", "rock" };

        int rannum5 = 0;
        Random ran5 = new Random();

        string Comp5;
        string User5;

        int userscore5;
        int compscore5;



        public Pick5()
        {
            InitializeComponent();
            pbbg5.Controls.Add(txtComp5);
            pbbg5.Controls.Add(txtround5);
            pbbg5.Controls.Add(txtScore5);
            pbbg5.Controls.Add(txttime5);
            pbbg5.Controls.Add(txtuser5);
            txtComp5.BackColor = Color.Transparent;
            txtround5.BackColor = Color.Transparent;
            txtScore5.BackColor = Color.Transparent;
            txttime5.BackColor = Color.Transparent;
            txtuser5.BackColor = Color.Transparent;

            CountDown5.Enabled = true;

            User5 = "none";
            txttime5.Text = "5";

        }

        private void Pick5_Load(object sender, EventArgs e)
        {

        }

        private void btnrock5_Click(object sender, EventArgs e)
        {
            pbuser5.Image = Properties.Resources.rock;
            User5 = "rock";
        }

        private void btnpaper5_Click(object sender, EventArgs e)
        {
            pbuser5.Image = Properties.Resources.paper;
            User5 = "paper";
        }

        private void btnscissors5_Click(object sender, EventArgs e)
        {
            pbuser5.Image = Properties.Resources.scissors;
            User5 = "scissors";
        }

        private void countdownevent5(object sender, EventArgs e)
        {
            Time5--;
            txttime5.Text = Time5.ToString();

            txtround5.Text = "Round: " + rounds5;

            if (Time5 <= 0)
            {
                CountDown5.Enabled = false;

                Time5 = 5;

                rannum5 = ran5.Next(0, Choices5.Length);

                Comp5 = Choices5[rannum5];

                switch (Comp5)
                {
                    case "rock":
                        pbcomp5.Image = Properties.Resources.rock;
                        break;

                    case "paper":
                        pbcomp5.Image = Properties.Resources.paper;
                        break;

                    case "scissors":
                        pbcomp5.Image = Properties.Resources.scissors;
                        break;


                }
                if (rounds5 <= 4)
                {
                    checkgame5();

                    Time5 = 5;
                    CountDown5.Enabled = true;
                }
                else
                {
                    if (userscore5 > compscore5)
                    {
                        MessageBox.Show("User wins!");

                    }
                    else if (userscore5 < compscore5)
                    {
                        MessageBox.Show("Computer wins!");

                    }
                    else
                    {
                        MessageBox.Show("It's a tie!! Last Round, Winner takes all...");

                        rounds5++;
                        Time5 = 5;
                        CountDown5.Enabled = true;
                    }

                    gameover5 = true;
                }
            }
        }

        private void checkgame5()
        {
            switch (User5)
            {
                case "rock":
                    if (Comp5 == "rock")
                    {
                        MessageBox.Show("It's a draw!");

                    }
                    else if (Comp5 == "paper")
                    {
                        compscore5 += 1;
                        rounds5 += 1;
                        MessageBox.Show("You lose!");

                    }
                    else
                    {
                        userscore5 += 1;
                        rounds5 += 1;
                        MessageBox.Show("You win!");

                    }
                    break;

                case "paper":
                    if (Comp5 == "paper")
                    {
                        MessageBox.Show("It's a draw!");
                    }
                    else if (Comp5 == "scissors")
                    {
                        compscore5 += 1;
                        rounds5 += 1;
                        MessageBox.Show("You lose!");
                    }
                    else
                    {
                        userscore5 += 1;
                        rounds5 += 1;
                        MessageBox.Show("You win!");
                    }
                    break;

                case "scissors":
                    if (Comp5 == "scissors")
                    {
                        MessageBox.Show("It's a draw!");
                    }
                    else if (Comp5 == "rock")
                    {
                        compscore5 += 1;
                        rounds5 += 1;
                        MessageBox.Show("You lose!");
                    }
                    else
                    {
                        userscore5 += 1;
                        rounds5 += 1;
                        MessageBox.Show("You win!");
                    }
                    break;

                default:
                    MessageBox.Show("Please make a choice");
                    break;


            }

            NextGame5();
        }

        private void NextGame5()
        {
            if (gameover5 == true)
            {
                return;
            }

            txtScore5.Text = "User: " + userscore5 + "                              " + "Computer: " + compscore5;

            User5 = "none";

            CountDown5.Enabled = true;

            pbuser5.Image = Properties.Resources.question_mark;
            pbcomp5.Image = Properties.Resources.question_mark;




        }

        private void btnhome5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
