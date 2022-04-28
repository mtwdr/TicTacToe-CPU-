using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_CPU_
{
    public partial class Form1 : Form
    {
        int[,] space = new int[3,3];

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private Boolean CheckXWin()
        {
            if(space[0,0] == 1 && space[0,1] == 1 && space[0,2] == 1 || //row wincheck
               space[1, 0] == 1 && space[1, 1] == 1 && space[1, 2] == 1 ||
               space[2, 0] == 1 && space[2, 1] == 1 && space[2, 2] == 1 ||

               space[0, 0] == 1 && space[1, 0] == 1 && space[2, 0] == 1 || //col wincheck
               space[0, 1] == 1 && space[1, 1] == 1 && space[2, 1] == 1 ||
               space[0, 2] == 1 && space[1, 2] == 1 && space[2, 2] == 1 ||

               space[0, 0] == 1 && space[1, 1] == 1 && space[2, 2] == 1 || //diag wincheck
               space[0, 2] == 1 && space[1, 1] == 1 && space[2, 0] == 1)
            {
                return true;
            }

            return false;
        }

        private Boolean CheckOWin()
        {
            if (space[0, 0] == 0 && space[0, 1] == 0 && space[0, 2] == 0 || //row wincheck
               space[1, 0] == 0 && space[1, 1] == 0 && space[1, 2] == 0 ||
               space[2, 0] == 0 && space[2, 1] == 0 && space[2, 2] == 0 ||

               space[0, 0] == 0 && space[1, 0] == 0 && space[2, 0] == 0 || //col wincheck
               space[0, 1] == 0&& space[1, 1] == 0 && space[2, 1] == 0 ||
               space[0, 2] == 0 && space[1, 2] == 0 && space[2, 2] == 0 ||

               space[0, 0] == 0 && space[1, 1] == 0 && space[2, 2] == 0 || //diag wincheck
               space[0, 2] == 0 && space[1, 1] == 0 && space[2, 0] == 0)
            {
                return true;
            }

            return false;
        }
        private void newgame_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < space.GetLength(0); i++)
            {
                for(int j = 0; j < space.GetLength(1); j++)
                {
                    space[i, j] = rand.Next(0, 2);
                }
            }

            // 0 = O, 1 = X
            //row 1
            if (space[0,0] == 0)
            {
                space0_0.Text = "O";
            } else if (space[0,0] == 1)
            {
                space0_0.Text = "X";
            }

            if (space[0, 1] == 0)
            {
                space0_1.Text = "O";
            }
            else if (space[0, 1] == 1)
            {
                space0_1.Text = "X";
            }

            if (space[0, 2] == 0)
            {
                space0_2.Text = "O";
            }
            else if (space[0, 2] == 1)
            {
                space0_2.Text = "X";
            }

            //row 2
            if (space[1, 0] == 0)
            {
                space1_0.Text = "O";
            }
            else if (space[1, 0] == 1)
            {
                space1_0.Text = "X";
            }

            if (space[1, 1] == 0)
            {
                space1_1.Text = "O";
            }
            else if (space[1, 1] == 1)
            {
                space1_1.Text = "X";
            }

            if (space[1, 2] == 0)
            {
                space1_2.Text = "O";
            }
            else if (space[1, 2] == 1)
            {
                space1_2.Text = "X";
            }

            //row 3
            if (space[2, 0] == 0)
            {
                space2_0.Text = "O";
            }
            else if (space[2, 0] == 1)
            {
                space2_0.Text = "X";
            }

            if (space[2, 1] == 0)
            {
                space2_1.Text = "O";
            }
            else if (space[2, 1] == 1)
            {
                space2_1.Text = "X";
            }

            if (space[2, 2] == 0)
            {
                space2_2.Text = "O";
            }
            else if (space[2, 2] == 1)
            {
                space2_2.Text = "X";
            }

            if (CheckOWin() == true)
            {
                outcomelabel.Text = "O Wins!";
            } else if (CheckXWin() == true)
            {
                outcomelabel.Text = "X Wins!";
            }

            if (CheckOWin() == true && CheckXWin() == true || CheckOWin() == false && CheckXWin() == false)
            {
                outcomelabel.Text = "Draw";
            }
        }

        private void space0_0_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
