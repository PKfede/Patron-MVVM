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


namespace DBej6MVVM
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

        private void UpdateBTN_Click(object sender, RoutedEventArgs e)
        {
            int categoryId = (DataGrid1.SelectedItem as Categories).CategoryID;
            WinUpdate Upage = new WinUpdate(categoryId);
            Upage.ShowDialog();
        }

        private void LoadBTN_Click(object sender, RoutedEventArgs e)
        {
            DataGrid1.ItemsSource = db.Categories.ToList();
            datag = DataGrid1;
        }
    }
}
