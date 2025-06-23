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
using System.Windows.Shapes;

namespace todoo
{
    /// <summary>
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class main : Window
    {
        public main()
        {
            InitializeComponent();
        }

        private void TaskFirst_Checked(object sender, RoutedEventArgs e)
        {
            TextCap.Content = "Описание для задачи 1";
        }

        private void TaskSecond_Checked(object sender, RoutedEventArgs e)
        {
            TextCap.Content = "Описание для задачи 2";
        }

        private void TaskThird_Checked(object sender, RoutedEventArgs e)
        {
            TextCap.Content = "Описание для задачи 3";
        }

        private void TaskFourth_Checked(object sender, RoutedEventArgs e)
        {
            TextCap.Content = "Описание для задачи 4";
        }

        private void TaskFifth_Checked(object sender, RoutedEventArgs e)
        {
            TextCap.Content = "Описание для задачи 5";
        }


        private void Done_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        { 
  
            
        }

    }
}
