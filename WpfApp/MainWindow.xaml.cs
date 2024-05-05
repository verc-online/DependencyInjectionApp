using DiDemoLib;
using Microsoft.Extensions.Configuration;
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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMessages messages, IConfiguration config)
        {
            InitializeComponent();

            helloText.Text = messages.sayHello();
            goodbyeText.Text = messages.sayGoodBye();
            configText.Text = config.GetValue<string>("test");
        }
    }
}