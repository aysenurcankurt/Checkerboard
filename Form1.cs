using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];//We will put an eight button for each row
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    this.Controls.Add(buttons[i, j]);
                    buttons[i, j].Left = left;
                    left += 50;
                    buttons[i, j].Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Red;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                }
                top += 50;
                left = 0;
            }

        }
    }
}
