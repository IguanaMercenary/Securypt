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

        public void Border(Border b) {
            InitializeComponent();
        }

        /// <summary>
        /// Adds drag and drop functionality to the border area of the page.
        /// Author: Michael
        /// Date: 2017-11-08
        /// Based on: https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/walkthrough-enabling-drag-and-drop-on-a-user-control
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed) {
                // Package the data.
                DataObject data = new DataObject();
                data.SetData("Double", MyBorderedButton.Height);
                data.SetData("Object", this);

                // Inititate the drag-and-drop operation.
                DragDrop.DoDragDrop(this, data, DragDropEffects.Copy | DragDropEffects.Move);
            }


        }

        /// <summary>
        /// 
        /// Source: https://stackoverflow.com/questions/5662509/drag-and-drop-files-into-wpf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BorderPanel_Drop(object sender, DragEventArgs e) {

            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                MyBorderedButton.TextInput

                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
                
            }
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs e) {
            base.OnGiveFeedback(e);
            // These Effects values are set in the drop target's
            // DragOver event handler.
            if (e.Effects.HasFlag(DragDropEffects.Copy)) {
                Mouse.SetCursor(Cursors.Cross);
            } else if (e.Effects.HasFlag(DragDropEffects.Move)) {
                Mouse.SetCursor(Cursors.Pen);
            } else {
                Mouse.SetCursor(Cursors.No);
            }
            e.Handled = true;
        }
    }
}
