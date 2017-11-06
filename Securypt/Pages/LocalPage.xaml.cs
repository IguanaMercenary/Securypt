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
using Microsoft.Win32; //for OpenFileDialog
using Securypt.Utility;

namespace Securypt
{
    /// <summary>
    /// Interaction logic for LocalPage.xaml
    /// </summary>
    public partial class LocalPage : Page
    {
        CryptoHandler crypto;

        public LocalPage(CryptoHandler crypto)
        {
            this.crypto = crypto;
            InitializeComponent();
        }

        private void ServerPage_Click(object sender, RoutedEventArgs e)
        {
            //since MainFrame isn't visible use NavigationService (also possible to use NavigationCommand in XAML)
            this.NavigationService.Navigate(new ServerPage());
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            crypto.EncryptFile(CryptoHandler.EncrFolder);
        }

        private void Decrypt_Click(object sender, RoutedEventArgs e)
        {
            crypto.DecryptFile(CryptoHandler.DecrFolder);
        }
    }
}
