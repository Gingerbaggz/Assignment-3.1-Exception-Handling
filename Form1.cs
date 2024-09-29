using System;
using System.Windows.Forms;

namespace Assignment_3._1_Exception_Handling
//Steven Chance
//MS539
//Assignment 3.1
//Estimated Time: 1 hour
//Actual Time: 4 hours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //divide 100 by the input number
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            //parse the input from the textbox to an integer
                int number = int.Parse(textBox1.Text);
                int result = 100 / number;

            //display the result of the operation
                label1.Text = $"Result: {result}";
            }
            //catch the exception if the input is not a number
            catch (FormatException)
            {
                label1.Text = "Please enter a valid number";
            }

            //catch the exception if the input is zero
            catch (DivideByZeroException)
            {
                label1.Text = "Cannot divide by zero";
            }
        }
        //open Form2
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
