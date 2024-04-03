using System;
using System.Collections.Generic;
using System.Data;
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
using Practos_4Dataset.DataSet1TableAdapters;

namespace Practos_4Dataset
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        OrdersTableAdapter Orders = new OrdersTableAdapter();
        public Page2()
        {
            InitializeComponent();
            datasetik.ItemsSource = Orders.GetData();
            Combo_datasetik.ItemsSource = Orders.GetData();
            Combo_datasetik.DisplayMemberPath = "OrderDate";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
             datasetik.ItemsSource = Orders.GetDataBy(search.Text);
            
        }

        private void Combo_datasetik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Combo_datasetik.SelectedItem != null)
            {
                var id = (int)(Combo_datasetik.SelectedItem as DataRowView).Row[0];
                datasetik.ItemsSource = Orders.FilterData(id);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            datasetik.ItemsSource = Orders.GetData();
        }
    }
}
