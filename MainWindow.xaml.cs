/*Bradley Miller
 * June 1, 2018
 * This Program helps people with math
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U4_Tutor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnumber = new Random();
        int number_1;
        int number_2;
        int rnumber_Sign;

        string[] MathSign = new string[4];
        int answer;
        string question;

        public MainWindow()
        {
            MathSign[0] = "+";
            MathSign[1] = "-";
            MathSign[2] = "*";
            MathSign[3] = "/";

            InitializeComponent();
 
            GenerateQuestion();

        }

        private void GenerateQuestion()
        {
            number_1 = rnumber.Next(1, 11);
            number_2 = rnumber.Next(1, 11);
            rnumber_Sign = rnumber.Next(0, 4);
            question = number_1.ToString() + " " + MathSign[rnumber_Sign] + " " + number_2.ToString();
            Question.Text = question;
        }

        public void Click_Calc(object Sender, RoutedEventArgs e)
        {
            if (MathSign[rnumber_Sign] == "+")
            {
                answer = number_1 + number_2;
            }
            else if (MathSign[rnumber_Sign] == "-")
            {
                answer = number_1 - number_2;
            }
            else if (MathSign[rnumber_Sign] == "*")
            {
                answer = number_1 * number_2;
            }
            else if (MathSign[rnumber_Sign] == "/")
            {
                answer = number_1 / number_2;
            }

            if (txt_Inpt.Text == answer.ToString())
            {
                MessageBox.Show("Correct! ");
                GenerateQuestion();
            }
            else if (txt_Inpt.Text != answer.ToString())
            {
                MessageBox.Show("Incorrect.");
            }
        }
    }
}