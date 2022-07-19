using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moment4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKor_Click(object sender, EventArgs e)
        {
            var tal = int.Parse(tBoxTal.Text);
            tBoxOut.Clear();
            tboxColor.Clear();

            StringBuilder sb = new StringBuilder($"Alla primatal från 0 till {tal}: \r\n");

            bool primtal = true;
            int max = tal;


            for (int i = 2; i <= max; i++)
            {
                primtal = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primtal = false;
                    }
                }
                if (primtal)
                {
                    sb.Append($"{i}   ");
                    tBoxOut.Text = sb.ToString();
                }
            }

            if (primtal)
            {
                tboxColor.Text = "Talet är en primtal";
                tboxColor.BackColor = Color.Green;
            }
            else
            {
                tboxColor.Text += "Talet är inte ett primtal";
                tboxColor.BackColor = Color.Red;
            }
        }
    }
}



