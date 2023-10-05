using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        double firstNum;
        double secondNum;
        double number;
        string operatorFunction;
        double result;
        bool onSecondNum = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {

            if (onSecondNum == true)
            {
                var button = (Button)sender;
                numberHolder.Text += button.Text;
                secondNum = int.Parse(numberHolder.Text);
            }

            else
            {
                var button = (Button)sender;
                numberHolder.Text += button.Text;
            }
        }

        private void clearButton_Clicked(object sender, EventArgs e)
        {
            onSecondNum = false;
            numberHolder.Text = "";
        }

        private void buttonEqual_Clicked(object sender, EventArgs e)
        {
            switch (operatorFunction)
            {
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
            }

            numberHolder.Text = result.ToString();
            onSecondNum = false;
        }

        private void buttonDivide_Clicked(object sender, EventArgs e)
        {
            if (onSecondNum == true)
            {
                double.TryParse(numberHolder.Text, out secondNum);
                result = firstNum / secondNum;
                numberHolder.Text = result.ToString();
                firstNum = result;

            }

            else
            {
                onSecondNum = true;
                double.TryParse(numberHolder.Text, out firstNum);
                operatorFunction = "/";
                numberHolder.Text = "";
            }
        }

        private void buttonMultiply_Clicked(object sender, EventArgs e)
        {
            if(onSecondNum == true)
            {
                double.TryParse(numberHolder.Text, out secondNum);
                result = firstNum * secondNum;
                numberHolder.Text = result.ToString();
                firstNum = result;

            }

            else
            {
                onSecondNum = true;
                double.TryParse(numberHolder.Text, out firstNum);
                operatorFunction = "*";
                numberHolder.Text = "";
            }
        }

        private void buttonSubtract_Clicked(object sender, EventArgs e)
        {
            if (onSecondNum == true)
            {
                double.TryParse(numberHolder.Text, out secondNum);
                result = firstNum - secondNum;
                numberHolder.Text = result.ToString();
                firstNum = result;

            }

            else
            {
                onSecondNum = true;
                double.TryParse(numberHolder.Text, out firstNum);
                operatorFunction = "-";
                numberHolder.Text = "";
            }
        }

        private void buttonAdd_Clicked(object sender, EventArgs e)
        {
            if (onSecondNum == true)
            {
                double.TryParse(numberHolder.Text, out secondNum);
                result = firstNum + secondNum;
                numberHolder.Text = result.ToString();
                firstNum = result;

            }

            else
            {
                onSecondNum = true;
                double.TryParse(numberHolder.Text, out firstNum);
                operatorFunction = "+";
                numberHolder.Text = "";
            }
        }

        private void percentButton_Clicked(object sender, EventArgs e)
        {
            double.TryParse(numberHolder.Text, out number);
            number /= 100;
            numberHolder.Text = number.ToString();
        }

        private void xSquaredButton_Clicked(object sender, EventArgs e)
        {
            double.TryParse(numberHolder.Text, out number);
            number = Math.Pow(number, 2);
            numberHolder.Text = number.ToString();
        }

        private void piButton_Clicked(object sender, EventArgs e)
        {
            numberHolder.Text = Math.PI.ToString();
        }
    }
}
