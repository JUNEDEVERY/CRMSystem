using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CRMSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employees employees1;
        public MainWindow()
        {
            InitializeComponent();
            DB.tbe = new Entities();
            btnEntry.Visibility = Visibility.Collapsed;
            stackPassword.Visibility = Visibility.Collapsed;


        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {


        }

        private void btnEntry_Click(object sender, RoutedEventArgs e)
        {
            // List<Employees> list = new List<Employees>();


            //List<Employees> employees = DB.tbe.Employees.ToList();
            //if (employees. == tbNumber.Text)
            ////{
            //    tbCode.Visibility = Visibility.Visible;

            //}
            //else
            //{
            //    MessageBox.Show("нет");
            //}
        }

        private void tbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                List<Employees> list1 = DB.tbe.Employees.Where(x => x.Number == tbNumber.Text).ToList();

                if (!string.IsNullOrEmpty(tbNumber.Text))
                {
                    if (list1.Count == 1)
                    {
                        MessageBox.Show("Номер в базе данных существует");
                        btnEntry.Visibility = Visibility.Visible;
                        stackPassword.Visibility = Visibility.Visible;
                        tbPassword.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Номер отсутствует в базе данных");
                    }
                }
                else
                {
                    MessageBox.Show("Поле номера не заполнено!");
                }

            }
        }
        private void checkedPassword()
        {
            if (Regex.IsMatch(tbPassword.Text, @"(?=.[0-9]){1,}"))
            {

            }
            else
            {
                MessageBox.Show("В пароле должна быть хотя бы одна цифра");
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(Key.Enter == e.Key)
            {
                if (!string.IsNullOrEmpty(tbPassword.Text))
                {

                }
            }
        }
    }
}
