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
using System.Security.Cryptography;
using System.IO;

namespace Securypt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string AESSecretKey;
		private string securyptKeyName = "Securypt";

		public string textToEncrypt = "This text will now be encrypted.";
		public string textDecrypted;

		private CspParameters cspp;
		private RSACryptoServiceProvider rsa;

		public MainWindow()
        {
            InitializeComponent();

            Utility.CryptoHandler crypto = new Utility.CryptoHandler();
            crypto.initProgram();

            MainFrame.Navigate(new LocalPage());
        }
    }
}





//page navigation stuff

//_mainFrame.Navigate(new Page1());
/*
_mainFrame.NavigationService.GoBack(); 
_mainFrame.NavigationService.GoForward(); 
_mainFrame.NavigationService.Refresh();
_mainFrame.NavigationService.Navigate(new Uri("http://www.google.com/"));
_mainFrame.NavigationService.Navigate(new Uri("Page1.xaml", UriKind.Relative));
_mainFrame.NavigationService.Navigate(new Page1());
_mainFrame.NavigationService.Navigate(new Button());
_mainFrame.NavigationService.Navigate("Hello world");
*/

//Customer selectedCustomer = (Customer)listBox.SelectedItem;
//this.NavigationService.Navigate(new CustomerDetailsPage(selectedCustomer));