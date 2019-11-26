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
using SFKASl;

namespace ClientApp
{
    /// <summary>
    /// Логика взаимодействия для SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        ParkingManager _pm;
        public SignInWindow(ParkingManager pm)
        {
            InitializeComponent();
            _pm = pm;
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            var login = SignInLoginBox.Text;
            var password = SignInPasswordBox.Password;
            var user = _pm.CheckingPassword(login, password);
            if (user is null)
                MessageBox.Show("Incorrect login or password");
            else
            {
                var appWin = new AppWindow();
                Hide();
                appWin.Show();
                Close();
            }
        }
    }
}
