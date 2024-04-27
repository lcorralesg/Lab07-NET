using Entity;
using Business;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ProductBusiness productBusiness = new ProductBusiness();
            var products = productBusiness.Get();
            dgProducts.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductBusiness productBusiness = new ProductBusiness();
            var products = productBusiness.GetbyName(txtBuscar.Text);
            dgProducts.ItemsSource = products;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
        }
    }
}