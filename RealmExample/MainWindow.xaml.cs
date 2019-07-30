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
using Realms;
namespace RealmExample
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var realmDB = Realm.GetInstance();

            var empId = realmDB.All<Employee>().Count() + 1;

            var emp = new Employee()
            {
                EmpId= empId,
                EmpName=$"Shashikant {empId}",
                Company="FT"

            };

            realmDB.Write(() =>
            {
                realmDB.Add(emp);
            });

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var realmDB = Realm.GetInstance();
            var employees=realmDB.All<Employee>();
            var departments = realmDB.All<Department>();

            lstEmployees.ItemsSource = employees;
            lstDepartments.ItemsSource = departments;

        }

    }
}
