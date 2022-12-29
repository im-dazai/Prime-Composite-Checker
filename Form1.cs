using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Number_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
           

            int n, i, Chk;

              n = Convert.ToInt32(txtBox.Text);

                Chk = 0;
                i = 2;
                while (i <= n / 2)
                {
                    if (n % i == 0)
                    {
                        Chk = 1;
                        break;
                    }
                    i++;
                }

           if (Chk == 0)
                MessageBox.Show(n + " is a Prime Number.");
            
            else
                MessageBox.Show(n + " is a Composite Number.");

        }
    }
    }
