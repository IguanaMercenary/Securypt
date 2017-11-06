<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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

        private string RSAPublicKey;
        private string RSAPrivateKey;
        private string AESSecretKey;

        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new LocalPage());
        }

        /// <summary>
        /// Generates random number suitable for key input
        /// </summary>
        private void genRndNumber()
        {

        }

        /// <summary>
        /// Generates RSA public and private key pair and saves them as .key files in 
        /// default location
        /// </summary>
        private void generateKeys()
        {

        }

        /// <summary>
        /// Initializes the program by checking for or generating RSA keys, etc
        /// </summary>
        private void initProgram()
        {
            //if (RSA keys NOT found in default location)
            //		generateRSAKeys()
            //else return
        }

        /// <summary>
        /// Checks the current files for size and compresses them into 1 archive
        /// </summary>
        private void archiveFiles()
        {
            //check if file is already archived
            //if not, open archive file
            //add files to archive and close file
        }

        /// <summary>
        /// Encrypts the current archive with the current AES key
        /// </summary>
        private void encryptArchive()
        {

        }

        /// <summary>
        /// Decrypts the current archive with the current AES key
        /// </summary>
        private void decryptArchive()
        {

        }

        /// <summary>
        /// Encrypts the current AES key using the current RSA Public key
        /// </summary>
        private void encryptAESKey()
        {

        }

        /// <summary>
        /// Decrypts the current AES key using the current RSA Public key
        /// </summary>
        private void decryptAESKey()
        {

        }

        public void testEncrypt()
        {

            string inputPath = @"c:\TestInputText\";
            string outputPath = @"c:\TestEncryptedText\";

            using (FileStream fileStream = new FileStream(inputPath, FileMode.Open))
            {

            }                        
		}

        public void testDecrypt()
        {

        }

        private void generateRSASalt()
        {
            
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
>>>>>>> b2824f01adee20c126fc1eb04829afdb778c79c8
//this.NavigationService.Navigate(new CustomerDetailsPage(selectedCustomer));