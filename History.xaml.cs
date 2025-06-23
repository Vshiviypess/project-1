using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using todoo;

namespace todoo
{
    /// <summary>
    /// Логика взаимодействия для History.xaml
    /// </summary>
    public partial class History : Window
    {

        public History(ObservableCollection<todoo.Tasks.Task> completedTasks)
        {
            InitializeComponent();
            HistoryListBox.ItemsSource = completedTasks;
        }

        private void HistoryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
