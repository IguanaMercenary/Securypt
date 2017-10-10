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

namespace Securypt
{
    /// <summary>
    /// Interaction logic for ServerPage.xaml
    /// </summary>
    public partial class ServerPage : Page
    {
        public ServerPage()
        {
            InitializeComponent();

            List<FileItem> listBoxItems = new List<FileItem>();
            listBoxItems.Add(new FileItem("Kevin192752", 11025, "wmJG8wVQZKjeGcjDOL5UlsuusFncCzWBQ7RKNUSesmQR5dnGkVb1/3j+skZ6UtW+5u09lHNsj6tQ51s1SPrCBkedbNf0Tp0GbMJDyR4e9T04ZZwIDAQABAoGAFijko56+qGyN8M0RVyaRAXz++xTqHBLh"));
            listBoxItems.Add(new FileItem("MichaelAccessCode", 5674, "3tx4VgMtrQ+WEgCjhoTwJi43KMBAuJGSYnRmoBZM3lMfTKevIkAidPExvYCdm5dYq3XToLkkLv5LkjIIVOFMDG+KESnAFV7l2c+cnzRMW0+b6f8mR1CJzZuxVLL6Q02fvLi55/mbSYxECQQDeAw6fiIQX"));
            listBoxItems.Add(new FileItem("Downtown2017", 11025, "GukBI4eMd7t4nscy2o12KyYner3VpoeE+Np2q+Z3pvAMd/aNzQ/W9WaI+NRfcx43UJrmfPwIGm63ilAkEAxCL5HQb2bQr4ByorcMWm/hEP2MZzROV73yF41hPsRC9m66KrheO9HPTJuo3/9s5p+sqGxOlF"));
            listBoxItems.Add(new FileItem("BlackEyedPees", 11025, "L0NDt4SkosjgGwJAFklyR1uZ/wPJjj611cdBcztlPfqoxssQGnh85BzCj/u3WqBpE2vjvyyvyI5kX6zk7S0ljKtt2jny2+00VsBerQJBAJGC1Mg5Oydo5NwD6Bi9OrPxGo2bpTbu/fhr;l8ebHkTz2epl"));

            FilesListBox.ItemsSource = listBoxItems;
        }
    }

    public class FileItem
    {
        public FileItem(string Tag, int Size, string PublicKey)
        {
            this.Tag = Tag;
            this.Size = Size;
            this.PublicKey = PublicKey;
        }

        public string Tag { get; set; }
        public int Size { get; set; }
        public string PublicKey { get; set; }

    }
}
