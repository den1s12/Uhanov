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

namespace Uhanov.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new PageFolder.UserListPage());
        }

        private void ListUser_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageFolder.UserListPage());
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageFolder.AddUserPage());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MBClass.ExitMB();
        }
    }
}
