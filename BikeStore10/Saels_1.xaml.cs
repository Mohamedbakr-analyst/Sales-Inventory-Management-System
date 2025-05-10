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
using System.Globalization;
using System.Data.SqlClient;
using System.Data;


namespace BikeStore10
{
    /// <summary>
    /// Interaction logic for Saels_1.xaml
    /// </summary>
    public partial class Saels_1 : Window
    {

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_44330760199;Integrated Security=True");

        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_2;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter adb = new SqlDataAdapter();
        DataTable tab_order = new DataTable();
        DataTable tab_textcustomer = new DataTable();
        DataTable tab_textproduct = new DataTable();

        public Saels_1()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                command.Connection = conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tab_order.Clear();
            tab_order.Columns.Clear();
            tab_order.Columns.Add("item_id", typeof(int));
            tab_order.Columns.Add("product_id", typeof(int));
            tab_order.Columns.Add("product_name", typeof(string));
            tab_order.Columns.Add("quantity", typeof(int));
            tab_order.Columns.Add("list_price", typeof(double));
            tab_order.Columns.Add("total_mount", typeof(double));


        }
        private void Window_Closed(object sender, EventArgs e)
        {
            conn.Close();
        }


        private void text_name_user_Loaded(object sender, RoutedEventArgs e)
        {
            text_name_user.Content = TextReference.StoredText;
            image_user.Source = TextReference.StoredBitmapImage;
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            InputLanguageManager.Current.CurrentInputLanguage = CultureInfo.GetCultureInfo("en-US");
            if (gride_saels_customer.Visibility == Visibility.Visible && griddata_brandname_saels_customer.Visibility == Visibility.Hidden)
            {
                if (e.KeyboardDevice.IsKeyDown(Key.Enter))
                {
                    label_add_saels_customer_MouseLeftButtonDown(sender, null);
                }

            }
            else if (gride_saels_order.Visibility == Visibility.Visible)
            {
                if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.A))
                {
                    label_add_saels_order_MouseLeftButtonDown(sender, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.C))
                {
                    label_cancel_saels_order_MouseLeftButtonDown(sender, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.S))
                {
                    label_print_saels_order_MouseLeftButtonDown(sender, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.D))
                {
                    label_cancelall_saels_order_MouseLeftButtonDown(sender, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.W))
                {
                    gride_saels_order.Visibility = Visibility.Hidden;
                    gride_saels_customer.Visibility = Visibility.Visible;
                    Textbox_enter_productname_saels_customer.Focus();
                    label_cancel_saels_order_MouseLeftButtonDown(sender, null);
                    label_cancelall_saels_order_MouseLeftButtonDown(sender, null);
                }
            }
           
        }


        //--------------------------------------------Fixed-----------------------------------------------------

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



        private void Lable_inmenu_1_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            homebage_1 homebage_1_1 = new homebage_1();
            homebage_1_1.Show();
            this.Close();
        }

        private void Image_menu_1_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            homebage_1 homebage_1_1 = new homebage_1();
            homebage_1_1.Show();
            this.Close();
        }

        private void Lable_inmenu_2_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void image_menu_2_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            
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

        private void Lable_menu_4_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Customer_1 customer_1_1 = new Customer_1();
            customer_1_1.Show();
            this.Close();
        }

        private void image_menu_4_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Customer_1 customer_1_1 = new Customer_1();
            customer_1_1.Show();
            this.Close();
        }

        private void Lable_menu_5_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Rebort_1 rebort_1_1 = new Rebort_1();
            rebort_1_1.Show();
            this.Close();
        }

        private void image_menu_5_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Rebort_1 rebort_1_1 = new Rebort_1();
            rebort_1_1.Show();
            this.Close();

        }

        private void lable_menu_6_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            User_1 user_1_1 = new User_1();
            user_1_1.Show();
            this.Close();
        }

        private void image_menu_6_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
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
            rebort_1_1.gride_product.Visibility = Visibility.Visible;
            rebort_1_1.scroll_product.Visibility = Visibility.Visible;
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





        //---------------------------------------------------- Change---------------------------------------------------


        //--------------------------------------- 1-Customer---------------------------------------------------

        //---------------------------------------Text box entery customer-------------------------------------
        private void Textbox_enter_productname_saels_customer_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_productname_saels_customer.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_productname_saels_customer_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_productname_saels_customer.Effect = null;

        }

        private void Textbox_enter_productname_saels_customer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Textbox_enter_productname_saels_customer.Text == null || Textbox_enter_productname_saels_customer.Text == "")
            {
                griddata_brandname_saels_customer.Visibility = Visibility.Hidden;
                Textbox_enter_productname_saels_customer.Height = 36;
                Textbox_enter_productname_saels_customer.VerticalContentAlignment = VerticalAlignment.Center;

            }
            else if (Textbox_enter_productname_saels_customer.Text != null || Textbox_enter_productname_saels_customer.Text != "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand($" select distinct top 6 first_name+' '+last_name as 'full_name' from sales.customers where first_name+' '+last_name Like @va_1+'%'  order by first_name+' '+last_name asc ", conn);
                    command.Parameters.Clear();
                    adb.SelectCommand.Parameters.AddWithValue("@va_1", Textbox_enter_productname_saels_customer.Text);
                    tab_textcustomer.Clear();
                    adb.Fill(tab_textcustomer);
                    griddata_brandname_saels_customer.ItemsSource = tab_textcustomer.DefaultView;
                    griddata_brandname_saels_customer.Visibility = Visibility.Visible;

                    Textbox_enter_productname_saels_customer.Height = 193;
                    Textbox_enter_productname_saels_customer.VerticalContentAlignment = VerticalAlignment.Top;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void Textbox_enter_productname_saels_customer_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (griddata_brandname_saels_customer.Visibility == Visibility)
            {


                if (e.Key == Key.Down)
                {

                    if (griddata_brandname_saels_customer.SelectedIndex >= -1 && griddata_brandname_saels_customer.SelectedIndex <= 4)
                    {
                        griddata_brandname_saels_customer.SelectedIndex = griddata_brandname_saels_customer.SelectedIndex + 1;
                    }
                    else if (griddata_brandname_saels_customer.SelectedIndex == 5)
                    {
                        griddata_brandname_saels_customer.SelectedIndex = 0;
                    }

                }
                else if (e.Key == Key.Up)
                {
                    if (griddata_brandname_saels_customer.SelectedIndex <= 5 && griddata_brandname_saels_customer.SelectedIndex >= 1)
                    {
                        griddata_brandname_saels_customer.SelectedIndex = griddata_brandname_saels_customer.SelectedIndex - 1;
                    }
                    else if (griddata_brandname_saels_customer.SelectedIndex == 0)
                    {
                        griddata_brandname_saels_customer.SelectedIndex = 5;
                    }

                }
                else if (e.Key == Key.Enter)
                {
                    int x = griddata_brandname_saels_customer.SelectedIndex;
                    if (x >= 0)
                    {
                        var cellValue = griddata_brandname_saels_customer.Items[x] as DataRowView;


                        string value = cellValue[0].ToString();

                        Textbox_enter_productname_saels_customer.Text = value;
                        Textbox_enter_productname_saels_customer.SelectionStart = value.Length;
                        griddata_brandname_saels_customer.Visibility = Visibility.Hidden;

                        Textbox_enter_productname_saels_customer.Height = 36;
                        Textbox_enter_productname_saels_customer.VerticalContentAlignment = VerticalAlignment.Center;

                    }

                }
                else if (e.Key == Key.Escape)
                {
                    griddata_brandname_saels_customer.Visibility = Visibility.Hidden;

                    Textbox_enter_productname_saels_customer.Height = 36;
                    Textbox_enter_productname_saels_customer.VerticalContentAlignment = VerticalAlignment.Center;

                }
            }
        }


        //---------------------------------------Button ok customer-------------------------------------
        private void label_add_saels_customer_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_add_saels_customer.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_add_saels_customer_MouseLeave(object sender, MouseEventArgs e)
        {
            border_add_saels_customer.Effect = null;
        }

        private void label_add_saels_customer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Textbox_enter_productname_saels_customer.Text) == false)
            {
                int num_row_customer = 0;
                int customer_id = -1;
                command.CommandText = $"select customer_id as 'num' from sales.customers where first_name+' '+last_name =@va_1";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@va_1", Textbox_enter_productname_saels_customer.Text);
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customer_id = int.Parse(reader["num"].ToString());
                        num_row_customer++;

                    }
                    reader.Close();
                }

                if (num_row_customer == 0)
                {
                    MessageBox.Show("Sorry, The customer name not found,Please enter customer name is in the data ");
                }
                else if (num_row_customer >= 1)
                {

                    Textbox_enter_customername_saels_order.Text = Textbox_enter_productname_saels_customer.Text;
                    textbox_customer_id.Text = customer_id.ToString();
                    Textbox_enter_productname_saels_customer.Text = null;
                    gride_saels_customer.Visibility = Visibility.Hidden;
                    gride_saels_order.Visibility = Visibility.Visible;
                    Textbox_enter_productname_saels_order.Focus();



                }

            }
            else if (string.IsNullOrWhiteSpace(Textbox_enter_productname_saels_customer.Text) == true)
            {
                MessageBox.Show("Sorry, You must enter customer name, you can select customer called Not Not");

            }
        }

        //--------------------------------------- 2-Order---------------------------------------------------

        //---------------------------------------Text box entery order-------------------------------------


        private void Textbox_enter_productname_saels_order_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_productname_saels_order.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF); ;
        }

        private void Textbox_enter_brandname_saels_order_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_brandname_saels_order.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);

            if (Textbox_enter_brandname_saels_order.Text == "0")
            {
                Textbox_enter_brandname_saels_order.Text = "";
            }
            if (string.IsNullOrWhiteSpace(Textbox_enter_productname_saels_order.Text) == true)
            {
                textbox_producy_id.Text = "-1";
            }

        }

        private void Textbox_enter_productname_saels_order_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_productname_saels_order.Effect = null;


            griddata_brandname_saels_order.Visibility = Visibility.Hidden;
            Textbox_enter_productname_saels_order.Height = 36;
            Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Center;

            int num_row_product = 0;
            int product_id = -1;
            command.CommandText = $"select distinct top 1 product_id as 'num' from production.products where product_name=@va_1";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@va_1", Textbox_enter_productname_saels_order.Text);
            using (reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    product_id = int.Parse(reader["num"].ToString());
                    num_row_product++;

                }
                reader.Close();
            }
            if (num_row_product >= 1)
            {
                textbox_producy_id.Text = product_id.ToString();
            }
            else if (num_row_product == 0)
            {
                textbox_producy_id.Text = "-1";
            }


            if (textbox_producy_id.Text != "-1")
            {
                command.CommandText = $"select list_price  'num' from production.products where product_id=@va_1";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@va_1", textbox_producy_id.Text);

                double list_price = 0;
                using (reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list_price = double.Parse(reader["num"].ToString());

                    }
                    reader.Close();
                }

                Textbox_enter_catogaryname_saels_order.Text = list_price.ToString();
                Textbox_enter_modelyear_saels_order.Text = (int.Parse(Textbox_enter_brandname_saels_order.Text) * list_price).ToString();
            }
            else if (textbox_producy_id.Text == "-1")
            {
                Textbox_enter_catogaryname_saels_order.Text = "0";
                Textbox_enter_modelyear_saels_order.Text = "0";

            }
        }

        private void Textbox_enter_productname_saels_order_TextChanged(object sender, TextChangedEventArgs e)
        {
            textbox_producy_id.Text = "-1";
            if (Textbox_enter_productname_saels_order.Text == null || Textbox_enter_productname_saels_order.Text == "")
            {
                griddata_brandname_saels_order.Visibility = Visibility.Hidden;
                Textbox_enter_productname_saels_order.Height = 36;
                Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Center;

            }
            else if (Textbox_enter_productname_saels_order.Text != null || Textbox_enter_productname_saels_order.Text != "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand($" select distinct top 5 product_name as 'product_name',product_id from production.products where product_name Like @va_1+'%'  order by product_name asc ", conn);
                    command.Parameters.Clear();
                    adb.SelectCommand.Parameters.AddWithValue("@va_1", Textbox_enter_productname_saels_order.Text);
                    tab_textproduct.Clear();
                    adb.Fill(tab_textproduct);
                    griddata_brandname_saels_order.ItemsSource = tab_textproduct.DefaultView;
                    griddata_brandname_saels_order.Visibility = Visibility.Visible;

                    Textbox_enter_productname_saels_order.Height = 165;
                    Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Top;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void Textbox_enter_productname_saels_order_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (griddata_brandname_saels_order.Visibility == Visibility)
            {

                if (e.Key == Key.Down)
                {
                    if (griddata_brandname_saels_order.SelectedIndex >= -1 && griddata_brandname_saels_order.SelectedIndex <= 3)
                    {
                        griddata_brandname_saels_order.SelectedIndex = griddata_brandname_saels_order.SelectedIndex + 1;
                    }
                    else if (griddata_brandname_saels_order.SelectedIndex == 4)
                    {
                        griddata_brandname_saels_order.SelectedIndex = 0;
                    }

                }
                else if (e.Key == Key.Up)
                {
                    if (griddata_brandname_saels_order.SelectedIndex <= 4 && griddata_brandname_saels_order.SelectedIndex >= 1)
                    {
                        griddata_brandname_saels_order.SelectedIndex = griddata_brandname_saels_order.SelectedIndex - 1;
                    }
                    else if (griddata_brandname_saels_order.SelectedIndex == 0)
                    {
                        griddata_brandname_saels_order.SelectedIndex = 4;
                    }

                }
                else if (e.Key == Key.Enter)
                {
                    int x = griddata_brandname_saels_order.SelectedIndex;
                    if (x >= 0)
                    {
                        var cellValue = griddata_brandname_saels_order.Items[x] as DataRowView;


                        string value = cellValue[0].ToString();
                        string product_id = cellValue[1].ToString();

                        Textbox_enter_productname_saels_order.Text = value;
                        textbox_producy_id.Text = product_id;
                        Textbox_enter_productname_saels_order.SelectionStart = value.Length;
                        griddata_brandname_saels_order.Visibility = Visibility.Hidden;

                        Textbox_enter_productname_saels_order.Height = 36;
                        Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Center;

                        if (textbox_producy_id.Text != "-1")
                        {
                            command.CommandText = $"select list_price  'num' from production.products where product_id=@va_1";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@va_1", textbox_producy_id.Text);

                            double list_price = 0;
                            using (reader = command.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    list_price = double.Parse(reader["num"].ToString());

                                }
                                reader.Close();
                            }

                            Textbox_enter_catogaryname_saels_order.Text = list_price.ToString();
                            Textbox_enter_modelyear_saels_order.Text = (int.Parse(Textbox_enter_brandname_saels_order.Text) * list_price).ToString();
                        }
                        else if (textbox_producy_id.Text == "-1")
                        {
                            Textbox_enter_catogaryname_saels_order.Text = "0";
                            Textbox_enter_modelyear_saels_order.Text = "0";

                        }





                    }

                }
                else if (e.Key == Key.Escape)
                {
                    griddata_brandname_saels_order.Visibility = Visibility.Hidden;

                    Textbox_enter_productname_saels_order.Height = 36;
                    Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Center;

                    int num_row_product = 0;
                    int product_id = -1;
                    command.CommandText = $"select distinct top 1 product_id as 'num' from production.products where product_name=@va_1";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@va_1", Textbox_enter_productname_saels_order.Text);
                    using (reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            product_id = int.Parse(reader["num"].ToString());
                            num_row_product++;

                        }
                        reader.Close();
                    }
                    if (num_row_product >= 1)
                    {
                        textbox_producy_id.Text = product_id.ToString();
                    }
                    else if (num_row_product == 0)
                    {
                        textbox_producy_id.Text = "-1";
                    }



                    if (textbox_producy_id.Text != "-1")
                    {
                        command.CommandText = $"select list_price  'num' from production.products where product_id=@va_1";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@va_1", textbox_producy_id.Text);

                        double list_price = 0;
                        using (reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                list_price = double.Parse(reader["num"].ToString());

                            }
                            reader.Close();
                        }

                        Textbox_enter_catogaryname_saels_order.Text = list_price.ToString();
                        Textbox_enter_modelyear_saels_order.Text = (int.Parse(Textbox_enter_brandname_saels_order.Text) * list_price).ToString();
                    }
                    else if (textbox_producy_id.Text == "-1")
                    {
                        Textbox_enter_catogaryname_saels_order.Text = "0";
                        Textbox_enter_modelyear_saels_order.Text = "0";

                    }

                }


            }
            else if (griddata_brandname_saels_order.Visibility == Visibility.Hidden)
            {
                if (e.Key == Key.Down || e.Key == Key.Enter)
                {
                    Textbox_enter_brandname_saels_order.Focus();
                }


            }
        }

        private void Textbox_enter_brandname_saels_order_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_brandname_saels_order.Effect = null;

            int.TryParse(Textbox_enter_brandname_saels_order.Text, out int x);
            if (string.IsNullOrWhiteSpace(Textbox_enter_brandname_saels_order.Text) == true || x / 1 == 0)
            {
                Textbox_enter_brandname_saels_order.Text = "0";
            }

        }

        private void Textbox_enter_brandname_saels_order_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox_producy_id != null && textbox_producy_id.Text != "" && textbox_producy_id.Text != "-1" && string.IsNullOrWhiteSpace(Textbox_enter_brandname_saels_order.Text) == false)
            {

                command.CommandText = $"select list_price  'num' from production.products where product_id=@va_1";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@va_1", textbox_producy_id.Text);

                double list_price = 0;
                using (reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list_price = double.Parse(reader["num"].ToString());

                    }
                    reader.Close();
                }

                Textbox_enter_catogaryname_saels_order.Text = list_price.ToString();
                Textbox_enter_modelyear_saels_order.Text = (int.Parse(Textbox_enter_brandname_saels_order.Text) * list_price).ToString();
            }
            else if (textbox_producy_id != null && textbox_producy_id.Text != "" && textbox_producy_id.Text == "-1")
            {
                Textbox_enter_catogaryname_saels_order.Text = "0";
                Textbox_enter_modelyear_saels_order.Text = "0";

            }

        }

        private void Textbox_enter_brandname_saels_order_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                Textbox_enter_productname_saels_order.Focus();
            }
            else if (e.Key == Key.Enter)
            {
                label_add_saels_order_MouseLeftButtonDown(sender, null);
            }
        }

        private void Textbox_enter_brandname_saels_order_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Length > 0)
            {
                if (char.IsDigit(e.Text, 0) == false)
                {
                    e.Handled = true;
                }
            }
        }


        //---------------------------------------Button add,cancel,print,cancelall order-------------------------------------
        private void label_add_saels_order_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_add_saels_order.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_cancel_saels_order_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_cancel_saels_order.Effect = effect;
            effect.ShadowDepth = 1;
        }
        private void label_print_saels_order_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_print_saels_order.Effect = effect;
            effect.ShadowDepth = 1;
        }
        private void label_cancelall_saels_order_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_cancelall_saels_order.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_add_saels_order_MouseLeave(object sender, MouseEventArgs e)
        {
            border_add_saels_order.Effect = null;
        }

        private void label_add_saels_order_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int.TryParse(Textbox_enter_brandname_saels_order.Text, out int x);
            if (textbox_producy_id.Text != "-1" && x > 0)
            {
                command.CommandText = $"select (select quantity from production.stocks where product_id = @va_1 and store_id =3)- @va_2 as 'num'";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@va_1", textbox_producy_id.Text);
                command.Parameters.AddWithValue("@va_2", Textbox_enter_brandname_saels_order.Text);


                double result = 0;
                using (reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        result = double.Parse(reader["num"].ToString());

                    }
                    reader.Close();
                }


                if (result >= 0)
                {
                    bool valueExists = tab_order.AsEnumerable().Any(row => row.Field<int>("product_id") == int.Parse( textbox_producy_id.Text));
                    if (valueExists == false)
                    {
                        tab_order.Rows.Add(0, int.Parse(textbox_producy_id.Text), Textbox_enter_productname_saels_order.Text, int.Parse(Textbox_enter_brandname_saels_order.Text), double.Parse(Textbox_enter_catogaryname_saels_order.Text), double.Parse(Textbox_enter_modelyear_saels_order.Text));
                        griddata_all_saels_order.ItemsSource = tab_order.DefaultView;
                        for (int i = 0; i < tab_order.Rows.Count; i++)
                        {
                            tab_order.Rows[i]["item_id"] = i + 1;
                        }

                        Textbox_enter_productname_saels_order.Text = "";
                        Textbox_enter_brandname_saels_order.Text = "0";
                        Textbox_enter_productname_saels_order.Focus();

                        int no_item = tab_order.Rows.Count;
                        int no_product = tab_order.AsEnumerable().Sum(row => Convert.ToInt32(row["quantity"]));
                        double sup_total = tab_order.AsEnumerable().Sum(row => Convert.ToDouble(row["total_mount"]));

                        label_no_item.Content = no_item.ToString();
                        label_no_product.Content = no_product.ToString();
                        label_sup_total.Content = sup_total.ToString();

                    }
                    else if (valueExists == true)
                    {
                        MessageBox.Show("Check The data show it contain the product name");

                        Textbox_enter_productname_saels_order.Text = "";
                        Textbox_enter_brandname_saels_order.Text = "0";
                        Textbox_enter_productname_saels_order.Focus();
                    }





                }
                else if (result < 0)
                {
                    command.CommandText = $"select quantity as 'num' from production.stocks where product_id = @va_1 and store_id =3 ";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@va_1", textbox_producy_id.Text);

                    double quantity = 0;
                    using (reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            quantity = double.Parse(reader["num"].ToString());

                        }
                        reader.Close();
                    }
                    MessageBox.Show($"The stock is less than quantity, There is in the stock {quantity.ToString()} product ");
                }

            }
            else if (textbox_producy_id.Text == "-1" || x == 0)
            {
                MessageBox.Show("Check the quantity must have number greater than zero and product name must is in the data ");
            }
        }

        private void label_cancel_saels_order_MouseLeave(object sender, MouseEventArgs e)
        {
            border_cancel_saels_order.Effect = null;
        }

        private void label_cancel_saels_order_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textbox_enter_productname_saels_order.Text = "";
            Textbox_enter_brandname_saels_order.Text = "0";
            Textbox_enter_productname_saels_order.Focus();
        }

        private void label_print_saels_order_MouseLeave(object sender, MouseEventArgs e)
        {
            border_print_saels_order.Effect = null;
        }

        private void label_print_saels_order_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            int row_num= tab_order.Rows.Count;
            if (row_num >= 1)
            {
                command.CommandText = $"insert into sales.orders(customer_id,order_status,order_date,required_date,shipped_date,store_id,staff_id,total_mount) values({textbox_customer_id.Text},4,SYSDATETIME(),SYSDATETIME(),SYSDATETIME(),3,9,{label_sup_total.Content}) ";
                command.ExecuteNonQuery();

                command.CommandText = "select top 1 order_id as 'num' from sales.orders order by order_id desc";
                int order_id = 0;
                using (reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        order_id = int.Parse(reader["num"].ToString());

                    }
                    reader.Close();
                }

                for(int i=0; i < tab_order.Rows.Count; i++)
                {
                    command.CommandText = $"insert into sales.order_items(order_id,item_id,product_id,quantity,list_price,discount,total_mount) values({order_id},{ tab_order.Rows[i]["item_id"]},{ tab_order.Rows[i]["product_id"]},{ tab_order.Rows[i]["quantity"]},{ tab_order.Rows[i]["list_price"]},0.00,{ tab_order.Rows[i]["total_mount"]})";
                    command.ExecuteNonQuery();

                    command.CommandText = $"update production.stocks set quantity = quantity - { tab_order.Rows[i]["quantity"]} where store_id=3 and product_id={ tab_order.Rows[i]["product_id"]}";
                    command.ExecuteNonQuery();
                }

            
                
                bill_1 bil_1_1 = new bill_1();
                bil_1_1.customer_id= int.Parse(textbox_customer_id.Text);
                bil_1_1.customer_name = Textbox_enter_customername_saels_order.Text;
                bil_1_1.Show();
                bil_1_1.griddata_all_saels_order.ItemsSource = tab_order.DefaultView;
                bil_1_1.customer_name_bill.Content = Textbox_enter_customername_saels_order.Text;
                bil_1_1.no_order.Content = order_id.ToString();
                bil_1_1.date_bill.Content= DateTime.Now.ToString("MM/dd/yyyy 'at' h:mm tt");
                bil_1_1.no_item_2_margin.Content = label_no_item.Content;
                bil_1_1.no_product_2_margin.Content = label_no_product.Content;
                bil_1_1.sup_total_2_margin.Content = label_sup_total.Content;
                this.Close();
            }




          
        }
        public void deleteall()
        {
            label_cancel_saels_order_MouseLeftButtonDown(null, null);
            label_cancelall_saels_order_MouseLeftButtonDown(null, null);
        }

       

        private void label_cancelall_saels_order_MouseLeave(object sender, MouseEventArgs e)
        {
            border_cancelall_saels_order.Effect = null;
        }

        private void label_cancelall_saels_order_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tab_order.Rows.Clear();

            label_no_item.Content = "0";
            label_no_product.Content = "0";
            label_sup_total.Content = "0";
        }


        //--------------------------------------------------------gridedat-all_saels ---------------------------
        string namepinding_saels = "";
        bool beginedit = false;
        private void griddata_all_saels_order_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            namepinding_saels = griddata_all_saels_order.CurrentCell.Column.SortMemberPath;
            var textBox_2 = e.EditingElement as TextBox;
            if (textBox_2 != null)
            {
                textBox_2.Text = "";
                beginedit = true;

                if (textBox_2 != null)
                {
                    textBox_2.TextChanged += TextBox_2TextChanged1_saels;
                    textBox_2.PreviewKeyDown += textBox_2privew_saels;
                    textBox_2.LostFocus += textBox_2lostfocus_saels;
                    textBox_2.PreviewTextInput += textBox_2textinput_saels;
                }

                Textbox_enter_productname_saels_order.Text = "";
                Textbox_enter_brandname_saels_order.Text = "0";
                Textbox_enter_catogaryname_saels_order.Text = "0";
                Textbox_enter_modelyear_saels_order.Text = "0";
            }
           
        }

        private void TextBox_2TextChanged1_saels(object sender, TextChangedEventArgs e)
        {
            TextBox textBox_2 = sender as TextBox;

            if (namepinding_saels == "product_name")
            {
                textbox_producy_id.Text = "-1";
                if (textBox_2.Text == null || textBox_2.Text == "")
                {
                    griddata_brandname_saels_order.Visibility = Visibility.Hidden;
                    Textbox_enter_productname_saels_order.Height = 36;
                    Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Center;

                }
                else if (textBox_2.Text != null || textBox_2.Text != "")
                {
                    try
                    {

                        adb.SelectCommand = new SqlCommand($" select distinct top 5 product_name as 'product_name',product_id from production.products where product_name Like @va_1+'%'  order by product_name asc ", conn);
                        command.Parameters.Clear();
                        adb.SelectCommand.Parameters.AddWithValue("@va_1", textBox_2.Text);
                        tab_textproduct.Clear();
                        adb.Fill(tab_textproduct);
                        griddata_brandname_saels_order.ItemsSource = tab_textproduct.DefaultView;
                        griddata_brandname_saels_order.Visibility = Visibility.Visible;

                        Textbox_enter_productname_saels_order.Height = 165;
                        Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Top;
                        System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
                        Textbox_enter_productname_saels_order.Effect = effect;
                        effect.ShadowDepth = 1;
                        effect.BlurRadius = 10;
                        effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }

            }

        }

        bool key_enter_text_cell_saels = false;
        private void textBox_2privew_saels(object sender, KeyEventArgs e)
        {
            TextBox textBox_2 = sender as TextBox;
            if (namepinding_saels == "product_name")
            {
                if (griddata_brandname_saels_order.Visibility == Visibility)
                {

                    if (e.Key == Key.Down)
                    {
                        if (griddata_brandname_saels_order.SelectedIndex >= -1 && griddata_brandname_saels_order.SelectedIndex <= 3)
                        {
                            griddata_brandname_saels_order.SelectedIndex = griddata_brandname_saels_order.SelectedIndex + 1;
                        }
                        else if (griddata_brandname_saels_order.SelectedIndex == 4)
                        {
                            griddata_brandname_saels_order.SelectedIndex = 0;
                        }

                    }
                    else if (e.Key == Key.Up)
                    {
                        if (griddata_brandname_saels_order.SelectedIndex <= 4 && griddata_brandname_saels_order.SelectedIndex >= 1)
                        {
                            griddata_brandname_saels_order.SelectedIndex = griddata_brandname_saels_order.SelectedIndex - 1;
                        }
                        else if (griddata_brandname_saels_order.SelectedIndex == 0)
                        {
                            griddata_brandname_saels_order.SelectedIndex = 4;
                        }

                    }
                    else if (e.Key == Key.Enter)
                    {
                        int x = griddata_brandname_saels_order.SelectedIndex;
                        if (x >= 0)
                        {
                            var cellValue = griddata_brandname_saels_order.Items[x] as DataRowView;


                            string value = cellValue[0].ToString();
                            string product_id = cellValue[1].ToString();

                            textBox_2.Text = value;
                            textbox_producy_id.Text = product_id;
                            textBox_2.SelectionStart = value.Length;
                            griddata_brandname_saels_order.Visibility = Visibility.Hidden;

                            Textbox_enter_productname_saels_order.Height = 36;
                            Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Center;

                        }

                    }


                }

            }

            if (e.Key == Key.Enter)
            {
                key_enter_text_cell_saels = true;
            }

        }

        private void textBox_2lostfocus_saels(object sender, RoutedEventArgs e)
        {
            if (namepinding_saels == "product_name")
            {
                TextBox textBox_2 = sender as TextBox;

                griddata_brandname_saels_order.Visibility = Visibility.Hidden;

                Textbox_enter_productname_saels_order.Height = 36;
                Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_productname_saels_order.Effect = null;
            }
        }

        private void textBox_2textinput_saels(object sender, TextCompositionEventArgs e)
        {

            TextBox textBox_2 = sender as TextBox;

            if (namepinding_saels == "quantity")
            {

                if (e.Text.Length > 0)
                {
                    if (char.IsDigit(e.Text, 0) == false)
                    {
                        e.Handled = true;
                    }
                }

            }
        }

        private void griddata_all_saels_order_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_saels == true)
            {

                if (griddata_all_saels_order.CurrentCell.Column != null)
                {
                    var namepinding = griddata_all_saels_order.CurrentCell.Column.SortMemberPath;
                    var headercoulmn = griddata_all_saels_order.CurrentCell.Column.Header;
                    var indexcoulmn = griddata_all_saels_order.CurrentCell.Column.DisplayIndex;
                    var cellInfo = griddata_all_saels_order.SelectedCells[indexcoulmn];
                    string content = cellInfo.Column.GetCellContent(cellInfo.Item).ToString();
                    string value = null;
                    if (content.Length >= 34)
                    {
                        value = content.Substring(33, content.Length - 33);
                    }
                    else if (content.Length == 31)
                    {
                        value = null;
                    }

                    int numberofindex = griddata_all_saels_order.SelectedIndex;
                    var cellValue = griddata_all_saels_order.Items[numberofindex] as DataRowView;
                    string value_id = "";
                    value_id = cellValue[1].ToString();

                    int.TryParse(value, out int x);


                    if (string.IsNullOrWhiteSpace(value) == false && (namepinding.ToString() == "product_name" || (namepinding.ToString() == "quantity") && x/1!=0))
                    {

                        

                        if (namepinding == "quantity")
                        {

                            command.CommandText = $"select (select quantity from production.stocks where product_id = @va_1 and store_id =3)- @va_2 as 'num'";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@va_1", value_id.ToString());
                            command.Parameters.AddWithValue("@va_2", value);


                            double result = 0;
                            using (reader = command.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    result = double.Parse(reader["num"].ToString());

                                }
                                reader.Close();
                            }

                            if (result >= 0)
                            {

                                tab_order.Rows[griddata_all_saels_order.SelectedIndex]["quantity"] = value;
                                tab_order.Rows[griddata_all_saels_order.SelectedIndex]["total_mount"] = (double.Parse(tab_order.Rows[griddata_all_saels_order.SelectedIndex]["list_price"].ToString())) * int.Parse(value);

                                int no_item = tab_order.Rows.Count;
                                int no_product = tab_order.AsEnumerable().Sum(row => Convert.ToInt32(row["quantity"]));
                                double sup_total = tab_order.AsEnumerable().Sum(row => Convert.ToDouble(row["total_mount"]));

                                label_no_item.Content = no_item.ToString();
                                label_no_product.Content = no_product.ToString();
                                label_sup_total.Content = sup_total.ToString();

                            }
                            else if (result < 0)
                            {
                                griddata_all_saels_order.CancelEdit();

                                command.CommandText = $"select quantity as 'num' from production.stocks where product_id = @va_1 and store_id =3 ";
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@va_1", value_id.ToString());


                                double quantity = 0;
                                using (reader = command.ExecuteReader())
                                {

                                    while (reader.Read())
                                    {
                                        quantity = double.Parse(reader["num"].ToString());

                                    }
                                    reader.Close();
                                }
                                MessageBox.Show($"The stock is less than quantity, There is in the stock {quantity.ToString()} product ");
                            }
                        }
                          
                        else if (namepinding == "product_name")
                        {
                            string new_product_id = "";
                            int num_row = 0;
                            command.CommandText = $"select top 1 product_id from production.products where product_name= @va_1";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@va_1", value.ToString());

                            using (reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    new_product_id = reader["product_id"].ToString();
                                    num_row++;

                                }
                                reader.Close();
                            }


                         

                            if (num_row >= 1)
                            {

                                command.CommandText = $"select (select quantity from production.stocks where product_id = @va_1 and store_id =3)- @va_2 as 'num'";
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@va_1", new_product_id.ToString());
                                command.Parameters.AddWithValue("@va_2", 1);


                                double result = 0;
                                using (reader = command.ExecuteReader())
                                {

                                    while (reader.Read())
                                    {
                                        result = double.Parse(reader["num"].ToString());

                                    }
                                    reader.Close();
                                }
                                if (result >= 0)
                                {
                                    command.CommandText = $"select list_price  'num' from production.products where product_id=@va_1";
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@va_1", new_product_id);

                                    double list_price = 0;
                                    using (reader = command.ExecuteReader())
                                    {

                                        while (reader.Read())
                                        {
                                            list_price = double.Parse(reader["num"].ToString());

                                        }
                                        reader.Close();
                                    }

                                    tab_order.Rows[griddata_all_saels_order.SelectedIndex]["list_price"] = list_price;
                                    tab_order.Rows[griddata_all_saels_order.SelectedIndex]["product_id"] = new_product_id;
                                    tab_order.Rows[griddata_all_saels_order.SelectedIndex]["quantity"] = 1;
                                    tab_order.Rows[griddata_all_saels_order.SelectedIndex]["total_mount"] = (double.Parse(tab_order.Rows[griddata_all_saels_order.SelectedIndex]["list_price"].ToString())) * (int.Parse(tab_order.Rows[griddata_all_saels_order.SelectedIndex]["quantity"].ToString()));

                                    int no_item = tab_order.Rows.Count;
                                    int no_product = tab_order.AsEnumerable().Sum(row => Convert.ToInt32(row["quantity"]));
                                    double sup_total = tab_order.AsEnumerable().Sum(row => Convert.ToDouble(row["total_mount"]));

                                    label_no_item.Content = no_item.ToString();
                                    label_no_product.Content = no_product.ToString();
                                    label_sup_total.Content = sup_total.ToString();

                                }

                                else if (result < 0)
                                {
                                    griddata_all_saels_order.CancelEdit();
                                    MessageBox.Show($"The stock of product is zero ");

                                }

                            }
                            else if (num_row == 0 )
                            {
                                griddata_all_saels_order.CancelEdit();
                                MessageBox.Show("Sorry, The product name is't in the data, Please Write product name is in the data");
                            }
                           

                        }
                        
                    }

                    else if (namepinding.ToString() == "item_id" || namepinding.ToString() == "list_price" || namepinding.ToString() == "total_mount")
                    {
                        griddata_all_saels_order.CancelEdit();

                    }

                    else if ((string.IsNullOrWhiteSpace(value) == true && (namepinding.ToString() == "product_name" || namepinding.ToString() == "quantity")) || (namepinding.ToString() == "quantity" && x/1==0 ))
                    {
                        MessageBox.Show("Sorry, Please Enter product name and the quantity must have number greater than zero");
                        griddata_all_saels_order.CancelEdit();

                    }
                }
                else
                {
                    griddata_all_saels_order.CancelEdit();
                    griddata_all_saels_order.SelectedItem = null;

                    griddata_brandname_saels_order.Visibility = Visibility.Hidden;

                    Textbox_enter_productname_saels_order.Height = 36;
                    Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Center;
                    Textbox_enter_productname_saels_order.Effect = null;

                }
                key_enter_text_cell_saels = false;
            }

            else if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_saels == false)
            {
                griddata_all_saels_order.CancelEdit();

                griddata_brandname_saels_order.Visibility = Visibility.Hidden;

                Textbox_enter_productname_saels_order.Height = 36;
                Textbox_enter_productname_saels_order.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_productname_saels_order.Effect = null;
            }

            beginedit = false;
            
        }

        private void griddata_all_saels_order_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back && beginedit==false )
            {
                tab_order.Rows.RemoveAt(griddata_all_saels_order.SelectedIndex);
                for (int i = 0; i < tab_order.Rows.Count; i++)
                {
                    tab_order.Rows[i]["item_id"] = i + 1;
                }
                int no_item = tab_order.Rows.Count;
                int no_product = tab_order.AsEnumerable().Sum(row => Convert.ToInt32(row["quantity"]));
                double sup_total = tab_order.AsEnumerable().Sum(row => Convert.ToDouble(row["total_mount"]));

                label_no_item.Content = no_item.ToString();
                label_no_product.Content = no_product.ToString();
                label_sup_total.Content = sup_total.ToString();
                
            }
            if (e.Key == Key.Enter && griddata_all_saels_order.CurrentCell.Column.DisplayIndex==6)
            {
                tab_order.Rows.RemoveAt(griddata_all_saels_order.SelectedIndex);
                for (int i = 0; i < tab_order.Rows.Count; i++)
                {
                    tab_order.Rows[i]["item_id"] = i + 1;
                }

                int no_item = tab_order.Rows.Count;
                int no_product = tab_order.AsEnumerable().Sum(row => Convert.ToInt32(row["quantity"]));
                double sup_total = tab_order.AsEnumerable().Sum(row => Convert.ToDouble(row["total_mount"]));

                label_no_item.Content = no_item.ToString();
                label_no_product.Content = no_product.ToString();
                label_sup_total.Content = sup_total.ToString();
            }
           
        }

        private void image_user_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (griddata_all_saels_order.SelectedIndex >= 0)
            {
                tab_order.Rows.RemoveAt(griddata_all_saels_order.SelectedIndex);
                for (int i = 0; i < tab_order.Rows.Count; i++)
                {
                    tab_order.Rows[i]["item_id"] = i + 1;
                }

                int no_item = tab_order.Rows.Count;
                int no_product = tab_order.AsEnumerable().Sum(row => Convert.ToInt32(row["quantity"]));
                double sup_total = tab_order.AsEnumerable().Sum(row => Convert.ToDouble(row["total_mount"]));

                label_no_item.Content = no_item.ToString();
                label_no_product.Content = no_product.ToString();
                label_sup_total.Content = sup_total.ToString();
            }
          
        }

    }
}
