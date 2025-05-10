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
using ScottPlot;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;


namespace BikeStore10
{
   
    public partial class homebage_1 : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_44330760199;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_2;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter adb = new SqlDataAdapter();
        DataTable tab = new DataTable();
        DataTable tab_1 = new DataTable();



        public homebage_1()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                command.Connection = conn;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            conn.Close();
        }

        private void Window_PreviewKeyDown_1(object sender, KeyEventArgs e)
        {
            InputLanguageManager.Current.CurrentInputLanguage = CultureInfo.GetCultureInfo("en-US");

        }


        //--------------------------------------------------Fixed------------------------------------------------




        //---------------------------------------Programe Buttons-------------------------------------

        //--------------button the Main-----------------
        private void Menu_all_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (gridlistbig_1.Visibility == Visibility.Visible)
            {
                gridlistbig_1.Visibility = Visibility.Hidden;
            }
            else if (gridlistbig_1.Visibility == Visibility.Hidden)
            {
                gridlistbig_1.Visibility = Visibility.Visible;
            }

        }

        private void image_garas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (gride_notification.Visibility == Visibility.Hidden)
            {
                gride_notification.Visibility = Visibility.Visible;
               
            }
            else if (gride_notification.Visibility == Visibility.Visible)
            {
                gride_notification.Visibility = Visibility.Hidden;
               
            }


        }

        private void image_user_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (gride_user_1.Visibility == Visibility.Hidden)
            {
                gride_user_1.Visibility = Visibility.Visible;

            }
            else if (gride_user_1.Visibility == Visibility.Visible)
            {
                gride_user_1.Visibility = Visibility.Hidden;

            }
        }

        private void image_more_product_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grid_more_product_inventory.Visibility = Visibility.Visible;
            image_less_product.Visibility = Visibility.Visible;
            image_more_product.Visibility = Visibility.Hidden;
        }

        private void image_more_reports_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grid_more_reportsandstaticas.Visibility = Visibility.Visible;
            image_less_reports.Visibility = Visibility.Visible;
            image_more_reports.Visibility = Visibility.Hidden;
        }

        private void image_less_product_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grid_more_product_inventory.Visibility = Visibility.Hidden;
            image_less_product.Visibility = Visibility.Hidden;
            image_more_product.Visibility = Visibility.Visible;

        }

        private void image_less_reports_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grid_more_reportsandstaticas.Visibility = Visibility.Hidden;
            image_less_reports.Visibility = Visibility.Hidden;
            image_more_reports.Visibility = Visibility.Visible;

        }



        private void Lable_inmenu_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Image_menu_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Lable_inmenu_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Saels_1 saels_1_1 = new Saels_1();
            saels_1_1.Show();
            this.Close();
        }

        private void image_menu_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Saels_1 saels_1_1 = new Saels_1();
            saels_1_1.Show();
            this.Close();
        }

        private void Lable_menu_3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Products_1 products_1_1 = new Products_1();
            products_1_1.Show();
            this.Close();
        }

        private void image_menu_3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Products_1 products_1_1 = new Products_1();
            products_1_1.Show();
            this.Close();
        }

        private void Lable_menu_4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Customer_1 customer_1_1 = new Customer_1();
            customer_1_1.Show();
            this.Close();
        }

        private void image_menu_4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Customer_1 customer_1_1 = new Customer_1();
            customer_1_1.Show();
            this.Close();
        }

        private void Lable_menu_5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rebort_1 rebort_1_1 = new Rebort_1();
            rebort_1_1.Show();
            this.Close();
        }

        private void image_menu_5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rebort_1 rebort_1_1 = new Rebort_1();
            rebort_1_1.Show();
            this.Close();
        }

        private void lable_menu_6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            User_1 user_1_1 = new User_1();
            user_1_1.Show();
            this.Close();
        }

        private void image_menu_6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            User_1 user_1_1 = new User_1();
            user_1_1.Show();
            this.Close();
        }

        private void lable_signout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow_1_1 = new MainWindow();
            mainWindow_1_1.Show();
            this.Close();
        }

        private void image_signout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow_1_1 = new MainWindow();
            mainWindow_1_1.Show();
            this.Close();

        }

        private void lable_updateuser_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            User_1 user_1_1 = new User_1();
            user_1_1.Show();
            this.Close();
        }

        private void image_updateuser_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            User_1 user_1_1 = new User_1();
            user_1_1.Show();
            this.Close();
        }

        private void lable_moreproduct_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Products_1 products_1_1 = new Products_1();
            products_1_1.Show();
            products_1_1.gride_product.Visibility = Visibility.Visible;
            products_1_1.label_open_product.Background = null;
            products_1_1.border_open_product.Background = null;
            this.Close();

        }

        private void lable_moreproduct_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Products_1 products_1_1 = new Products_1();
            products_1_1.Show();
            products_1_1.gride_brand.Visibility = Visibility.Visible;
            products_1_1.label_open_brand.Background = null;
            products_1_1.border_open_brand.Background = null;
            this.Close();
        }

        private void lable_moreproduct_3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Products_1 products_1_1 = new Products_1();
            products_1_1.Show();
            products_1_1.gride_category.Visibility = Visibility.Visible;
            products_1_1.label_open_category.Background = null;
            products_1_1.border_open_category.Background = null;
            this.Close();
        }

        private void lable_moreproduct_4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Products_1 products_1_1 = new Products_1();
            products_1_1.Show();
            products_1_1.gride_stock.Visibility = Visibility.Visible;
            products_1_1.label_open_stock.Background = null;
            products_1_1.border_open_stock.Background = null;
            this.Close();
        }

        private void Lable_morereport_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rebort_1 rebort_1_1 = new Rebort_1();
            rebort_1_1.Show();
            rebort_1_1.scroll_product.Visibility = Visibility.Visible;
            rebort_1_1.gride_product.Visibility = Visibility.Visible;
            rebort_1_1.label_open_product.Background = null;
            rebort_1_1.border_open_product.Background = null;
            this.Close();
        }

        private void Lable_morereport_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rebort_1 rebort_1_1 = new Rebort_1();
            rebort_1_1.Show();
            rebort_1_1.gride_brand.Visibility = Visibility.Visible;
            rebort_1_1.scroll_brand.Visibility = Visibility.Visible;
            rebort_1_1.label_open_brand.Background = null;
            rebort_1_1.border_open_brand.Background = null;
            this.Close();
        }

        private void Lable_morereport_4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rebort_1 rebort_1_1 = new Rebort_1();
            rebort_1_1.Show();
            rebort_1_1.gride_category.Visibility = Visibility.Visible;
            rebort_1_1.scroll_category.Visibility = Visibility.Visible;
            rebort_1_1.label_open_category.Background = null;
            rebort_1_1.border_open_category.Background = null;
            this.Close();
        }

        //---------------------------------------Efect The Button-------------------------------------

        //-----------Efect the top menu----------------
        private void image_user_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            image_user.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void image_user_MouseLeave(object sender, MouseEventArgs e)
        {
            image_user.Effect = null;
        }

        private void image_garas_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            image_garas.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void image_garas_MouseLeave(object sender, MouseEventArgs e)
        {
            image_garas.Effect = null;
        }

        private void Menu_all_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Menu_all.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void Menu_all_MouseLeave(object sender, MouseEventArgs e)
        {
            Menu_all.Effect = null;
        }

                    //-----------Efect the lable in menu left----------------
        private void Lable_inmenu_1_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            Image_menu_1.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_inmenu_1.Effect = effectb;
            effectb.Radius = 3;
        }

        private void Lable_inmenu_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_menu_1.Effect = null;
            Lable_inmenu_1.Effect = null;
        }

        private void Lable_inmenu_2_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_2.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_inmenu_2.Effect = effectb;
            effectb.Radius = 3;
        }

        private void Lable_inmenu_2_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_2.Effect = null;
            Lable_inmenu_2.Effect = null;

        }

        private void Lable_menu_3_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_3.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_menu_3.Effect = effectb;
            effectb.Radius = 3;
        }

        private void Lable_menu_3_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_3.Effect = null;
            Lable_menu_3.Effect = null;

        }

        private void Lable_menu_4_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_4.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_menu_4.Effect = effectb;
            effectb.Radius = 3;
        }

        private void Lable_menu_4_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_4.Effect = null;
            Lable_menu_4.Effect = null;
        }

        private void Lable_menu_5_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_5.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_menu_5.Effect = effectb;
            effectb.Radius = 3;
        }

        private void Lable_menu_5_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_5.Effect = null;
            Lable_menu_5.Effect = null;
        }

        private void lable_menu_6_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_6.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_menu_6.Effect = effectb;
            effectb.Radius = 3;
        }

        private void lable_menu_6_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_6.Effect = null;
            lable_menu_6.Effect = null;
        }

                        //-----------Efect the image in menu left----------------
        private void Image_menu_1_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            Image_menu_1.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_inmenu_1.Effect = effectb;
            effectb.Radius = 3;

        }

        private void Image_menu_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Image_menu_1.Effect = null;
            Lable_inmenu_1.Effect = null;
        }

        private void image_menu_2_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_2.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_inmenu_2.Effect = effectb;
            effectb.Radius = 3;
        }

        private void image_menu_2_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_2.Effect = null;
            Lable_inmenu_2.Effect = null;
        }

        private void image_menu_3_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_3.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_menu_3.Effect = effectb;
            effectb.Radius = 3;
        }

        private void image_menu_3_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_3.Effect = null;
            Lable_menu_3.Effect = null;
        }

        private void image_menu_4_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_4.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_menu_4.Effect = effectb;
            effectb.Radius = 3;
        }

        private void image_menu_4_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_4.Effect = null;
            Lable_menu_4.Effect = null;
        }

        private void image_menu_5_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_5.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_menu_5.Effect = effectb;
            effectb.Radius = 3;
        }

        private void image_menu_5_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_5.Effect = null;
            Lable_menu_5.Effect = null;
        }

        private void image_menu_6_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_menu_6.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_menu_6.Effect = effectb;
            effectb.Radius = 3;
        }

        private void image_menu_6_MouseLeave(object sender, MouseEventArgs e)
        {
            image_menu_6.Effect = null;
            lable_menu_6.Effect = null;
        }

                      //-----------Efect the lable in lable more----------------
        private void lable_moreproduct_1_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_moreproduct_1.Effect = effectb;
            effectb.Radius = 3;
        }

        private void lable_moreproduct_1_MouseLeave(object sender, MouseEventArgs e)
        {
            lable_moreproduct_1.Effect = null;

        }

        private void lable_moreproduct_2_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_moreproduct_2.Effect = effectb;
            effectb.Radius = 3;
        }

        private void lable_moreproduct_2_MouseLeave(object sender, MouseEventArgs e)
        {
            lable_moreproduct_2.Effect = null;

        }

        private void lable_moreproduct_3_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_moreproduct_3.Effect = effectb;
            effectb.Radius = 3;
        }

        private void lable_moreproduct_3_MouseLeave(object sender, MouseEventArgs e)
        {
            lable_moreproduct_3.Effect = null;

        }

        private void lable_moreproduct_4_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_moreproduct_4.Effect = effectb;
            effectb.Radius = 3;
        }

        private void lable_moreproduct_4_MouseLeave(object sender, MouseEventArgs e)
        {
            lable_moreproduct_4.Effect = null;

        }

        private void Lable_morereport_1_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_morereport_1.Effect = effectb;
            effectb.Radius = 3;
        }

        private void Lable_morereport_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Lable_morereport_1.Effect = null;
        }

        private void Lable_morereport_2_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_morereport_2.Effect = effectb;
            effectb.Radius = 3;
        }

        private void Lable_morereport_2_MouseLeave(object sender, MouseEventArgs e)
        {
            Lable_morereport_2.Effect = null;

        }

        private void Lable_morereport_4_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            Lable_morereport_4.Effect = effectb;
            effectb.Radius = 3;
        }

        private void Lable_morereport_4_MouseLeave(object sender, MouseEventArgs e)
        {
            Lable_morereport_4.Effect = null;

        }

                   //-----------Efect the gride of user image sigin out ant update user----------------
        private void lable_updateuser_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_updateuser.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_updateuser.Effect = effectb;
            effectb.Radius = 3;
        }

        private void lable_updateuser_MouseLeave(object sender, MouseEventArgs e)
        {
            image_updateuser.Effect = null;
            lable_updateuser.Effect = null;
        }

        private void lable_signout_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_signout.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_signout.Effect = effectb;
            effectb.Radius = 3;
        }

        private void lable_signout_MouseLeave(object sender, MouseEventArgs e)
        {
            image_signout.Effect = null;
            lable_signout.Effect = null;
        }

        private void image_updateuser_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_updateuser.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_updateuser.Effect = effectb;
            effectb.Radius = 3;
        }

        private void image_updateuser_MouseLeave(object sender, MouseEventArgs e)
        {
            image_updateuser.Effect = null;
            lable_updateuser.Effect = null;
        }

        private void image_signout_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effects = new System.Windows.Media.Effects.DropShadowEffect();
            image_signout.Effect = effects;
            effects.ShadowDepth = 1;

            System.Windows.Media.Effects.BlurEffect effectb = new System.Windows.Media.Effects.BlurEffect();
            lable_signout.Effect = effectb;
            effectb.Radius = 3;
        }

        private void image_signout_MouseLeave(object sender, MouseEventArgs e)
        {
            image_signout.Effect = null;
            lable_signout.Effect = null;
        }




//-------------------------------------------------Change--------------------------------------------------



        //---------------------------------------Programe Scott Plott and labels value and datagride-------------------------------------

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            text_name_user.Content = TextReference.StoredText;
            image_user.Source = TextReference.StoredBitmapImage;

            try
            {
                //labels value
                command.CommandText = "select COUNT(*) as 'num_customer' from sales.customers";
                reader = command.ExecuteReader();
                reader.Read();
                double num_customer = double.Parse(reader["num_customer"].ToString());
                reader.Close();
                label_numof_customer.Content = num_customer.ToString();

                command.CommandText = "select count(*) as 'num_type_product'from production.products";
                reader = command.ExecuteReader();
                reader.Read();
                double num_type_product = double.Parse(reader["num_type_product"].ToString());
                reader.Close();
                label_numtype_ofproduct.Content = num_type_product.ToString();

                command.CommandText = "select count(*) as 'total_order' from sales.orders";
                reader = command.ExecuteReader();
                reader.Read();
                double total_order = double.Parse(reader["total_order"].ToString());
                reader.Close();
                label_num_totalorders.Content = total_order.ToString();

                command.CommandText = "select sum(products.list_price) / count(*) as 'avg_price' from production.products";
                reader = command.ExecuteReader();
                reader.Read();
                double avg_price = double.Parse(reader["avg_price"].ToString());
                reader.Close();
                label_avg_price.Content = "$" + avg_price.ToString("#####");

                command.CommandText = "select sum(orders.total_mount) as total_saels from sales.orders";
                reader = command.ExecuteReader();
                reader.Read();
                double total_saels = double.Parse(reader["total_saels"].ToString()) / 1000000;
                reader.Close();
                label_total_saels.Content = "$" + total_saels.ToString("#0.##") + "M";









                //scottplot
                int count_4 = 0;
                int rownum_4 = 0;
                command.CommandText = "select DATEPART(YEAR, orders.order_date) as 'year_1' ,sum(orders.total_mount) as 'sum' from sales.orders group by DATEPART(YEAR, orders.order_date)  order by 'year_1' asc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_4++;

                    }
                    reader.Close();
                }
                double[] values = new double[rownum_4];
                string[] labels = new string[rownum_4];
                double[] positions = new double[rownum_4];
                for (int i = 1; i <= rownum_4; i++)
                {
                    positions[i - 1] = i;
                }
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        labels[count_4] = reader["year_1"].ToString();
                        values[count_4] = double.Parse(reader["sum"].ToString()) / 1000;

                        count_4++;
                    }
                    reader.Close();
                }
                command.CommandText = "select top 1 CONVERT(varchar,DATEPART(MONTH,order_date))+'/'+convert(varchar,DATEPART(DAY,order_date))+'/'+convert(varchar,DATEPART(YEAR,order_date)) as 'first_date' from sales.orders order by order_date asc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        labels[0] = reader["first_date"].ToString();

                    }
                    reader.Close();
                }
                command.CommandText = "select top 1 CONVERT(varchar,DATEPART(MONTH,order_date))+'/'+convert(varchar,DATEPART(DAY,order_date))+'/'+convert(varchar,DATEPART(YEAR,order_date)) as 'last_date' from sales.orders order by order_date desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        labels[count_4-1] = reader["last_date"].ToString();

                    }
                    reader.Close();
                }
                wpf_4.Plot.XAxis.ManualTickPositions(positions, labels);
                var charts = wpf_4.Plot.AddScatter(positions, values, color: System.Drawing.Color.Green);
                wpf_4.Plot.XAxis.TickLabelStyle(rotation: 0);
                wpf_4.Plot.Title("Total Saels For Year");
                wpf_4.Plot.XLabel("Year");
                wpf_4.Plot.YLabel("Saels(K)");
                charts.MarkerSize = 5;
                wpf_4.Plot.SetAxisLimitsY(0, values.Max() * 1.2);
                wpf_4.Configuration.LeftClickDragPan = false;
                wpf_4.Configuration.RightClickDragZoom = false;
                wpf_4.Configuration.ScrollWheelZoom = false;
                wpf_4.Plot.Grid(false);
                wpf_4.Refresh();






                int count_3 = 0;
                string[] xaxis = new string[5];
                double[] valuess = new double[5];
                double[] positionsss = { 0, 1, 2, 3, 4 };
                command.CommandText = "select top 4 brand_name , sum(order_items.quantity) as 'num' from production.brands join production.products on brands.brand_id = products.brand_id join sales.order_items on products.product_id = order_items.product_id group by brand_name order by num desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        xaxis[count_3] = reader["brand_name"].ToString();
                        valuess[count_3] = double.Parse(reader["num"].ToString());

                        count_3++;


                    }
                    reader.Close();
                }
                command.CommandText = "select (select sum(order_items.quantity) from sales.order_items ) - (select sum(order_items.quantity) as 'sum_4brand' from sales.order_items join production.products on order_items.product_id =products.product_id join production.brands on products.brand_id = brands.brand_id and  brands.brand_name = any (select top 4 brand_name from production.brands join production.products on brands.brand_id = products.brand_id join sales.order_items on products.product_id = order_items.product_id group by brand_name order by sum(order_items.quantity) desc)) as 'result_sub'";
                reader = command.ExecuteReader();
                reader.Read();
                xaxis[count_3] = "Other";
                valuess[count_3] = double.Parse(reader["result_sub"].ToString());
                reader.Close();

                wpf_3.Plot.XTicks(positionsss, xaxis);
                var chartss = wpf_3.Plot.AddBar(valuess, positionsss, System.Drawing.Color.DarkBlue);
                wpf_3.Plot.SetAxisLimits(yMin: 0);
                chartss.ShowValuesAboveBars = true;
                chartss.Font.Color = System.Drawing.Color.Black;
                wpf_3.Plot.Title("Top Brand");
                wpf_3.Plot.YLabel(" Count Of Products Sold");
                chartss.Font.Size = 8;
                chartss.Font.Bold = true;
                wpf_3.Plot.XAxis.TickLabelStyle(rotation: 0, fontSize: 11);
                wpf_3.Configuration.LeftClickDragPan = false;
                wpf_3.Configuration.RightClickDragZoom = false;
                wpf_3.Configuration.ScrollWheelZoom = false;
                wpf_3.Plot.Grid(false);
                wpf_3.Refresh();






                int count_2 = 0;
                double[] valuesss = new double[5];
                string[] labelsss = new string[5];
                command.CommandText = "select top 4 category_name , sum(order_items.quantity) as 'num' from production.categories join production.products on categories.category_id = products.category_id join sales.order_items on products.product_id = order_items.product_id group by category_name order by num desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        labelsss[count_2] = reader["category_name"].ToString();
                        valuesss[count_2] = double.Parse(reader["num"].ToString());

                        count_2++;

                    }
                    reader.Close();
                }
                command.CommandText = "WITH sum_num AS (select top 4 category_name , sum(order_items.quantity) as 'num' from production.categories join production.products on categories.category_id = products.category_id join sales.order_items on products.product_id = order_items.product_id group by category_name order by num desc )select(select sum(order_items.quantity) from sales.order_items ) - (select sum(num) from sum_num) as 'result_sub' ";
                reader = command.ExecuteReader();
                reader.Read();
                labelsss[count_2] = "Other";
                valuesss[count_2] = double.Parse(reader["result_sub"].ToString());
                reader.Close();

                var chartsss = wpf_2.Plot.AddPie(valuesss, hideGridAndFrame: true);
                chartsss.ShowPercentages = true;
                chartsss.SliceLabels = labelsss;
                wpf_2.Plot.Legend(location: Alignment.UpperRight);
                chartsss.SliceLabelPosition = 0.3;
                chartsss.Size = 0.5;
                chartsss.SliceFont.Size = 10;
                chartsss.SliceFont.Bold = true;
                wpf_2.Configuration.LeftClickDragPan = false;
                wpf_2.Configuration.RightClickDragZoom = false;
                wpf_2.Configuration.ScrollWheelZoom = false;
                wpf_2.Refresh();







                int count_1 = 0;
                int rownum_1 = 0;
                command.CommandText = "select top 5 customers.city , COUNT(*) as 'num' from sales.customers join sales.orders on orders.customer_id =customers.customer_id group by customers.city order by num desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_1++;
                    }
                    reader.Close();
                }
                double[] valuessss = new double[rownum_1];
                string[] labelssss = new string[rownum_1];
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        labelssss[count_1] = reader["city"].ToString();
                        valuessss[count_1] = double.Parse(reader["num"].ToString());

                        count_1++;
                    }
                    reader.Close();
                }

                var chartssss = wpf_1.Plot.AddPie(valuessss, hideGridAndFrame: true);
                chartssss.ShowPercentages = true;
                chartssss.SliceLabels = labelssss;
                wpf_1.Plot.Legend(location: Alignment.UpperRight);
                chartssss.SliceLabelPosition = 0.3;
                chartssss.Size = .47;
                chartssss.SliceFont.Size = 10;
                chartssss.DonutSize = 0;
                chartssss.Explode = true;
                wpf_1.Configuration.LeftClickDragPan = false;
                wpf_1.Configuration.RightClickDragZoom = false;
                wpf_1.Configuration.ScrollWheelZoom = false;
                wpf_1.Refresh();





                //datagride
                adb.SelectCommand = new SqlCommand(" select top 5 customers.first_name +' '+ customers.last_name as 'full_name' , '$'+convert(varchar(50),sum(orders.total_mount)) as 'cash'  from sales.customers join sales.orders on customers.customer_id=orders.customer_id group by customers.first_name +' '+ customers.last_name order by SUM(orders.total_mount) desc", conn);
                tab.Clear();
                adb.Fill(tab);
                datagride_customer.ItemsSource = tab.DefaultView;


                adb.SelectCommand = new SqlCommand(" select top 5 first_name + ' '+ last_name as 'full_name',' $'+ convert(varchar(max), orders.total_mount) as 'total_mount'   from sales.customers join sales.orders on customers.customer_id= orders.customer_id order by orders.order_id desc", conn);
                tab_1.Clear();
                adb.Fill(tab_1);
                datagride_last_order.ItemsSource = tab_1.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

     
    }
}
