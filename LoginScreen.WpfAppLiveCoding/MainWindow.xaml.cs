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

namespace LoginScreen.WpfAppLiveCoding
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
      valUsername.Visibility = txtUsername.Text == "jfuerlinger" ? Visibility.Hidden : Visibility.Visible;

      if(txtUsername.Text == "jfuerlinger")
      {
        SuccessWindow wndSuccess = new SuccessWindow();
        wndSuccess.Show();
        this.Close();
      }
    }
  }
}
