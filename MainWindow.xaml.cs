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
using System.IO;
using UserRepos;
using System.Xml.Linq;
using System.Windows.Media.Animation;


namespace todoo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public  MainWindow()
        {
            InitializeComponent();

            AppConnect.todoModel = new todoEntities2();

        }

        private UserManager userManager = new UserManager();

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            string path = @"C:\Users\Public\Documents\Users.txt";

            if (File.Exists(path))
            {
                foreach (string line in File.ReadAllLines(path))
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        string name = parts[0].Trim();
                        string mail = parts[1].Trim();
                        string password = parts[2].Trim();

                        if (mail == mailBox.Text && password == passBox.Text)
                        {
                            Window2 nextWin = new Window2();
                            nextWin.Show();
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Ошибка при вводе");
                        }
                    }
                    else
                    {
                        
                    }
                }

            }
            
            try
            {
                var userOBject = AppConnect.todoModel.Database;
            }
            catch
            {

            }

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Window1 wd = new Window1();
            wd.Show();
            this.Close();

        }
    }

}

