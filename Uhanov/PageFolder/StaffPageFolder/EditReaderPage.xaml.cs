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
using Uhanov.ClassFolder;
using Uhanov.DataFolder;

namespace Uhanov.PageFolder.StaffPageFolder
{
    /// <summary>
    /// Логика взаимодействия для EditReaderPage.xaml
    /// </summary>
    public partial class EditReaderPage : Page
    {
        public EditReaderPage(Reader reader)
        {
            InitializeComponent();
            DataContext = reader;
        }

        private void EditUserBtn_Click(object sender, RoutedEventArgs e)
        {
            Reader reader = DBEntities.GetContext().Reader.
             FirstOrDefault(s => s.IdReader == VariableClass.ReaderId);
            reader.UniqueNumberReaderCard = UniqueNumberTb.Text;
            reader.LastNameReader = LastNameTb.Text;
            reader.FirstNameReader = FirstNameTb.Text;
            reader.MiddleNameReader = MiddleNameTb.Text;
            reader.NumberPhoneReader = NumberPhoneTb.Text;
            reader.HomePhoneReader = HomeNumberPhoneTb.Text;
            reader.DateOfBirthReader = DateTime.Parse(DateOfBirthDP.Text);

           


            DBEntities.GetContext().SaveChanges();
            MBClass.InfoMB("Пользователь успешно отредактирован");
            NavigationService.Navigate(new ListReaderPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Reader reader = DBEntities.GetContext().Reader.FirstOrDefault
            //    (u=>u.IdReader == VariableClass.ReaderId);

            //Adress adress = DBEntities.GetContext().Adress.FirstOrDefault
            //    (u=>u.IdAdress == VariableClass.AdressId);

            //RegionCB.SelectedValue = adress.Region;
        }
    }
}
