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
using SFKASl.Models;

namespace ClientApp
{
    /// <summary>
    /// Логика взаимодействия для SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        ParkingManager _pm;
        public SignUpWindow(ParkingManager pm)
        {
            InitializeComponent();
            _pm = pm;

        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            var name = SignUpNameBox.Text;
            var phoneNum = SignUpPhoneBox.Text.Replace(" ", "");
            var carPlateNum = SignUpCarPlateBox.Text.Replace(" ", "");
            var login = SignUpLoginBox.Text.Replace(" ", "");
            var password = SignUpPasswordBox.Password;
            if (name == "" || phoneNum == "" || carPlateNum == "" || login == "" || password == "")
            {
                MessageBox.Show("Fill in all the properties, please");
            }
            else
            {
                var user = new User();
                user.Name = name;
                user.Phone = phoneNum;
                user.Id = login;
                user.CarPlateNumber = carPlateNum;
                user.Password = password;
                if (_pm.FindUniqueData(user))
                    _pm.EnterUser(user);
                else
                    MessageBox.Show("You are already registered");
            }
        }
    }
}
