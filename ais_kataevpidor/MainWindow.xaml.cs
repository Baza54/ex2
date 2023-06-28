using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ais_kataevpidor
{
    public partial class MainWindow : Page
    {
        private int countUnsuccessful = 0;
        private double minimumWidth = 400; // Минимальная ширина страницы
        private double minimumHeight = 250; // Минимальная высота страницы
        public MainWindow()
        {
            InitializeComponent();
            
            GenerateCapthca();
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (Width < minimumWidth)
                Width = minimumWidth;

            if (Height < minimumHeight)
                Height = minimumHeight;
        }

        private void GenerateCapthca()
        {
            Random rnd = new Random();
            string ucode = string.Empty;
            char[] ch4r = "abcdefghijklmnopqrstuvwxyzABCDEFGHUJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            for (int i = 0; i < 5; i++)
            {
                ucode += ch4r[rnd.Next(ch4r.Length)];
            }
            lbl_captcha.Content = ucode;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_captcha.Content.ToString() == txtCaptcha.Text)
            {
                string login = txtLogin.Text.Trim();
                string password = txtPassword.Password.Trim();
                Employees emp = new Employees();
                Role role = new Role();

                emp = Model1.GetContext().Employees.Where(p => p.Login == login && p.Password == password).FirstOrDefault();
                int userCount = Model1.GetContext().Employees.Where(p => p.Login == login && p.Password == password).Count();
                if (userCount > 0)
                {
                    MessageBox.Show("Вы вошли под: " + emp.LastName.ToString());
                    NavigationService?.Navigate(new Admin(emp));
                }
                else
                {
                    countUnsuccessful++;
                    MessageBox.Show("Вы ввели неверный логин или пароль!");
                }
            }
            else
            {
                countUnsuccessful++;
                //lbl_error.Visibility = Visibility;
                //lbl_error.Content = "Неверно введена капча!";
            }

            if (countUnsuccessful == 3)
            {
                MessageBox.Show("Подождите!");
                btnEnter.IsEnabled = false;
                //btnEnterGuest.IsEnabled = false;
                Task.Delay(10000).ContinueWith(_ =>
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        btnEnter.IsEnabled = true;
                        //btnEnterGuest.IsEnabled = true;
                        MessageBox.Show("Продолжайте");
                    });
                });
            }
        }
    }
}
