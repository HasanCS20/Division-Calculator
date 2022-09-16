using System;
using System.Windows.Forms;

namespace Assign1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //At catching part the program cannot recognize if is there an error by using "double", so i make it with int and double
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            double num3 = Convert.ToDouble(textBox1.Text);
            double num4 = Convert.ToDouble(textBox2.Text);

            //Insilaizing 
            double result = 0;
            double trying = 0;

            //While error the program will excuted two MessageBox, showing the error state and the "finally" MessageBox
            Boolean check = true;

            try
            {
                result = num1 / num2;
                trying = num3 / num4;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                check = false;
            }
            finally
            {
                if (check == true)
                {
                    MessageBox.Show("The Result Is: " + Convert.ToString(trying));
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
