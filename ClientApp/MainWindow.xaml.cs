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
using SFKASl;

namespace ClientApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ParkingManager _pm;
        public MainWindow()
        {
            InitializeComponent();
            _pm = new ParkingManager();
        }

        private void Sign_In_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var SignInWin = new SignInWindow(_pm);
            SignInWin.Show();
            Close();

        }

        private void Sign_Up_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var SignUpWin = new SignUpWindow(_pm);
            SignUpWin.Show();
            Close();
        }
    }
}
