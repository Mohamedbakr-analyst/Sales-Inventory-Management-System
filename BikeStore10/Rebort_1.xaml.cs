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
using ScottPlot;
using System.Data.SqlClient;
using System.Data;



namespace BikeStore10
{
    public partial class Rebort_1 : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_44330760199;Integrated Security=True");

        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_2;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter adb = new SqlDataAdapter();
        DataTable tab_product = new DataTable();
        DataTable tab_saels = new DataTable();
        DataTable tab_customer = new DataTable();





        public Rebort_1()
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
           
            if (gride_brand.Visibility==Visibility.Visible)
            {
                if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.W))
                {
                    label_load_report_MouseLeftButtonDown(sender, null);
                }
            }
            else if (gride_category.Visibility==Visibility.Visible)
            {
                if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.W))
                {
                    label_load_report_2_MouseLeftButtonDown(sender, null);
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
            Saels_1 saels_1_1 = new Saels_1();
            saels_1_1.Show();
            this.Close();
        }

        private void image_menu_2_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
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
           
        }

        private void image_menu_5_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
           
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
            gride_product.Visibility = Visibility.Visible;
            gride_brand.Visibility = Visibility.Hidden;
            gride_category.Visibility = Visibility.Hidden;
            scroll_product.Visibility = Visibility.Visible;
            scroll_brand.Visibility = Visibility.Hidden;
            scroll_category.Visibility = Visibility.Hidden;


            label_open_product.Background = null;
            border_open_product.Background = null;

            label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
           
        }

        private void Lable_morereport_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gride_brand.Visibility = Visibility.Visible;
            gride_product.Visibility = Visibility.Hidden;
            gride_category.Visibility = Visibility.Hidden;
            scroll_brand.Visibility = Visibility.Visible;
            scroll_product.Visibility = Visibility.Hidden;
            scroll_category.Visibility = Visibility.Hidden;


            label_open_brand.Background = null;
            border_open_brand.Background = null;

            label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
          
        }

        private void Lable_morereport_4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gride_category.Visibility = Visibility.Visible;
            gride_brand.Visibility = Visibility.Hidden;
            gride_product.Visibility = Visibility.Hidden;
            scroll_category.Visibility = Visibility.Visible;
            scroll_brand.Visibility = Visibility.Hidden;
            scroll_product.Visibility = Visibility.Hidden;

            label_open_category.Background = null;
            border_open_category.Background = null;

            label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
          
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

        //-------------------------------- gride 3 type product brand catogary visible hidden ---------------------------------------------------

        //1
        private void label_open_product_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            label_open_product.Effect = effect;
            border_open_product.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
        }

        private void label_open_product_MouseLeave(object sender, MouseEventArgs e)
        {
            label_open_product.Effect = null;
            border_open_product.Effect = null;

        }

        private void label_open_product_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (label_open_product.Background == null)
            {
              
                gride_product.Visibility = Visibility.Hidden;
                scroll_product.Visibility = Visibility.Hidden;
                label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));

              

            }
            else if (label_open_product.Background != null)
            {
                

                gride_product.Visibility = Visibility.Visible;
                gride_brand.Visibility = Visibility.Hidden;
                gride_category.Visibility = Visibility.Hidden;
                scroll_product.Visibility = Visibility.Visible;
                scroll_brand.Visibility = Visibility.Hidden;
                scroll_category.Visibility = Visibility.Hidden;




                label_open_product.Background = null;
                border_open_product.Background = null;

                label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                   

            }

        }

        //2
        private void label_open_brand_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            label_open_brand.Effect = effect;
            border_open_brand.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
        }

        private void label_open_brand_MouseLeave(object sender, MouseEventArgs e)
        {
            label_open_brand.Effect = null;
            border_open_brand.Effect = null;
        }

        private void label_open_brand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (label_open_brand.Background == null)
            {
                gride_brand.Visibility = Visibility.Hidden;
                scroll_brand.Visibility = Visibility.Hidden;
                label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            }
            else if (label_open_brand.Background != null)
            {
                gride_brand.Visibility = Visibility.Visible;
                gride_product.Visibility = Visibility.Hidden;
                gride_category.Visibility = Visibility.Hidden;
                scroll_brand.Visibility = Visibility.Visible;
                scroll_product.Visibility = Visibility.Hidden;
                scroll_category.Visibility = Visibility.Hidden;



                label_open_brand.Background = null;
                border_open_brand.Background = null;

                label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                

            }

            
        }

        //3
        private void label_open_category_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            label_open_category.Effect = effect;
            border_open_category.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
        }

        private void label_open_category_MouseLeave(object sender, MouseEventArgs e)
        {
            label_open_category.Effect = null;
            border_open_category.Effect = null;
        }

        private void label_open_category_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (label_open_category.Background == null)
            {
                gride_category.Visibility = Visibility.Hidden;
                scroll_category.Visibility = Visibility.Hidden;
                label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            }
            else if (label_open_category.Background != null)
            {
                gride_category.Visibility = Visibility.Visible;
                gride_brand.Visibility = Visibility.Hidden;
                gride_product.Visibility = Visibility.Hidden;
                scroll_category.Visibility = Visibility.Visible;
                scroll_brand.Visibility = Visibility.Hidden;
                scroll_product.Visibility = Visibility.Hidden;

                label_open_category.Background = null;
                border_open_category.Background = null;

                label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));


            }
        }


        //-------------------------------- gride 3 type product brand catogary componants inside it ---------------------------------------------------

        //-----------------------------------------------------------1-product----------------------------------------

        private void gride_product_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (gride_product.Visibility==Visibility.Visible)
            {
                try
                {
                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by product_name asc) as 'RowNumber', products.product_id,product_name,brands.brand_name , categories.category_name,model_year,list_price from production.products join production.brands on products.brand_id= brands.brand_id join production.categories on products.category_id= categories.category_id   ", conn);
                    tab_product.Clear();
                    adb.Fill(tab_product);
                    griddata_all_product.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_product.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_product.ItemsSource = tab_product.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }





                int count_1 = 0;
                double[] valuesss = new double[5];
                string[] labelsss = new string[5];
                command.CommandText = "select top 4 category_name , count(product_name) as 'num' from production.categories join production.products on categories.category_id = products.category_id  group by category_name order by num desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        labelsss[count_1] = reader["category_name"].ToString();
                        valuesss[count_1] = double.Parse(reader["num"].ToString());

                        count_1++;

                    }
                    reader.Close();
                }
                command.CommandText = "WITH sum_num AS (select top 4 category_name , count(product_name) as 'num' from production.categories join production.products on categories.category_id = products.category_id  group by category_name order by num desc) select(select count(*) from production.products ) - (select sum(num) from sum_num) as 'result_sub' ";
                reader = command.ExecuteReader();
                reader.Read();
                labelsss[count_1] = "Other";
                valuesss[count_1] = double.Parse(reader["result_sub"].ToString());
                reader.Close();

                wpf_product_1.Plot.Clear();
                var chartsss = wpf_product_1.Plot.AddPie(valuesss, hideGridAndFrame: true);
                chartsss.ShowPercentages = true;
                chartsss.SliceLabels = labelsss;
                wpf_product_1.Plot.Legend(location: Alignment.UpperRight);
                chartsss.SliceLabelPosition = 0.6;
                chartsss.Size = 0.6;
                chartsss.SliceLabelColors = chartsss.SliceFillColors;
                chartsss.SliceFont.Size = 13;
                wpf_product_1.Configuration.LeftClickDragPan = false;
                wpf_product_1.Configuration.RightClickDragZoom = false;
                wpf_product_1.Configuration.ScrollWheelZoom = false;
                wpf_product_1.Refresh();




                int count_2 = 0;
                string[] xaxis = new string[5];
                double[] valuess = new double[5];
                double[] positionsss = { 0, 1, 2, 3, 4 };
                command.CommandText = "select top 4 brand_name , count(product_name) as 'num' from production.brands join production.products on brands.brand_id = products.brand_id group by brand_name order by num desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        xaxis[count_2] = reader["brand_name"].ToString();
                        valuess[count_2] = double.Parse(reader["num"].ToString());

                        count_2++;


                    }
                    reader.Close();
                }
                command.CommandText = "WITH sum_num AS (select top 4 brand_name , count(product_name) as 'num' from production.brands join production.products on brands.brand_id = products.brand_id group by brand_name order by num desc) select(select count(*) from production.products ) - (select sum(num) from sum_num) as 'result_sub'";
                reader = command.ExecuteReader();
                reader.Read();
                xaxis[count_2] = "Other";
                valuess[count_2] = double.Parse(reader["result_sub"].ToString());
                reader.Close();

                wpf_product_2.Plot.Clear();
                wpf_product_2.Plot.XTicks(positionsss, xaxis);
                var chartss = wpf_product_2.Plot.AddBar(valuess, positionsss, System.Drawing.Color.DarkSlateBlue);
                wpf_product_2.Plot.SetAxisLimits(yMin: 0);
                chartss.ShowValuesAboveBars = true;
                chartss.Font.Color = System.Drawing.Color.Black;
                wpf_product_2.Plot.Title("Num Of Products for Brand ");
                wpf_product_2.Plot.YLabel(" Num Of Products ");
                wpf_product_2.Plot.XLabel(" Name Of Brand ");
                chartss.Font.Size = 15;
                chartss.Font.Bold = true;
                wpf_product_2.Plot.XAxis.TickLabelStyle(rotation: 0, fontSize: 12);
                wpf_product_2.Configuration.LeftClickDragPan = false;
                wpf_product_2.Configuration.RightClickDragZoom = false;
                wpf_product_2.Configuration.ScrollWheelZoom = false;
                wpf_product_2.Plot.Grid(false);
                wpf_product_2.Refresh();
            }
          
        }

        //-----------------------------------------------------------2-saels----------------------------------------

        private void label_load_report_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_load_report.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_load_report_MouseLeave(object sender, MouseEventArgs e)
        {
            border_load_report.Effect = null;
        }

        private void label_load_report_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(datapiker_from_saels.SelectedDate.ToString()) == false && string.IsNullOrWhiteSpace(datapiker_to_saels.SelectedDate.ToString()) == false && datapiker_from_saels.SelectedDate<=datapiker_to_saels.SelectedDate)
            {
                try
                {
                    adb.SelectCommand = new SqlCommand($" select ROW_NUMBER() over(order by product_name asc) as 'RowNumber', product_name, sum(quantity) as'quantity',CONVERt(decimal(6,3),(convert(decimal,sum(quantity))/convert(decimal,(select SUM(quantity) from sales.order_items  join sales.orders on orders.order_id=order_items.order_id where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}')))*100) as 'sales_percentage', sum(order_items.total_mount) as 'sum_money'  from production.products join sales.order_items on products.product_id =order_items.product_id join sales.orders on orders.order_id= order_items.order_id where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}'  group by product_name  ", conn);
                    tab_saels.Clear();
                    adb.Fill(tab_saels);
                    griddata_all_brand.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_brand.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_brand.ItemsSource = tab_saels.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }






                //1
                int count_1 = 0;
                int rownum_1 = 0;
                command.CommandText = $"select top 4 category_name , sum(quantity) as 'num'  from production.categories join production.products on categories.category_id =products.category_id join sales.order_items on products.product_id= order_items.product_id join sales.orders on orders.order_id =order_items.order_id where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}'  group by category_name order by sum(quantity) desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_1++;
                    }
                    reader.Close();
                }
                double[] valuesss = null;
                string[] labelsss = null;
                if (rownum_1 == 0)
                {
                    valuesss = new double[1];
                    labelsss = new string[1];
                    valuesss[0] = 0;
                    labelsss[0] = "Non";
                }
                else if (rownum_1 >= 1)
                {
                    valuesss = new double[rownum_1 + 1];
                    labelsss = new string[rownum_1 + 1];

                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            labelsss[count_1] = reader["category_name"].ToString();
                            valuesss[count_1] = double.Parse(reader["num"].ToString());

                            count_1++;
                        }
                        reader.Close();
                    }
                    command.CommandText = $"WITH sum_num AS (select top 4 category_name , sum(quantity) as 'num'  from production.categories join production.products on categories.category_id =products.category_id join sales.order_items on products.product_id= order_items.product_id join sales.orders on orders.order_id =order_items.order_id where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}'  group by category_name order by sum(quantity) desc) select(select SUM(quantity) from sales.order_items join sales.orders on order_items.order_id =orders.order_id where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}'  ) - (select sum(num) from sum_num) as 'result_sub' ";
                    reader = command.ExecuteReader();
                    reader.Read();
                    labelsss[count_1] = "Other";
                    valuesss[count_1] = double.Parse(reader["result_sub"].ToString());
                    reader.Close();
                }
               

                wpf_brand_1.Plot.Clear();
                var chartsss = wpf_brand_1.Plot.AddPie(valuesss, hideGridAndFrame: true);
                chartsss.ShowPercentages = true;
                chartsss.SliceLabels = labelsss;
                wpf_brand_1.Plot.Legend(location: Alignment.UpperRight);
                chartsss.SliceLabelPosition = 0.6;
                chartsss.Size = 0.6;
                chartsss.SliceLabelColors = chartsss.SliceFillColors;
                chartsss.SliceFont.Size = 13;
                wpf_brand_1.Configuration.LeftClickDragPan = false;
                wpf_brand_1.Configuration.RightClickDragZoom = false;
                wpf_brand_1.Configuration.ScrollWheelZoom = false;
                wpf_brand_1.Refresh();







                //2
                int count_2 = 0;
                int rownum_2 = 0;
                command.CommandText = $"select top 4 brand_name , sum(quantity) as 'num'  from production.brands join production.products on brands.brand_id =products.brand_id join sales.order_items on products.product_id= order_items.product_id join sales.orders on orders.order_id =order_items.order_id where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}'  group by brand_name order by sum(quantity) desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_2++;
                    }
                    reader.Close();
                }
                double[] valuess = null;
                string[] xaxiss = null;
                double[] positionsss = null;
                if (rownum_2 == 0)
                {
                    valuess = new double[1];
                    xaxiss = new string[1];
                    positionsss = new double[1];
                    valuess[0] = 0;
                    xaxiss[0] = "Non";
                }
                else if (rownum_2 >= 1)
                {
                    valuess = new double[rownum_2 + 1];
                    xaxiss = new string[rownum_2 + 1];
                    positionsss = new double[rownum_2 + 1];

                    using (reader = command.ExecuteReader())
                    {
                        positionsss[0] = 0;
                        while (reader.Read())
                        {

                            xaxiss[count_2] = reader["brand_name"].ToString();
                            valuess[count_2] = double.Parse(reader["num"].ToString());
                            positionsss[0 + count_2 + 1] = count_2 + 1;


                            count_2++;
                        }
                        reader.Close();
                    }
                    command.CommandText = $"WITH sum_num AS (select top 4 brand_name , sum(quantity) as 'num'  from production.brands join production.products on brands.brand_id =products.brand_id join sales.order_items on products.product_id= order_items.product_id join sales.orders on orders.order_id =order_items.order_id where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}'  group by brand_name order by sum(quantity) desc) select(select SUM(quantity) from sales.order_items join sales.orders on order_items.order_id =orders.order_id where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}'  ) - (select sum(num) from sum_num) as 'result_sub'";
                    reader = command.ExecuteReader();
                    reader.Read();
                    xaxiss[count_2] = "Other";
                    valuess[count_2] = double.Parse(reader["result_sub"].ToString());
                    reader.Close();
                }
               

                wpf_brand_2.Plot.Clear();
                wpf_brand_2.Plot.XTicks(positionsss, xaxiss);
                var chartss = wpf_brand_2.Plot.AddBar(valuess, positionsss, System.Drawing.Color.Goldenrod);
                wpf_brand_2.Plot.SetAxisLimits(yMin: 0);
                chartss.ShowValuesAboveBars = true;
                chartss.Font.Color = System.Drawing.Color.Black;
                wpf_brand_2.Plot.Title("The Products Sold For Brand");
                wpf_brand_2.Plot.YLabel(" Count Of Products Sold ");
                wpf_brand_2.Plot.XLabel(" Name Of Brand ");
                chartss.Font.Size = 15;
                chartss.Font.Bold = true;
                wpf_brand_2.Plot.XAxis.TickLabelStyle(rotation: 0, fontSize: 10);
                wpf_brand_2.Configuration.LeftClickDragPan = false;
                wpf_brand_2.Configuration.RightClickDragZoom = false;
                wpf_brand_2.Configuration.ScrollWheelZoom = false;
                wpf_brand_2.Plot.Grid(false);
                wpf_brand_2.Refresh();






                //3
                int year_from = datapiker_from_saels.SelectedDate.Value.Year;
                int year_to = datapiker_to_saels.SelectedDate.Value.Year;
                int month_from = datapiker_from_saels.SelectedDate.Value.Month;
                int month_to = datapiker_to_saels.SelectedDate.Value.Month;

                string part_date = null;
                string ramz_money = null;
                int elqesma = 0;

                if (year_from == year_to)
                {
                    if (month_from == month_to)
                    {
                        part_date = "Day";
                        ramz_money = "$";
                        elqesma = 1;
                    }
                    else if (month_from != month_to)
                    {
                        part_date = "Month";
                        ramz_money = "$K";
                        elqesma = 1000;

                    }
                }
                else if (year_from != year_to)
                {
                    part_date = "Year";
                    ramz_money = "$K";
                    elqesma = 1000;
                }



                int count_3 = 0;
                int rownum_3 = 0;
                command.CommandText = $"select  DATEPART({part_date},order_date)  as 'xaxis' , SUM(total_mount) as 'num' from sales.orders where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}' group by  DATEPART({part_date},order_date) order by 'xaxis' asc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_3++;
                    }
                    reader.Close();
                }
                double[] values = null;
                string[] xaxis = null;
                double[] positions = null;
                if (rownum_3 == 0)
                {
                    values = new double[1];
                    xaxis = new string[1];
                    positions = new double[1];
                    values[0] = 0;
                    xaxis[0] = "Non";
                    positions[0] = 0;
                }
                else if (rownum_3 >= 1)
                {
                    values = new double[rownum_3];
                    xaxis = new string[rownum_3];
                    positions = new double[rownum_3];

                    using (reader = command.ExecuteReader())
                    {

                        positions[0] = 0;
                        while (reader.Read())
                        {

                            xaxis[count_3] = reader["xaxis"].ToString();
                            values[count_3] = double.Parse(reader["num"].ToString()) / elqesma;
                            positions[0 + count_3] = count_3;


                            count_3++;
                        }
                        reader.Close();
                    }
                    if (rownum_3 >= 1)
                    {
                        xaxis[0] = datapiker_from_saels.SelectedDate.Value.Month.ToString() + "/" + datapiker_from_saels.SelectedDate.Value.Day.ToString() + "/" + datapiker_from_saels.SelectedDate.Value.Year.ToString();
                        xaxis[count_3 - 1] = datapiker_to_saels.SelectedDate.Value.Month.ToString() + "/" + datapiker_to_saels.SelectedDate.Value.Day.ToString() + "/" + datapiker_to_saels.SelectedDate.Value.Year.ToString();

                    }

                    wpf_brand_3.Plot.SetAxisLimitsY(0, values.Max() * 1.2);

                }


                wpf_brand_3.Plot.Clear();
                wpf_brand_3.Plot.XAxis.ManualTickPositions(positions, xaxis);
                var charts = wpf_brand_3.Plot.AddScatter(positions, values, color: System.Drawing.Color.Green);
                wpf_brand_3.Plot.XAxis.TickLabelStyle(rotation: 45);
                wpf_brand_3.Plot.Title($"Saels For {part_date}");
                wpf_brand_3.Plot.XLabel($"{part_date}");
                wpf_brand_3.Plot.YLabel($"Saels({ramz_money})");
                charts.MarkerSize = 5;
                wpf_brand_3.Configuration.LeftClickDragPan = false;
                wpf_brand_3.Configuration.RightClickDragZoom = false;
                wpf_brand_3.Configuration.ScrollWheelZoom = false;
                wpf_brand_3.Plot.Grid(false);
                wpf_brand_3.Refresh();






                //4
                int count_4 = 0;
                int rownum_4 = 0;
                command.CommandText = $"select  DATEPART({part_date},order_date)  as 'xaxis_2' , count(order_id) as 'num' from sales.orders where order_date between '{datapiker_from_saels.SelectedDate}' and '{datapiker_to_saels.SelectedDate}' group by  DATEPART({part_date},order_date) order by 'xaxis_2' asc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_4++;
                    }
                    reader.Close();
                }
                double[] values_2 = null;
                string[] xaxis_2 = null;
                double[] positions_2 = null;
                if (rownum_4 == 0)
                {
                    values_2 = new double[1];
                    xaxis_2 = new string[1];
                    positions_2 = new double[1];
                    values_2[0] = 0;
                    xaxis_2[0] = "Non";
                    positions_2[0] = 0;
                }
                else if (rownum_4 >= 1)
                {
                    values_2 = new double[rownum_4];
                    xaxis_2 = new string[rownum_4];
                    positions_2 = new double[rownum_4];

                    using (reader = command.ExecuteReader())
                    {

                        positions_2[0] = 0;
                        while (reader.Read())
                        {

                            xaxis_2[count_4] = reader["xaxis_2"].ToString();
                            values_2[count_4] = double.Parse(reader["num"].ToString());
                            positions_2[0 + count_4] = count_4;


                            count_4++;
                        }
                        reader.Close();
                    }
                    if (rownum_4 >= 1)
                    {
                        xaxis_2[0] = datapiker_from_saels.SelectedDate.Value.Month.ToString() + "/" + datapiker_from_saels.SelectedDate.Value.Day.ToString() + "/" + datapiker_from_saels.SelectedDate.Value.Year.ToString();
                        xaxis_2[count_4 - 1] = datapiker_to_saels.SelectedDate.Value.Month.ToString() + "/" + datapiker_to_saels.SelectedDate.Value.Day.ToString() + "/" + datapiker_to_saels.SelectedDate.Value.Year.ToString();

                    }

                    wpf_brand_4.Plot.SetAxisLimitsY(0, values_2.Max() * 1.2);


                }


                wpf_brand_4.Plot.Clear();
                wpf_brand_4.Plot.XAxis.ManualTickPositions(positions_2, xaxis_2);
                var charts_2 = wpf_brand_4.Plot.AddScatter(positions_2, values_2, color: System.Drawing.Color.SlateGray);
                wpf_brand_4.Plot.XAxis.TickLabelStyle(rotation: 45);
                wpf_brand_4.Plot.Title($"Orders For {part_date}");
                wpf_brand_4.Plot.XLabel($"{part_date}");
                wpf_brand_4.Plot.YLabel("Orders");
                charts_2.MarkerSize = 5;
                wpf_brand_4.Configuration.LeftClickDragPan = false;
                wpf_brand_4.Configuration.RightClickDragZoom = false;
                wpf_brand_4.Configuration.ScrollWheelZoom = false;
                wpf_brand_4.Plot.Grid(false);
                wpf_brand_4.Refresh();
            }
            else if (string.IsNullOrWhiteSpace(datapiker_from_saels.SelectedDate.ToString()) == true || string.IsNullOrWhiteSpace(datapiker_to_saels.SelectedDate.ToString()) == true)
            {
                MessageBox.Show("Please enter date for Date Picker");
            }
            else if(datapiker_from_saels.SelectedDate > datapiker_to_saels.SelectedDate)
            {
                MessageBox.Show("Please enter the date correct, Make the From date picker less than To date picker ");
            }
        }

        private void gride_brand_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (griddata_all_brand.Visibility == Visibility.Visible)
            {

                command.CommandText = "select top 1 order_date from sales.orders order by order_date asc";
                reader = command.ExecuteReader();
                reader.Read();
                DateTime.TryParse(reader["order_date"].ToString(), out DateTime firstdate);
                reader.Close();
                datapiker_from_saels.SelectedDate = firstdate;

                command.CommandText = "select top 1 order_date from sales.orders order by order_date desc";
                reader = command.ExecuteReader();
                reader.Read();
                DateTime.TryParse(reader["order_date"].ToString(), out DateTime lastdate);
                reader.Close();
                datapiker_to_saels.SelectedDate = lastdate;

                datapiker_from_saels.DisplayDateStart = firstdate;
                datapiker_from_saels.DisplayDateEnd = lastdate;
                datapiker_to_saels.DisplayDateStart = firstdate;
                datapiker_to_saels.DisplayDateEnd = lastdate;


                try
                {
                    adb.SelectCommand = new SqlCommand($" select ROW_NUMBER() over(order by product_name asc) as 'RowNumber', product_name, sum(quantity) as'quantity',CONVERt(decimal(6,3),(convert(decimal,sum(quantity))/convert(decimal,(select SUM(quantity) from sales.order_items  join sales.orders on orders.order_id=order_items.order_id where order_date between '{firstdate}' and '{lastdate}')))*100) as 'sales_percentage', sum(order_items.total_mount) as 'sum_money'  from production.products join sales.order_items on products.product_id =order_items.product_id join sales.orders on orders.order_id= order_items.order_id where order_date between '{firstdate}' and '{lastdate}'  group by product_name  ", conn);
                    tab_saels.Clear();
                    adb.Fill(tab_saels);
                    griddata_all_brand.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_brand.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_brand.ItemsSource = tab_saels.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }






                //1
                int count_1 = 0;
                int rownum_1 = 0;
                command.CommandText = $"select top 4 category_name , sum(quantity) as 'num'  from production.categories join production.products on categories.category_id =products.category_id join sales.order_items on products.product_id= order_items.product_id join sales.orders on orders.order_id =order_items.order_id where order_date between '{firstdate}' and '{lastdate}'  group by category_name order by sum(quantity) desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_1++;
                    }
                    reader.Close();
                }
                double[] valuesss = null;
                string[] labelsss = null;
                if (rownum_1 == 0)
                {
                    valuesss = new double[1];
                    labelsss = new string[1];
                    valuesss[0] = 0;
                    labelsss[0] = "Non";
                }
                else if (rownum_1 >= 1)
                {
                    valuesss = new double[rownum_1 + 1];
                    labelsss = new string[rownum_1 + 1];

                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            labelsss[count_1] = reader["category_name"].ToString();
                            valuesss[count_1] = double.Parse(reader["num"].ToString());

                            count_1++;
                        }
                        reader.Close();
                    }
                    command.CommandText = $"WITH sum_num AS (select top 4 category_name , sum(quantity) as 'num'  from production.categories join production.products on categories.category_id =products.category_id join sales.order_items on products.product_id= order_items.product_id join sales.orders on orders.order_id =order_items.order_id where order_date between '{firstdate}' and '{lastdate}'  group by category_name order by sum(quantity) desc) select(select SUM(quantity) from sales.order_items join sales.orders on order_items.order_id =orders.order_id where order_date between '{firstdate}' and '{lastdate}'  ) - (select sum(num) from sum_num) as 'result_sub' ";
                    reader = command.ExecuteReader();
                    reader.Read();
                    labelsss[count_1] = "Other";
                    valuesss[count_1] = double.Parse(reader["result_sub"].ToString());
                    reader.Close();

                }
                

                wpf_brand_1.Plot.Clear();
                var chartsss = wpf_brand_1.Plot.AddPie(valuesss, hideGridAndFrame: true);
                chartsss.ShowPercentages = true;
                chartsss.SliceLabels = labelsss;
                wpf_brand_1.Plot.Legend(location: Alignment.UpperRight);
                chartsss.SliceLabelPosition = 0.6;
                chartsss.Size = 0.6;
                chartsss.SliceLabelColors = chartsss.SliceFillColors;
                chartsss.SliceFont.Size = 13;
                wpf_brand_1.Configuration.LeftClickDragPan = false;
                wpf_brand_1.Configuration.RightClickDragZoom = false;
                wpf_brand_1.Configuration.ScrollWheelZoom = false;
                wpf_brand_1.Refresh();







               //2
                int count_2 = 0;
                int rownum_2 = 0;
                command.CommandText = $"select top 4 brand_name , sum(quantity) as 'num'  from production.brands join production.products on brands.brand_id =products.brand_id join sales.order_items on products.product_id= order_items.product_id join sales.orders on orders.order_id =order_items.order_id where order_date between '{firstdate}' and '{lastdate}'  group by brand_name order by sum(quantity) desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_2++;
                    }
                    reader.Close();
                }
                double[] valuess = null;
                string[] xaxiss = null;
                double[] positionsss = null;
                if (rownum_2 == 0)
                {
                    valuess = new double[1];
                    xaxiss = new string[1];
                    positionsss = new double[1];
                    valuess[0] = 0;
                    xaxiss[0] = "Non";
                }
                else if (rownum_2 >= 1)
                {
                    valuess = new double[rownum_2 + 1];
                    xaxiss = new string[rownum_2 + 1];
                    positionsss = new double[rownum_2+1];

                    using (reader = command.ExecuteReader())
                    {
                        positionsss[0] = 0;
                        while (reader.Read())
                        {

                            xaxiss[count_2] = reader["brand_name"].ToString();
                            valuess[count_2] = double.Parse(reader["num"].ToString());
                            positionsss[0 + count_2 + 1] = count_2 + 1;


                            count_2++;
                        }
                        reader.Close();
                    }
                    command.CommandText = $"WITH sum_num AS (select top 4 brand_name , sum(quantity) as 'num'  from production.brands join production.products on brands.brand_id =products.brand_id join sales.order_items on products.product_id= order_items.product_id join sales.orders on orders.order_id =order_items.order_id where order_date between '{firstdate}' and '{lastdate}'  group by brand_name order by sum(quantity) desc) select(select SUM(quantity) from sales.order_items join sales.orders on order_items.order_id =orders.order_id where order_date between '{firstdate}' and '{lastdate}'  ) - (select sum(num) from sum_num) as 'result_sub'";
                    reader = command.ExecuteReader();
                    reader.Read();
                    xaxiss[count_2] = "Other";
                    valuess[count_2] = double.Parse(reader["result_sub"].ToString());
                    reader.Close();


                }

                wpf_brand_2.Plot.Clear();
                wpf_brand_2.Plot.XTicks(positionsss, xaxiss);
                var chartss = wpf_brand_2.Plot.AddBar(valuess, positionsss, System.Drawing.Color.Goldenrod);
                wpf_brand_2.Plot.SetAxisLimits(yMin: 0);
                chartss.ShowValuesAboveBars = true;
                chartss.Font.Color = System.Drawing.Color.Black;
                wpf_brand_2.Plot.Title("The Products Sold For Brand");
                wpf_brand_2.Plot.YLabel(" Count Of Products Sold ");
                wpf_brand_2.Plot.XLabel(" Name Of Brand ");
                chartss.Font.Size = 15;
                chartss.Font.Bold = true;
                wpf_brand_2.Plot.XAxis.TickLabelStyle(rotation: 0, fontSize: 10);
                wpf_brand_2.Configuration.LeftClickDragPan = false;
                wpf_brand_2.Configuration.RightClickDragZoom = false;
                wpf_brand_2.Configuration.ScrollWheelZoom = false;
                wpf_brand_2.Plot.Grid(false);
                wpf_brand_2.Refresh();






                //3
               int year_from= datapiker_from_saels.SelectedDate.Value.Year;
               int year_to = datapiker_to_saels.SelectedDate.Value.Year;
               int month_from = datapiker_from_saels.SelectedDate.Value.Month;
               int month_to = datapiker_to_saels.SelectedDate.Value.Month;

                string part_date = null;
                string ramz_money = null;
                int elqesma = 0;

                if(year_from == year_to)
                {
                    if (month_from == month_to)
                    {
                        part_date = "Day";
                        ramz_money = "$";
                        elqesma = 1;
                    }
                    else if (month_from != month_to)
                    {
                        part_date = "Month";
                        ramz_money = "$K";
                        elqesma = 1000;

                    }
                }
                else if (year_from!= year_to)
                {
                    part_date = "Year";
                    ramz_money = "$K";
                    elqesma = 1000;
                }



                int count_3 = 0;
                int rownum_3 = 0;
                command.CommandText = $"select  DATEPART({part_date},order_date)  as 'xaxis' , SUM(total_mount) as 'num' from sales.orders where order_date between '{firstdate}' and '{lastdate}' group by  DATEPART({part_date},order_date) order by 'xaxis' asc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_3++;
                    }
                    reader.Close();
                }
                double[] values = null;
                string[] xaxis = null;
                double[] positions = null;
                if (rownum_3 == 0)
                {
                    values = new double[1];
                    xaxis = new string[1];
                    positions = new double[1];
                    values[0] = 0;
                    xaxis[0] = "Non";
                    positions[0] = 0;
                }
                else if (rownum_3 >= 1)
                {
                    values = new double[rownum_3 ];
                    xaxis = new string[rownum_3 ];
                    positions = new double[rownum_3 ];

                    using (reader = command.ExecuteReader())
                    {

                        positions[0] = 0;
                        while (reader.Read())
                        {

                            xaxis[count_3] = reader["xaxis"].ToString();
                            values[count_3] = double.Parse(reader["num"].ToString()) / elqesma;
                            positions[0 + count_3] = count_3;


                            count_3++;
                        }
                        reader.Close();
                    }
                    if (rownum_3 >= 1)
                    {
                        xaxis[0] = datapiker_from_saels.SelectedDate.Value.Month.ToString() + "/" + datapiker_from_saels.SelectedDate.Value.Day.ToString() + "/" + datapiker_from_saels.SelectedDate.Value.Year.ToString();
                        xaxis[count_3 - 1] = datapiker_to_saels.SelectedDate.Value.Month.ToString() + "/" + datapiker_to_saels.SelectedDate.Value.Day.ToString() + "/" + datapiker_to_saels.SelectedDate.Value.Year.ToString();

                    }

                    wpf_brand_3.Plot.SetAxisLimitsY(0, values.Max() * 1.2);

                }


                wpf_brand_3.Plot.Clear();
                wpf_brand_3.Plot.XAxis.ManualTickPositions(positions, xaxis);
                var charts = wpf_brand_3.Plot.AddScatter(positions, values, color: System.Drawing.Color.Green);
                wpf_brand_3.Plot.XAxis.TickLabelStyle(rotation: 45);
                wpf_brand_3.Plot.Title($"Saels For {part_date}");
                wpf_brand_3.Plot.XLabel($"{part_date}");
                wpf_brand_3.Plot.YLabel($"Saels({ramz_money})");
                charts.MarkerSize = 5;
                wpf_brand_3.Configuration.LeftClickDragPan = false;
                wpf_brand_3.Configuration.RightClickDragZoom = false;
                wpf_brand_3.Configuration.ScrollWheelZoom = false;
                wpf_brand_3.Plot.Grid(false);
                wpf_brand_3.Refresh();






               //4
                int count_4 = 0;
                int rownum_4 = 0;
                command.CommandText = $"select  DATEPART({part_date},order_date)  as 'xaxis_2' , count(order_id) as 'num' from sales.orders where order_date between '{firstdate}' and '{lastdate}' group by  DATEPART({part_date},order_date) order by 'xaxis_2' asc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_4++;
                    }
                    reader.Close();
                }
                double[] values_2 = null;
                string[] xaxis_2 = null;
                double[] positions_2 = null;
                if (rownum_4 == 0)
                {
                    values_2 = new double[1];
                    xaxis_2 = new string[1];
                    positions_2 = new double[1];
                    values_2[0] = 0;
                    xaxis_2[0] = "Non";
                    positions_2[0] = 0;
                }
                else if (rownum_4 >= 1)
                {
                    values_2 = new double[rownum_4];
                    xaxis_2 = new string[rownum_4];
                    positions_2 = new double[rownum_4];

                    using (reader = command.ExecuteReader())
                    {

                        positions_2[0] = 0;
                        while (reader.Read())
                        {

                            xaxis_2[count_4] = reader["xaxis_2"].ToString();
                            values_2[count_4] = double.Parse(reader["num"].ToString());
                            positions_2[0 + count_4] = count_4;


                            count_4++;
                        }
                        reader.Close();
                    }
                    if (rownum_4 >= 1)
                    {
                        xaxis_2[0] = datapiker_from_saels.SelectedDate.Value.Month.ToString() + "/" + datapiker_from_saels.SelectedDate.Value.Day.ToString() + "/" + datapiker_from_saels.SelectedDate.Value.Year.ToString();
                        xaxis_2[count_4 - 1] = datapiker_to_saels.SelectedDate.Value.Month.ToString() + "/" + datapiker_to_saels.SelectedDate.Value.Day.ToString() + "/" + datapiker_to_saels.SelectedDate.Value.Year.ToString();

                    }

                    wpf_brand_4.Plot.SetAxisLimitsY(0, values_2.Max() * 1.2);

                }


                wpf_brand_4.Plot.Clear();
                wpf_brand_4.Plot.XAxis.ManualTickPositions(positions_2, xaxis_2);
                var charts_2 = wpf_brand_4.Plot.AddScatter(positions_2, values_2, color: System.Drawing.Color.SlateGray);
                wpf_brand_4.Plot.XAxis.TickLabelStyle(rotation: 45);
                wpf_brand_4.Plot.Title($"Orders For {part_date}");
                wpf_brand_4.Plot.XLabel($"{part_date}");
                wpf_brand_4.Plot.YLabel("Orders");
                charts_2.MarkerSize = 5;
                wpf_brand_4.Configuration.LeftClickDragPan = false;
                wpf_brand_4.Configuration.RightClickDragZoom = false;
                wpf_brand_4.Configuration.ScrollWheelZoom = false;
                wpf_brand_4.Plot.Grid(false);
                wpf_brand_4.Refresh();
            }
        }


        //-----------------------------------------------------------3-customer----------------------------------------

        private void label_load_report_2_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_load_report_2.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_load_report_2_MouseLeave(object sender, MouseEventArgs e)
        {
            border_load_report_2.Effect = null;

        }

        private void label_load_report_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(datapiker_from_customer.SelectedDate.ToString()) == false && string.IsNullOrWhiteSpace(datapiker_to_customer.SelectedDate.ToString()) == false && datapiker_from_customer.SelectedDate <= datapiker_to_customer.SelectedDate)
            {
                try
                {
                    adb.SelectCommand = new SqlCommand($" select ROW_NUMBER() over(order by first_name + last_name  asc) as 'RowNumber', first_name,last_name,city,state,count(orders.customer_id) as 'count_order' ,SUM(total_mount) as 'sum_money' from sales.customers join sales.orders on customers.customer_id=orders.customer_id where order_date between '{datapiker_from_customer.SelectedDate}' and '{datapiker_to_customer.SelectedDate}' group by first_name,last_name,city,state   ", conn);
                    tab_customer.Clear();
                    adb.Fill(tab_customer);
                    griddata_all_category.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_category.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_category.ItemsSource = tab_customer.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                int count_1 = 0;
                int rownum_1 = 0;
                command.CommandText = $"select top 5 city , count(city) as 'num' from sales.customers join sales.orders on customers.customer_id = orders.customer_id where order_date between '{datapiker_from_customer.SelectedDate}' and '{datapiker_to_customer.SelectedDate}'  group by city order by num desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_1++;
                    }
                    reader.Close();
                }
                double[] valuesss = null;
                string[] labelsss = null;
                if (rownum_1 == 0)
                {
                    valuesss = new double[1];
                    labelsss = new string[1];
                    valuesss[0] = 0;
                    labelsss[0] = "Non";
                }
                else if (rownum_1 >= 1)
                {
                    valuesss = new double[rownum_1];
                    labelsss = new string[rownum_1];

                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            labelsss[count_1] = reader["city"].ToString();
                            valuesss[count_1] = double.Parse(reader["num"].ToString());

                            count_1++;
                        }
                        reader.Close();
                    }

                }
               

                wpf_category_1.Plot.Clear();
                var chartsss = wpf_category_1.Plot.AddPie(valuesss, hideGridAndFrame: true);
                chartsss.ShowPercentages = true;
                chartsss.SliceLabels = labelsss;
                wpf_category_1.Plot.Legend(location: Alignment.UpperRight);
                chartsss.SliceLabelPosition = 0.6;
                chartsss.Size = 0.6;
                chartsss.SliceLabelColors = chartsss.SliceFillColors;
                chartsss.SliceFont.Size = 13;
                wpf_category_1.Configuration.LeftClickDragPan = false;
                wpf_category_1.Configuration.RightClickDragZoom = false;
                wpf_category_1.Configuration.ScrollWheelZoom = false;
                chartsss.Explode = true;
                wpf_category_1.Refresh();




                int count_2 = 0;
                int rownum_2 = 0;
                command.CommandText = $"select top 4 state , count(state) as 'num' from sales.customers join sales.orders on customers.customer_id = orders.customer_id  where order_date between '{datapiker_from_customer.SelectedDate}' and '{datapiker_to_customer.SelectedDate}' group by state order by num desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_2++;
                    }
                    reader.Close();
                }
                double[] valuessss = null;
                string[] labelssss = null;
                if (rownum_2 == 0)
                {
                    valuessss = new double[1];
                    labelssss = new string[1];
                    valuessss[0] = 0;
                    labelssss[0] = "Non";
                }
                else if (rownum_2 >= 1)
                {
                    valuessss = new double[rownum_2 + 1];
                    labelssss = new string[rownum_2 + 1];

                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            labelssss[count_2] = reader["state"].ToString();
                            valuessss[count_2] = double.Parse(reader["num"].ToString());

                            count_2++;
                        }
                        reader.Close();
                    }


                    command.CommandText = $"WITH sum_num AS (select top 4 state , count(state) as 'num' from sales.customers join sales.orders on customers.customer_id = orders.customer_id where order_date between '{datapiker_from_customer.SelectedDate}' and '{datapiker_to_customer.SelectedDate}'  group by state order by num desc) select(select count(*) from sales.orders  where order_date between '{datapiker_from_customer.SelectedDate}' and '{datapiker_to_customer.SelectedDate}' ) - (select sum(num) from sum_num) as 'result_sub' ";
                    reader = command.ExecuteReader();
                    reader.Read();
                    labelssss[count_2] = "Other";
                    valuessss[count_2] = double.Parse(reader["result_sub"].ToString());
                    reader.Close();

                }
                

                wpf_category_2.Plot.Clear();
                var chartssss = wpf_category_2.Plot.AddPie(valuessss, hideGridAndFrame: true);
                chartssss.ShowPercentages = true;
                chartssss.SliceLabels = labelssss;
                wpf_category_2.Plot.Legend(location: Alignment.UpperRight);
                chartssss.SliceLabelPosition = 0.6;
                chartssss.Size = 0.6;
                chartssss.SliceLabelColors = chartssss.SliceFillColors;
                chartssss.SliceFont.Size = 13;
                chartssss.DonutSize = 0;
                chartssss.Explode = false;
                wpf_category_2.Configuration.LeftClickDragPan = false;
                wpf_category_2.Configuration.RightClickDragZoom = false;
                wpf_category_2.Configuration.ScrollWheelZoom = false;
                wpf_category_2.Refresh();


            }
            else if (string.IsNullOrWhiteSpace(datapiker_from_customer.SelectedDate.ToString()) == true || string.IsNullOrWhiteSpace(datapiker_to_customer.SelectedDate.ToString()) == true)
            {
                MessageBox.Show("Please enter date for Date Picker");
            }
            else if (datapiker_from_customer.SelectedDate > datapiker_to_customer.SelectedDate)
            {
                MessageBox.Show("Please enter the date correct, Make the From date picker less than To date picker ");
            }
        }

        private void gride_category_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (griddata_all_brand.Visibility == Visibility.Visible)
            {
                command.CommandText = "select top 1 order_date from sales.orders order by order_date asc";
                reader = command.ExecuteReader();
                reader.Read();
                DateTime.TryParse(reader["order_date"].ToString(), out DateTime firstdate);
                reader.Close();
                datapiker_from_customer.SelectedDate = firstdate;

                command.CommandText = "select top 1 order_date from sales.orders order by order_date desc";
                reader = command.ExecuteReader();
                reader.Read();
                DateTime.TryParse(reader["order_date"].ToString(), out DateTime lastdate);
                reader.Close();
                datapiker_to_customer.SelectedDate = lastdate;

                datapiker_from_customer.DisplayDateStart = firstdate;
                datapiker_from_customer.DisplayDateEnd = lastdate;
                datapiker_to_customer.DisplayDateStart = firstdate;
                datapiker_to_customer.DisplayDateEnd = lastdate;



                try
                {
                    adb.SelectCommand = new SqlCommand($" select ROW_NUMBER() over(order by first_name + last_name  asc) as 'RowNumber', first_name,last_name,city,state,count(orders.customer_id) as 'count_order' ,SUM(total_mount) as 'sum_money' from sales.customers join sales.orders on customers.customer_id=orders.customer_id where order_date between '{firstdate}' and '{lastdate}' group by first_name,last_name,city,state   ", conn);
                    tab_customer.Clear();
                    adb.Fill(tab_customer);
                    griddata_all_category.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_category.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_category.ItemsSource = tab_customer.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                int count_1 = 0;
                int rownum_1 = 0;
                command.CommandText = $"select top 5 city , count(city) as 'num' from sales.customers join sales.orders on customers.customer_id = orders.customer_id  where order_date between '{firstdate}' and '{lastdate}'  group by city order by num desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_1++;
                    }
                    reader.Close();
                }
                double[] valuesss=null;
                string[] labelsss=null;
                if (rownum_1 == 0)
                {
                    valuesss = new double[1];
                    labelsss = new string[1];
                    valuesss[0] = 0;
                    labelsss[0] = "Non";
                }
                else if (rownum_1 >= 1)
                {
                    valuesss = new double[rownum_1];
                    labelsss = new string[rownum_1];

                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            labelsss[count_1] = reader["city"].ToString();
                            valuesss[count_1] = double.Parse(reader["num"].ToString());

                            count_1++;
                        }
                        reader.Close();
                    }

                }
                

                wpf_category_1.Plot.Clear();
                var chartsss = wpf_category_1.Plot.AddPie(valuesss, hideGridAndFrame: true);
                chartsss.ShowPercentages = true;
                chartsss.SliceLabels = labelsss;
                wpf_category_1.Plot.Legend(location: Alignment.UpperRight);
                chartsss.SliceLabelPosition = 0.6;
                chartsss.Size = 0.6;
                chartsss.SliceLabelColors = chartsss.SliceFillColors;
                chartsss.SliceFont.Size = 13;
                wpf_category_1.Configuration.LeftClickDragPan = false;
                wpf_category_1.Configuration.RightClickDragZoom = false;
                wpf_category_1.Configuration.ScrollWheelZoom = false; 
                chartsss.Explode = true;
                wpf_category_1.Refresh();




                int count_2 = 0;
                int rownum_2 = 0;
                command.CommandText = $"select top 4 state , count(state) as 'num' from sales.customers join sales.orders on customers.customer_id = orders.customer_id  where order_date between '{firstdate}' and '{lastdate}' group by state order by num desc";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rownum_2++;
                    }
                    reader.Close();
                }
                double[] valuessss = null;
                string[] labelssss = null;
                if (rownum_2 == 0)
                {
                    valuessss = new double[1];
                    labelssss = new string[1];
                    valuessss[0] = 0;
                    labelssss[0] = "Non";
                }
                else if (rownum_2 >= 1)
                {
                    valuessss = new double[rownum_2+1];
                    labelssss = new string[rownum_2+1];

                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            labelssss[count_2] = reader["state"].ToString();
                            valuessss[count_2] = double.Parse(reader["num"].ToString());

                            count_2++;
                        }
                        reader.Close();
                    }

                    command.CommandText = $"WITH sum_num AS (select top 4 state , count(state) as 'num' from sales.customers join sales.orders on customers.customer_id = orders.customer_id where order_date between '{firstdate}' and '{lastdate}'  group by state order by num desc) select(select count(*) from sales.orders where order_date between '{firstdate}' and '{lastdate}'  ) - (select sum(num) from sum_num) as 'result_sub' ";
                    reader = command.ExecuteReader();
                    reader.Read();
                    labelssss[count_2] = "Other";
                    valuessss[count_2] = double.Parse(reader["result_sub"].ToString());
                    reader.Close();

                }
               

                wpf_category_2.Plot.Clear();
                var chartssss = wpf_category_2.Plot.AddPie(valuessss, hideGridAndFrame: true);
                chartssss.ShowPercentages = true;
                chartssss.SliceLabels = labelssss;
                wpf_category_2.Plot.Legend(location: Alignment.UpperRight);
                chartssss.SliceLabelPosition = 0.6;
                chartssss.Size = 0.6;
                chartssss.SliceLabelColors = chartssss.SliceFillColors;
                chartssss.SliceFont.Size = 13;
                chartssss.DonutSize = 0;
                chartssss.Explode = false;
                wpf_category_2.Configuration.LeftClickDragPan = false;
                wpf_category_2.Configuration.RightClickDragZoom = false;
                wpf_category_2.Configuration.ScrollWheelZoom = false;
                wpf_category_2.Refresh();


            }
        }

      
    }
}
