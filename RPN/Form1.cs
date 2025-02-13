using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPN
{
    public partial class Form1 : Form
    {

        private IStack<double> stack;
        private PolishNotationCalculator calculator;

        public Form1()
        {
            InitializeComponent();
            stack = new ArrayStack<double>(20);
            calculator = new PolishNotationCalculator(stack);
        }

        private void Btn_Eval_Click(object sender, EventArgs e)
        {
            try
            {
                Lbl_Output.Text = calculator.Evaluate(Txt_Input.Text).ToString();
                Lbl_Output.ForeColor = Color.Black;
            }
            catch (Exception error){ 
                    Lbl_Output.Text = error.Message;
                    Lbl_Output.ForeColor = Color.Red;

            }

            
        }
    }
}
