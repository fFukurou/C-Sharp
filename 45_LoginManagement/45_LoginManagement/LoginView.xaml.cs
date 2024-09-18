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

namespace _45_LoginManagement
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string passwordEntered = PasswordBox.Password;

            string? password = "password"; 

            if (password != null)
            {
                if(passwordEntered == password )
                {
                    MessageBox.Show($"Entered Correct Password");
                } else
                {
                    MessageBox.Show($"Entered WRONG Password");
                }
            } else
            {
                MessageBox.Show($"Please enter a password.");
            }
        }

        public void OnPasswordChanged(object sender, EventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty( PasswordBox.Password );
        }
    }
}
