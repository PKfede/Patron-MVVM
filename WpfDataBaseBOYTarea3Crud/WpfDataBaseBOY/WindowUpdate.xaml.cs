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
using System.Windows.Shapes;

namespace WpfDataBaseBOY
{
    /// <summary>
    /// Interaction logic for WindowUpdate.xaml
    /// </summary>
    public partial class WindowUpdate : Window
    {
        NorthwindEntities db = new NorthwindEntities();
        int id;

        public WindowUpdate(int CategoryID)
        {
            InitializeComponent();
            id = CategoryID;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Categories updateCat = (from m in db.Categories where m.CategoryID == id select m).Single();
            updateCat.CategoryName = CatNameText.Text;
            updateCat.Description = DescText.Text;
            db.SaveChanges();
            MainWindow.datag.ItemsSource = db.Categories.ToList();
            this.Hide();

        }
    }
}
