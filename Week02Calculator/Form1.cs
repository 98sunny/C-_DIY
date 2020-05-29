using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* private void num1_TextChanged(object sender, EventArgs e)
        {
            
        }*/

        private void calculate_Click(object sender, EventArgs e)
        {
            int num1, num2;
            double ans=0;
            String op;
            num1 = Convert.ToInt32(txtOp1.Text);
            num2 = Convert.ToInt32(txtOp2.Text);
            op = txtOperand.Text;
            switch (op) {
                case "+":
                    ans=num1 + num2;
                    break;
                case "-":
                    ans = num1 - num2;
                    break;
                case "*":
                    ans = num1 * num2;
                    break;
                case "/":
                    ans = num1 / num2;
                    break;
                case "%":
                    ans = num1 % num2;
                    break;
                case "^":
                    ans = 1;
                    for (int i = 0; i < num2; i++)
                        ans *= num1;
                    break;
            }
            txtResult.Text = ans.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
