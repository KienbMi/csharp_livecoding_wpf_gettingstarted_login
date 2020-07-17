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

namespace LoginScreen.WpfApp
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      btnLogin.Click += BtnLogin_Click;
    }

    private void BtnLogin_Click(object sender, RoutedEventArgs e)
    {
      bool isValid = true;
      if (string.IsNullOrEmpty(txtUsername.Text))
      {
        isValid = false;
        txtUsernameValidation.Visibility = Visibility.Visible;
      }
      else
      {
        txtUsernameValidation.Visibility = Visibility.Hidden;
      }

      if (string.IsNullOrEmpty(txtPassword.Password) || txtPassword.Password != "P@ssw0rd!")
      {
        isValid = false;
        txtPasswordValidation.Visibility = Visibility.Visible;
      }
      else
      {
        txtPasswordValidation.Visibility = Visibility.Hidden;
      }

      if (isValid)
      {
        MessageBox.Show($"Hello, {txtUsername.Text}!");
        txtUsername.Text = null;
        txtPassword.Password = null;
      }
    }
  }
}
