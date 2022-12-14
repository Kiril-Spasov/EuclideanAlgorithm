using System;
using System.Windows.Forms;

namespace EuclideanAlgorithm
{
    public partial class FormEuclideanAlgorithm : Form
    {
        public FormEuclideanAlgorithm()
        {
            InitializeComponent();
        }

        private void BtnFindGCD_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter first number: ", "GCD"));
            int number2 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter second number: ", "GCD"));

            TxtResult.Text = "The GCD is " + FindGCD(number1, number2);
        }

        //"A more efficient method is the Euclidean algorithm,
        //a variant in which the difference of the two numbers a and b is replaced by the remainder of the Euclidean division (also called division with remainder) of a by b.
        //Denoting this remainder as a mod b, the algorithm replaces (a, b) by (b, a mod b) repeatedly until the pair is (d, 0),
        //where d is the greatest common divisor."
        //https://en.wikipedia.org/wiki/Greatest_common_divisor
        private int FindGCD(int n1, int n2)
        {
            int remainder;
            int result = 0;

            int number1 = Math.Abs(n1);
            int number2 = Math.Abs(n2);

            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                {
                    remainder = number1 % number2;
                    number1 = remainder;
                }
                else
                {
                    remainder = number2 % number1;
                    number2 = remainder;
                }

                if (remainder != 0)
                {
                    result = remainder;
                }
            }
            return result;
        }

        //Another implementation of the Euclidean algorithm.
        private int FindGCD2(int n1, int n2)
        {
            int remainder = 0;
            int temp = 0;

            int number1 = Math.Abs(n1);
            int number2 = Math.Abs(n2);

            if (number1 < number2)
            {
                number1 = temp;
                number1 = number2;
                number2 = temp;
            }

            while (true)
            {
                remainder = number1 % number2;

                if (remainder == 0)
                    break;

                number1 = number2;
                number2 = remainder;
            }

            return number2;
        }

        private void BtnGcdOf3Numbers_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter first number: ", "GCD"));
            int number2 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter second number: ", "GCD"));
            int number3 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter third number: ", "GCD"));

            TxtResult.Text = "The GCD is " + FindGCD(number1, FindGCD(number2, number3));
        }

        private void BtnFindLCM_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter first number: ", "LCD"));
            int number2 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter second number: ", "LCD"));

            TxtResult.Text = "The LCD is " + FindLCD(number1, number2);
        }

        //Finding the lowest common multiple using gcd. 
        private int FindLCD(int number1, int number2)
        {
            int lcd = number1 * number2 / FindGCD(number1, number2);

            return lcd;
        }
    }
}
