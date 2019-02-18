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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WpfDataBaseBOY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities db = new NorthwindEntities ();
        public  static DataGrid datag;

        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            DataGrid1.ItemsSource = db.Categories.ToList();
            datag = DataGrid1;
        }

        private void UpdateBTN_Click(object sender, RoutedEventArgs e)
        {
            int categoryId = (DataGrid1.SelectedItem as Categories).CategoryID;
            WindowUpdate Upage = new WindowUpdate(categoryId);
            Upage.ShowDialog();
        }
        

    }
}
