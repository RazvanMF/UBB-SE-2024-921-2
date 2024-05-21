using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Path = System.IO.Path;
using System.Diagnostics;

namespace Entrypoint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void COC_Button_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\..\application-namespacegpt\NamespaceGPT.WPF\bin\Debug\net8.0-windows\NamespaceGPT.WPF.exe"));
            Process.Start(newPath);
            this.Close();
        }

        private void Spartacus_Button_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\..\UBB-SE-2024-Spartacus2\UBB-SE-2024-Spartacus2\bin\Debug\net8.0-windows\Bussiness-social-media.exe"));
            Process.Start(newPath);
            this.Close();
        }
    }
}