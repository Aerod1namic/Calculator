using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string buff;
        State CurrentState;
        string memory = "";
        string memory2 = "";
        enum State
        {
            substraction,
            addiction,
            multiplication,
            divide,
            nonstate
        }

    public MainWindow()
        {
            InitializeComponent();
        }

        private void _0Click(object sender, RoutedEventArgs e)
        {
            text.Text += "0";
            text.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                text.Text = (double.Parse(text.Text) * (-1)).ToString();
            }
            catch (Exception) { }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text.Text += ",";
            text.Focus();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CurrentState = State.addiction;
            buff = text.Text;
            text.Text = "";
            text.Focus();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CurrentState == State.divide)
                {
                    CurrentState = State.nonstate;
                    double buff2 = double.Parse(text.Text);
                    text.Text = (double.Parse(buff) / buff2).ToString();
                }

                if (CurrentState == State.multiplication)
                {
                    CurrentState = State.nonstate;
                    double buff2 = double.Parse(text.Text);
                    text.Text = (double.Parse(buff) * buff2).ToString();
                }

                if (CurrentState == State.substraction)
                {
                    CurrentState = State.nonstate;
                    double buff2 = double.Parse(text.Text);
                    text.Text = (double.Parse(buff) - buff2).ToString();
                }

                if (CurrentState == State.addiction)
                {
                    CurrentState = State.nonstate;
                    double buff2 = double.Parse(text.Text);
                    text.Text = (double.Parse(buff) + buff2).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невернный ввод данных");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            text.Text += "1";
            text.Focus();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            text.Text += "2";
            text.Focus();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            text.Text += "3";
            text.Focus();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            CurrentState = State.substraction;
            buff = text.Text;
            text.Text = "";
            text.Focus();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                text.Text = (Math.Pow(double.Parse(text.Text), 2)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Попытайтесь ввести корректные данные для\n данной операции данные и повторите", "Калькулятор",
                    MessageBoxButton.OK,MessageBoxImage.Warning);
                
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            text.Text += "4";
            text.Focus();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            text.Text += "5";
            text.Focus();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            text.Text += "6";
            text.Focus();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            CurrentState = State.multiplication;
            buff = text.Text;
            text.Text = "";
            text.Focus();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            try
            {
                text.Text = (1 / double.Parse(text.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            text.Text += "7";
            text.Focus();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            text.Text += "8";
            text.Focus();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            text.Text += "9";
            text.Focus();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            CurrentState = State.divide;
            buff = text.Text;
            text.Text = "";
            text.Focus();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            try
            {
                if (text.Text.Length > 0)
                {
                    text.Text = (Math.Sqrt(double.Parse(text.Text))).ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            try
            {
                text.Text = text.Text.Substring(0, text.Text.Length - 1);
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            text.Clear();
            CurrentState = State.nonstate;
            buff = "";
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            text.Clear();
        }

        private void MemoryClearButton_Click(object sender, RoutedEventArgs e)
        { 
            MemoryButtonClear.IsEnabled = false;
            button11.IsEnabled = false;
            memory = "";
            label1.Content = "";
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            text.Text = memory;
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            try
            {
                if (text.Text.Length > 0)
                {
                    MemoryButtonClear.IsEnabled = true;
                    button11.IsEnabled = true;
                    memory = text.Text;
                    label1.Content = "M";
                }
                else
                {
                    MessageBox.Show("Попытайтесь ввести корректные данные для \n данной операции и повторите","Калькулятор",
                        MessageBoxButton.OK, MessageBoxImage.Warning );
                }
            }
            catch (Exception)
            {

            }
        }

        private void Text_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
                if ((e.Key < Key.D0 || e.Key > Key.D9) && e.Key != Key.Back)
                {
                    e.Handled = true;
                }
        }
    }
}
