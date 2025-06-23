using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using UserRepos;

namespace todoo
{
    /// <summary>
    /// Логика взаимодействия для Tasks.xaml
    /// </summary>
    public partial class Tasks : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Task> Tasks2 { get; set; }
        public ObservableCollection<Task> CompletedTasks { get; set; }
        private Task _selectedTask;

        public Task SelectedTask
        {
            get { return _selectedTask; }
            set
            {
                //Возвращает выбранное значение
                _selectedTask = value;
                OnPropertyChanged(nameof(SelectedTask));
            }
        }
        
        public Tasks()
        {
            InitializeComponent();
            //Заполнение коллекции 
            Tasks2 = new ObservableCollection<Task>
            {
                new Task { Name = "Задача 1", Description = "Описание первой задачи", Date = DateTime.Now },
                new Task { Name = "Задача 2", Description = "Описание второй задачи", Date = DateTime.Now.AddDays(1) },
                new Task { Name = "Задача 3", Description = "Описание третьей задачи", Date = DateTime.Now.AddDays(2) }
            };
            CompletedTasks = new ObservableCollection<Task>();
            TaskListBox.ItemsSource = Tasks2;
            DataContext = this;
            NameLabel.Content = "";
        }

        private void TaskListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TaskListBox.SelectedItem is Task selectedTask)
            {
                SelectedTask = selectedTask;
            }
        }

        private void CompleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedTask != null)
            {
                //Изменение свойства
                SelectedTask.IsCompleted = true;
                //Перемещение в комплит
                CompletedTasks.Add(SelectedTask);
                //Удаление
                Tasks2.Remove(SelectedTask);
                SelectedTask = null;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedTask != null)
            {
                //Удаление
                Tasks2.Remove(SelectedTask);
                SelectedTask = null;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //событие изменения значения
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public class Task : INotifyPropertyChanged
        {
            private bool _isCompleted;

            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }

            public bool IsCompleted
            {
                get { return _isCompleted; }
                set
                {
                    _isCompleted = value;
                    OnPropertyChanged(nameof(IsCompleted));
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            //Вызываем метод в случае его изменения 
            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //Закидывание в историю
        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            var historyWindow = new History(CompletedTasks);
            historyWindow.Show();
        }
       
    }
}
