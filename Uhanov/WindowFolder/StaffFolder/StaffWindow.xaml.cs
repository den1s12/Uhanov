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
using Uhanov.ClassFolder;

namespace Uhanov.WindowFolder.StaffFolder
{
    /// <summary>
    /// Логика взаимодействия для StaffWindow.xaml
    /// </summary>
    public partial class StaffWindow : Window
    {
        public StaffWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new PageFolder.StaffPageFolder.ListReaderPage());
        }

        private void ListReader_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageFolder.StaffPageFolder.ListReaderPage());
        }

        private void AddReader_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageFolder.StaffPageFolder.AddReaderPage());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MBClass.ExitMB();
        }
    }
}
