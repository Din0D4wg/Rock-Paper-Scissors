using Microsoft.VisualBasic.Devices;
using Rock_Paper_Scissors.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Pick3 : Form
    {
        int rounds = 1;
        int Time = 5;
        bool gameover = false;

        string[] Choices = { "rock", "paper", "scissors", "scissors", "paper", "rock"};

        int rannum = 0;
        Random ran = new Random();

        string Comp;
        string User;

        int userscore;
        int compscore;


        public Pick3()
        {
            InitializeComponent();
            pbbg.Controls.Add(txtComp);
            pbbg.Controls.Add(txtround);
            pbbg.Controls.Add(txtScore);
            pbbg.Controls.Add(txttime);
            pbbg.Controls.Add(txtuser);
            txtComp.BackColor = Color.Transparent;
            txtround.BackColor = Color.Transparent;
            txtScore.BackColor = Color.Transparent;
            txttime.BackColor = Color.Transparent;
            txtuser.BackColor = Color.Transparent;

             CountDown.Enabled = true;

            User = "none";
            txttime.Text = "5";
        }

        private void pbbg_Click(object sender, EventArgs e)
        {
            

        }

        private void btnrock_Click(object sender, EventArgs e)
        {
            pbuser.Image = Properties.Resources.rock;
            User = "rock";


        }

        private void btnpaper_Click(object sender, EventArgs e)
        {
            pbuser.Image = Properties.Resources.paper;
            User = "paper";

        }

        private void btnscissors_Click(object sender, EventArgs e)
        {
            pbuser.Image= Properties.Resources.scissors;
            User = "scissors";
        }


        private void countdownevent(object sender, EventArgs e)
        {
            Time --;
            txttime.Text= Time.ToString();

            txtround.Text = "Rounds : " + rounds;

            if (Time <= 0)
            {
                CountDown.Enabled = false;

                Time = 5;

                rannum = ran.Next(0, Choices.Length);

                Comp = Choices[rannum];

                switch (Comp)
                {
                    case "rock":
                        pbcomp.Image = Properties.Resources.rock;
                        break;

                    case "paper":
                        pbcomp.Image= Properties.Resources.paper;
                        break;

                    case "scissors":
                        pbcomp.Image= Properties.Resources.scissors;
                        break;


                }

                if (rounds <= 2)
                {
                    checkgame();

                    Time = 5;
                    CountDown.Enabled = true;
                } else
                {
                    if (userscore > compscore)
                    {
                        MessageBox.Show("User wins!");

                    } else if (userscore < compscore)
                    {
                        MessageBox.Show("Computer wins!");

                    } else
                    {
                        MessageBox.Show("It's a tie!! Last Round, Winner takes all...");

                        rounds++;
                        Time = 5;
                        CountDown.Enabled= true;
                    }

                    gameover = true;
                }
            }
        }

        private void checkgame()
        {
            switch (User)
            {
                case "rock":
                    if (Comp == "rock")
                    {
                        MessageBox.Show("It's a draw!");
                        
                    }
                    else if (Comp == "paper")
                    {
                        compscore += 1;
                        rounds += 1;
                        MessageBox.Show("You lose!");
                        
                    }
                    else
                    {
                        userscore += 1;
                        rounds += 1;
                        MessageBox.Show("You win!");
                        
                    }
                    break;

                case "paper":
                    if (Comp == "paper")
                    {
                        MessageBox.Show("It's a draw!");
                    }
                    else if (Comp == "scissors")
                    {
                        compscore += 1;
                        rounds += 1;
                        MessageBox.Show("You lose!");
                    }
                    else
                    {
                        userscore += 1;
                        rounds += 1;
                        MessageBox.Show("You win!");
                    }
                    break;

                case "scissors":
                    if (Comp == "scissors")
                    {
                        MessageBox.Show("It's a draw!");
                    }
                    else if (Comp == "rock")
                    {
                        compscore += 1;
                        rounds += 1;
                        MessageBox.Show("You lose!");
                    }
                    else
                    {
                        userscore += 1;
                        rounds += 1;
                        MessageBox.Show("You win!");
                    } 
                    break;

                default:
                    MessageBox.Show("Please make a choice");
                    break;


            }

            NextGame();

        }

        private void NextGame ()
        {
            if (gameover == true)
            {
                return;
            }

            txtScore.Text = "User: " + userscore + "                              " + "Computer: " + compscore;

            User = "none";

            CountDown.Enabled = true;

            pbuser.Image = Properties.Resources.question_mark;
            pbcomp.Image = Properties.Resources.question_mark;




        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();

        }
    }
}
