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

namespace ModelViewWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities db = new NorthwindEntities();
        public static DataGrid datag;
        int id;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void LoadBTN_Click(object sender, RoutedEventArgs e)
        {
            DataGrid1.ItemsSource = db.Customers.ToList();
            datag = DataGrid1;
            MessageBox.Show("Empresas clientes");
        }
    
}
}
