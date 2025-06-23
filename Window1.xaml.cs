using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserRepos;


namespace todoo
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private UserManager userManager = new UserManager();

        public Window1()
        {
            InitializeComponent();

            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = Welcome.ActualWidth;
            widthAnimation.To = 500;
            widthAnimation.Duration = TimeSpan.FromSeconds(5);
            Welcome.BeginAnimation(TextBlock.WidthProperty, widthAnimation);

            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.From = Welcome.ActualHeight;
            heightAnimation.To = 500;
            heightAnimation.Duration = TimeSpan.FromSeconds(5);

            Welcome.BeginAnimation(TextBlock.WidthProperty, widthAnimation);
            Welcome.BeginAnimation(TextBlock.HeightProperty, heightAnimation);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }



        private void Reg_Click(object sender, RoutedEventArgs e)
        {


        }

        static bool IsValidEmail(string email)
        {

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);

        }

        private void Reg_Click_1(object sender, RoutedEventArgs e)
        {
            bool chrckname = false;
            string username = nameBox.Text;
            if (username.Length >= 3) 
            {
                chrckname = true;
            }
            //
            bool chrckmail = false;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string mail = mailBox.Text;
            if (Regex.IsMatch(mail, pattern) == true)
            {
                chrckmail = true;
            }
            //
            bool chrckpass = false;
            string password = passBox.Text;
            if (password.Length >= 6)
            {
                chrckpass = true;
            }
            //
            if (chrckname == true && chrckmail == true && chrckpass == true)
            {

                try
                {
                    userManager.RegisterUser(username, mail, password);
                    MessageBox.Show("Регистрация прошла успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void spassBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
