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
using System.Data.SqlClient;
using System.Data;

namespace BikeStore10
{
    /// <summary>
    /// Interaction logic for bill_1.xaml
    /// </summary>
    public partial class bill_1 : Window
    {

        public bill_1()
        {
            InitializeComponent();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            user_name.Content = TextReference.StoredText.Substring(6);
        }

        public int customer_id = -1;
        public string customer_name = "";
        private void image_close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Saels_1 saels_1_1 = new Saels_1();
            saels_1_1.textbox_customer_id.Text = customer_id.ToString() ;
            saels_1_1.Textbox_enter_customername_saels_order.Text = customer_name;
            saels_1_1.Show();
            saels_1_1.gride_saels_order.Visibility = Visibility.Visible;
            saels_1_1.deleteall();
            saels_1_1.gride_saels_customer.Visibility = Visibility.Hidden;
            this.Close();
        }

        private void griddata_all_saels_order_SizeChanged(object sender, SizeChangedEventArgs e)
        {
          
            this.Height = 203+griddata_all_saels_order.ActualHeight+132;

            rectanglar_1_margin.Margin = new Thickness(rectanglar_1_margin.Margin.Left,203+griddata_all_saels_order.ActualHeight+5,0,0);

            no_item_1_margin.Margin = new Thickness(no_item_1_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 12, 0, 0);
            no_item_2_margin.Margin = new Thickness(no_item_2_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 12, 0, 0);
            sup_total_1_margin.Margin = new Thickness(sup_total_1_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 12, 0, 0);
            sup_total_2_margin.Margin = new Thickness(sup_total_2_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 12, 0, 0);

            no_product_1_margin.Margin = new Thickness(no_product_1_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 42, 0, 0);
            no_product_2_margin.Margin = new Thickness(no_product_2_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 42, 0, 0);
            payment__Method_1_margin.Margin = new Thickness(payment__Method_1_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 42, 0, 0);
            payment__Method_2_margin.Margin = new Thickness(payment__Method_2_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 42, 0, 0);

            rectanglar_2_margin.Margin = new Thickness(rectanglar_2_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 75, 0, 0);

            end_text_margin.Margin = new Thickness(end_text_margin.Margin.Left, 203 + griddata_all_saels_order.ActualHeight + 72, 0, 0);







        }


    }
}
