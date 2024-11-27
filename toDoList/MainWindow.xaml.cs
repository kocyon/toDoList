using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace toDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int currentRow = 1;
        List<Task> tasks = new List<Task>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var taskName = taskText.Text;
            //if (!string.IsNullOrEmpty(taskName))
            //{
            // tasks.Add(new Task { Name = taskName, IsCompleted = false });

            //}
            if (currentRow <= 5)
            {
                CheckBox taskBox = new CheckBox();
                {
                    taskBox.Content = taskName;
                    taskBox.Foreground = Brushes.White;
                    taskBox.Margin = new Thickness(10);
                }
                Grid.SetRow(taskBox, currentRow);
                MainGrid.Children.Add(taskBox);
                currentRow++;
            }
            else MessageBox.Show("Dodałeś za dużo zadań!");
        }
    }
}