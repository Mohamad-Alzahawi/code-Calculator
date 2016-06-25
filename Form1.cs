using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int Total_Number = 0;
        double varilbles1;
        double varilbles2;
        int addition = 0;
        int miuns = 0;
        int mup = 0;
        int div = 0;
        int mobBit = 0;
        Boolean bl = false;
        String x, y;

        public void Ena()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnPoint.Enabled = true;
            btnPuls.Enabled = true;
            btnMiuns.Enabled = true;
            btnEqual.Enabled = true;
            btnDiv.Enabled = true;
            btnClr.Enabled = true;
            btnBack.Enabled = true;
            btnBreating.Enabled = true;
            txtCl.Enabled = true;
            btnTrun.Enabled = false;
        }
        public void rest()
        {
            addition = 0;
            miuns = 0;
            mup = 0;
            div = 0;
            mobBit = 0;
            bl = false;
        }
        public void Calculatory()
        {
            if(txtCl.Text !=".")
            {
                varilbles2 = Convert.ToDouble(txtCl.Text);
                if(bl == false)
                {
                    varilbles1 = varilbles2;
                }
                else if(addition == 1)
                {
                    varilbles1 = varilbles1 + varilbles2;
                }
                else if(miuns == 1)
                {
                    varilbles1 = varilbles1 - varilbles2;
                }
                else if(mup ==1)
                {
                    varilbles1 = varilbles1 * varilbles2;
                }
                else if(div == 1)
                {
                    varilbles1 = varilbles1 / varilbles2;
                }
                else if (mobBit ==1)
                {
                    varilbles2 = Convert.ToInt32(txtCl.Text);
                    varilbles1 = Convert.ToInt32(varilbles1 % varilbles2);
                }
                else
                {
                    varilbles1 = varilbles2;
                }
                txtCl.Text = Convert.ToString(varilbles1);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrun_Click(object sender, EventArgs e)
        {
            Ena();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(1);
            }
            else if(Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(1);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(2);
            }
            else if (Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(2);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(3);
            }
            else if (Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(3);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(4);
            }
            else if (Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(4);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(5);
            }
            else if (Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(5);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(6);
            }
            else if (Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(6);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(7);
            }
            else if (Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(7);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(8);
            }
            else if (Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(8);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(9);
            }
            else if (Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(9);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Total_Number == 0)
            {
                txtCl.Text = txtCl.Text + Convert.ToString(0);
            }
            else if (Total_Number == 1)
            {
                txtCl.Text = Convert.ToString(0);
                Total_Number = 0;
            }
            bl = true;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            int i = 0;
            char c = '\0';
            int Desiml = 0;
            int o = txtCl.Text.Length-1;

            if(Total_Number != 1)
            {
                for (i = 0; i <= o; i++)
                {
                    c = txtCl.Text[i];
                    if(c=='.')
                    {
                        Desiml = 1;
                    }
                }
                if(Desiml !=1)
                {
                    txtCl.Text = txtCl.Text + Convert.ToString(".");
                }
                
            }
        }

        private void txtCl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            x = txtCl.Text;
            int l = x.Length;
            for (int i = 0; i < l - 1; i++)
            {
                y += x[i];
            }
            txtCl.Text = y;
            y = "";
        }

        private void btnBreating_Click(object sender, EventArgs e)
        {
            if(txtCl.Text.Length !=0)
            {
                Calculatory();
                rest();
                mup = 1;
                Total_Number = 1;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtCl.Text.Length != 0)
            {
                Calculatory();
                rest();
                div = 1;
                Total_Number = 1;
            }
        }

        private void btnPuls_Click(object sender, EventArgs e)
        {
            if (txtCl.Text.Length != 0)
            {
                Calculatory();
                rest();
                addition = 1;
                Total_Number = 1;
            }
        }

        private void btnMiuns_Click(object sender, EventArgs e)
        {
            if (txtCl.Text.Length != 0)
            {
                varilbles2 = Convert.ToInt32(txtCl.Text);
                Calculatory();
                rest();
                miuns = 1;
                Total_Number = 1;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtCl.Text.Length != 0)
            {
                Calculatory();
                rest();      
            }
            Total_Number = 1;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtCl.Clear();
            Total_Number = 0;
            varilbles1 = 0;
            varilbles2 = 0;
            rest();


        }
    }
}
