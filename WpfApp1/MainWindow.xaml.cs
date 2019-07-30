using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
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

        private async void login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              var result=  await LoginAsync();
                login.Content = result;


            }
            catch (Exception ex)
            {
                login.Content = "Login failed";
            }
        }

        private async Task<string> LoginAsync()
        {
            //throw new UnauthorizedAccessException();

            var loginTask=  Task.Run(() =>
            {
                
                Thread.Sleep(2000);
                return "Login Success";
            });

            var logTask = Task.Delay(2000);

            var purchaseTask = Task.Delay(1000);

            await Task.WhenAll(loginTask, logTask, purchaseTask);

            return loginTask.Result;
           
        }
    }
}
