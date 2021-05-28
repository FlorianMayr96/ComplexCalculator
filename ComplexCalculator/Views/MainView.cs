using ComplexCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalculator.Views
{
    public partial class MainView : Form
    {
        public event EventHandler ShowHistoryView;
        public event EventHandler<Calculation> CalculationFinished;

        /// <summary>
        /// CTor
        /// </summary>
        public MainView()
        {
            InitializeComponent();
        }

        internal void RestoreCalculation(Calculation calculation)
        {
            tb_Number1.Text = calculation.FirstNumber.ToString();
            tb_Number2.Text = calculation.SecondNumber.ToString();
            tb_Result.Text = calculation.Result.ToString();
        }

        /// <summary>
        /// Eventhandler is called when user wants to add two complex numbers
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">Optional event arguments</param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            tssl_Message.Text = "Busy";
            if (TryParseNumber(tb_Number1.Text, "Number 1", out ComplexNumber number1) == true)
            {
                if (TryParseNumber(tb_Number2.Text, "Number 2", out ComplexNumber number2) == true)
                {
                    ComplexNumber result = number1 + number2;
                    tb_Result.Text = result.ToString();
                    tssl_Message.Text = "Ready";
                    CalculationFinished?.Invoke(this, new Calculation(number1, number2, result, "+"));
                }
            }
        }

        /// <summary>
        /// Eventhandler is called when user wants to substract two complex numbers
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">Optional event arguments</param>
        private void btn_Sub_Click(object sender, EventArgs e)
        {
            tssl_Message.Text = "Busy";
            if (TryParseNumber(tb_Number1.Text, "Number 1", out ComplexNumber number1) == true)
            {
                if (TryParseNumber(tb_Number2.Text, "Number 2", out ComplexNumber number2) == true)
                {
                    ComplexNumber result = number1 - number2;
                    tb_Result.Text = result.ToString();
                    tssl_Message.Text = "Ready";
                    CalculationFinished?.Invoke(this, new Calculation(number1, number2, result, "-"));
                }
            }
        }

        /// <summary>
        /// Eventhandler is called when user wants to multiplicate two complex numbers
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">Optional event arguments</param>
        private void btn_Mul_Click(object sender, EventArgs e)
        {
            tssl_Message.Text = "Busy";
            if (TryParseNumber(tb_Number1.Text, "Number 1", out ComplexNumber number1) == true)
            {
                if (TryParseNumber(tb_Number2.Text, "Number 2", out ComplexNumber number2) == true)
                {
                    ComplexNumber result = number1 * number2;
                    tb_Result.Text = result.ToString();
                    tssl_Message.Text = "Ready";
                    CalculationFinished?.Invoke(this, new Calculation(number1, number2, result, "*"));
                }
            }
        }

        /// <summary>
        /// Eventhandler is called when user wants to divide two complex numbers
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">Optional event arguments</param>
        private void btn_Div_Click(object sender, EventArgs e)
        {
            tssl_Message.Text = "Busy";
            if (TryParseNumber(tb_Number1.Text, "Number 1", out ComplexNumber number1) == true)
            {
                if (TryParseNumber(tb_Number2.Text, "Number 2", out ComplexNumber number2) == true)
                {
                    ComplexNumber result = number1 / number2;
                    tb_Result.Text = result.ToString();
                    tssl_Message.Text = "Ready";
                    CalculationFinished?.Invoke(this, new Calculation(number1, number2, result, "/"));
                }
            }
        }

        /// <summary>
        /// Tries to parse a string into a complex number and shows appropriate error messages
        /// </summary>
        /// <param name="str">The string that should be parsed</param>
        /// <param name="strName">The name of the string, that should be parsed</param>
        /// <param name="number">The number that has been successfully parsed</param>
        /// <returns>True if the number could be parsed, otherwise false.</returns>
        private bool TryParseNumber(string str, string strName, out ComplexNumber number)
        {
            number = null;

            try
            {
                number = ComplexNumber.Parse(str);
                return true;
            }
            catch (ArgumentNullException)
            {
                tssl_Message.Text = $"{strName} is undefined";
            }
            catch (FormatException)
            {
                tssl_Message.Text = $"{strName} has an invalid format";
            }
            catch (OverflowException)
            {
                tssl_Message.Text = $"{strName} causes an overflow exception";
            }

            return false;
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            ShowHistoryView?.Invoke(this, EventArgs.Empty);
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // show message box
            DialogResult result = MessageBox.Show(
                "Are you sure you want to quit the calculator?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // cancel the closing of the view
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
