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

namespace SimpleCalculator_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int firstNum, secondNum, total;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstNum = Convert.ToInt32(numA.Text);
                secondNum = Convert.ToInt32(numB.Text);

                total = firstNum + secondNum;

                result.Content = total.ToString();
            }
            catch (FormatException)
            {
                result.Content = "Invalid input";
            }
            catch (Exception ex)
            {
                result.Content = $"Error: {ex.Message}";
            }
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstNum = Convert.ToInt32(numA.Text);
                secondNum = Convert.ToInt32(numB.Text);

                total = firstNum - secondNum;

                result.Content = total.ToString();
            }
            catch (FormatException)
            {
                result.Content = "Invalid input";
            }
            catch (Exception ex)
            {
                result.Content = $"Error: {ex.Message}";
            }
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstNum = Convert.ToInt32(numA.Text);
                secondNum = Convert.ToInt32(numB.Text);

                double total = (double)firstNum * secondNum;

                result.Content = total.ToString("#.##");
            }
            catch (FormatException)
            {
                result.Content = "Invalid input";
            }
            catch (Exception ex)
            {
                result.Content = $"Error: {ex.Message}";
            }
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstNum = Convert.ToInt32(numA.Text);
                secondNum = Convert.ToInt32(numB.Text);

                if (secondNum == 0)
                {
                    result.Content = "Cannot divide by zero";
                }
                else
                {
                    double total = (double)firstNum / secondNum;
                    result.Content = total.ToString("#.##");
                }
            }
            catch (FormatException)
            {
                result.Content = "Invalid input";
            }
            catch (Exception ex)
            {
                result.Content = $"Error: {ex.Message}";
            }
        }
    }
}