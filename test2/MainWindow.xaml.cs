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
using System.Net.Http;
namespace test2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly IHttpClientFactory httpClientFactory;

        public MainWindow(IHttpClientFactory httpClientFactory)
        {
            InitializeComponent();

            this.httpClientFactory = httpClientFactory;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = httpClientFactory.CreateClient();
            var response = await client.GetStringAsync
                                 ("https://marcominerva.wordpress.com/feed/");
            daLabel.Content = response;
        }

        
    }

}
