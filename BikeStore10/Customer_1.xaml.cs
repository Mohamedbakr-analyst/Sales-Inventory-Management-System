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
    /// Interaction logic for Customer_1.xaml
    /// </summary>
    public partial class Customer_1 : Window
    {

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_44330760199;Integrated Security=True");
        //  SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_2;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter adb = new SqlDataAdapter();
        DataTable tab_grideall = new DataTable();
        DataTable tab_textcity = new DataTable();
        DataTable tab_textstate = new DataTable();


        public Customer_1()
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            text_name_user.Content = TextReference.StoredText;
            image_user.Source = TextReference.StoredBitmapImage;
        }



        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            InputLanguageManager.Current.CurrentInputLanguage = CultureInfo.GetCultureInfo("en-US");
            if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.U))
            {
                if (griddata_all_customer.IsReadOnly == true)
                {
                    griddata_all_customer.IsReadOnly = false;
                    MessageBox.Show("Allows editing data");
                }
                else if (griddata_all_customer.IsReadOnly == false)
                {
                    griddata_all_customer.IsReadOnly = true;
                    MessageBox.Show("Does not allow editing data");

                }

            }
            else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.A))
            {
                label_add_customer_MouseLeftButtonDown(sender, null);
            }
            else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.C))
            {
                label_cancel_customer_MouseLeftButtonDown(sender, null);
            }
            else if (e.KeyboardDevice.IsKeyDown(Key.OemQuotes))
            {
                e.Handled=true;
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
           
        }

        private void image_menu_4_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            
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



//-------------------------------------------------Change--------------------------------------------------

        //---------------------------------------Text box search product-------------------------------------

        private void textbox_search_customer_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_customer.Effect = effectbo;
            effectbo.ShadowDepth = 1;
            textbox_search_customer.BorderThickness = new Thickness(0);
        }

        private void textbox_search_customer_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_customer.Effect = null;

        }

        private void label_search_customer_1_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_customer.Effect = effectbo;
            effectbo.ShadowDepth = 1;
        }

        private void label_search_customer_1_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_customer.Effect = null;

        }

        private void textbox_search_customer_TextChanged(object sender, TextChangedEventArgs e)
        {
            label_search_customer.Visibility = Visibility.Hidden;

            if (textbox_search_customer.Text == null || textbox_search_customer.Text == "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by customer_id asc) as 'RowNumber', customer_id,first_name,last_name,phone,email,city,state from sales.customers", conn);
                    tab_grideall.Clear();
                    adb.Fill(tab_grideall);
                   
                    griddata_all_customer.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_customer.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_customer.ItemsSource = tab_grideall.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (textbox_search_customer.Text != null || textbox_search_customer.Text != "")
            {

                try
                {
                    adb.SelectCommand = new SqlCommand($" select ROW_NUMBER() over(order by first_name +' '+ last_name  asc) as 'RowNumber', customer_id,first_name,last_name,phone,email,city,state from sales.customers where first_name+' '+last_name  Like '{textbox_search_customer.Text}%' ", conn);
                    tab_grideall.Clear();
                    adb.Fill(tab_grideall);
                    griddata_all_customer.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_customer.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_customer.ItemsSource = tab_grideall.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

        }

        private void textbox_search_customer_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox_search_customer.Text == " " || textbox_search_customer.Text == "")
            {
                label_search_customer.Visibility = Visibility.Visible;

            }
        }

        //---------------------------------------Text box entery customer-------------------------------------

        private void Textbox_enter_productname_customer_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_productname_customer.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF); ;
        }

        private void Textbox_enter_brandname_customer_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_brandname_customer.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_catogaryname_customer_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_catogaryname_customer.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_modelyear_customer_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_modelyear_customer.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_price_customer_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_price_customer.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_price_customer_2_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_price_customer_2.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_productname_customer_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_productname_customer.Effect = null;

        }
        private void Textbox_enter_productname_customer_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                Textbox_enter_catogaryname_customer.Focus();
            }
            else if (Textbox_enter_productname_customer.SelectionStart>= Textbox_enter_productname_customer.Text.Length)
            {
                if (e.Key == Key.Right)
                {
                    Textbox_enter_brandname_customer.Focus();

                }
            }
           
        }

        private void Textbox_enter_brandname_customer_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_brandname_customer.Effect = null;

        }
        private void Textbox_enter_brandname_customer_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                Textbox_enter_catogaryname_customer.Focus();           
            }
            else if (Textbox_enter_brandname_customer.SelectionStart==0)
            {
                if (e.Key == Key.Left)
                {
                    Textbox_enter_productname_customer.Focus();
                }
            }
           
        }

        private void Textbox_enter_catogaryname_customer_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_catogaryname_customer.Effect = null;

        }

        private void Textbox_enter_catogaryname_customer_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                Textbox_enter_modelyear_customer.Focus();       
            }
            else if (e.Key == Key.Up)
            {
                Textbox_enter_productname_customer.Focus();           
            }
        }
        private void Textbox_enter_catogaryname_customer_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Length > 0)
            {
                if (char.IsDigit(e.Text, 0) == false && e.Text != "+" && e.Text != "(" && e.Text != ")" && e.Text != "-")
                {
                    e.Handled = true;
                }
            }


        }

        private void Textbox_enter_modelyear_customer_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_modelyear_customer.Effect = null;
        }


        private void Textbox_enter_modelyear_customer_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                Textbox_enter_price_customer.Focus();
            }
            else if(e.Key== Key.Up)
            {
                Textbox_enter_catogaryname_customer.Focus();
            }
        }

        private void Textbox_enter_price_customer_LostFocus(object sender, RoutedEventArgs e)
        {
            
            Textbox_enter_price_customer.Effect = null;
            griddata_brandname_customer.Visibility = Visibility.Hidden;

            Textbox_enter_price_customer.Height = 36;
            Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;
        }

        private void Textbox_enter_price_customer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Textbox_enter_price_customer.Text == null || Textbox_enter_price_customer.Text == "")
            {
                griddata_brandname_customer.Visibility = Visibility.Hidden;
                Textbox_enter_price_customer.Height = 36;
                Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;

            }
            else if (Textbox_enter_price_customer.Text != null || Textbox_enter_price_customer.Text != "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand($" select distinct top 5  city from sales.customers where city like '{Textbox_enter_price_customer.Text}%' order by city asc ", conn);

                    tab_textcity.Clear();
                    adb.Fill(tab_textcity);
                    griddata_brandname_customer.ItemsSource = tab_textcity.DefaultView;
                    griddata_brandname_customer.Visibility = Visibility.Visible;

                    Textbox_enter_price_customer.Height = 165;
                    Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Top;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void Textbox_enter_price_customer_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (griddata_brandname_customer.Visibility == Visibility)
            {


                if (e.Key == Key.Down)
                {

                    if (griddata_brandname_customer.SelectedIndex >= -1 && griddata_brandname_customer.SelectedIndex <= 3)
                    {
                        griddata_brandname_customer.SelectedIndex = griddata_brandname_customer.SelectedIndex + 1;
                    }
                    else if (griddata_brandname_customer.SelectedIndex == 4)
                    {
                        griddata_brandname_customer.SelectedIndex = 0;
                    }

                }
                else if (e.Key == Key.Up)
                {
                    if (griddata_brandname_customer.SelectedIndex <= 4 && griddata_brandname_customer.SelectedIndex >= 1)
                    {
                        griddata_brandname_customer.SelectedIndex = griddata_brandname_customer.SelectedIndex - 1;
                    }
                    else if (griddata_brandname_customer.SelectedIndex == 0)
                    {
                        griddata_brandname_customer.SelectedIndex = 4;
                    }

                }
                else if (e.Key == Key.Enter)
                {
                    int x = griddata_brandname_customer.SelectedIndex;
                    if (x >= 0)
                    {
                        var cellValue = griddata_brandname_customer.Items[x] as DataRowView;


                        string value = cellValue[0].ToString();

                        Textbox_enter_price_customer.Text = value;
                        Textbox_enter_price_customer.SelectionStart = value.Length;
                        griddata_brandname_customer.Visibility = Visibility.Hidden;

                        Textbox_enter_price_customer.Height = 36;
                        Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;

                    }

                }
                else if (e.Key == Key.Escape)
                {
                    griddata_brandname_customer.Visibility = Visibility.Hidden;

                    Textbox_enter_price_customer.Height = 36;
                    Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;

                }
            }
            else if (griddata_brandname_customer.Visibility == Visibility.Hidden)
            {
                if (e.Key == Key.Up)
                {
                    Textbox_enter_modelyear_customer.Focus();
                }
                else if (e.Key== Key.Down)
                {
                    Textbox_enter_price_customer_2.Focus();
                }
            }
        }

        private void Textbox_enter_price_customer_2_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_price_customer_2.Effect = null;
            griddata_catogaryname_customer.Visibility = Visibility.Hidden;

            Textbox_enter_price_customer_2.Height = 36;
            Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;

        }

        private void Textbox_enter_price_customer_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Textbox_enter_price_customer_2.Text == null || Textbox_enter_price_customer_2.Text == "")
            {
                griddata_catogaryname_customer.Visibility = Visibility.Hidden;
                Textbox_enter_price_customer_2.Height = 36;
                Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;

            }
            else if (Textbox_enter_price_customer_2.Text != null || Textbox_enter_price_customer_2.Text != "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand($" select distinct top 5  state from sales.customers where state like '{Textbox_enter_price_customer_2.Text}%' order by state asc ", conn);
                    tab_textstate.Clear();
                    adb.Fill(tab_textstate);
                    griddata_catogaryname_customer.ItemsSource = tab_textstate.DefaultView;
                    griddata_catogaryname_customer.Visibility = Visibility.Visible;

                    Textbox_enter_price_customer_2.Height = 165;
                    Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Top;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void Textbox_enter_price_customer_2_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (griddata_catogaryname_customer.Visibility == Visibility)
            {

                if (e.Key == Key.Down)
                {
                    if (griddata_catogaryname_customer.SelectedIndex >= -1 && griddata_catogaryname_customer.SelectedIndex <= 3)
                    {
                        griddata_catogaryname_customer.SelectedIndex = griddata_catogaryname_customer.SelectedIndex + 1;
                    }
                    else if (griddata_catogaryname_customer.SelectedIndex == 4)
                    {
                        griddata_catogaryname_customer.SelectedIndex = 0;
                    }

                }
                else if (e.Key == Key.Up)
                {
                    if (griddata_catogaryname_customer.SelectedIndex <= 4 && griddata_catogaryname_customer.SelectedIndex >= 1)
                    {
                        griddata_catogaryname_customer.SelectedIndex = griddata_catogaryname_customer.SelectedIndex - 1;
                    }
                    else if (griddata_catogaryname_customer.SelectedIndex == 0)
                    {
                        griddata_catogaryname_customer.SelectedIndex = 4;
                    }

                }
                else if (e.Key == Key.Enter)
                {
                    int x = griddata_catogaryname_customer.SelectedIndex;
                    if (x >= 0)
                    {
                        var cellValue = griddata_catogaryname_customer.Items[x] as DataRowView;


                        string value = cellValue[0].ToString();

                        Textbox_enter_price_customer_2.Text = value;
                        Textbox_enter_price_customer_2.SelectionStart = value.Length;
                        griddata_catogaryname_customer.Visibility = Visibility.Hidden;

                        Textbox_enter_price_customer_2.Height = 36;
                        Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;

                    }

                }
                else if (e.Key == Key.Escape)
                {
                    griddata_catogaryname_customer.Visibility = Visibility.Hidden;

                    Textbox_enter_price_customer_2.Height = 36;
                    Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;

                }
                
            }
            else if(griddata_catogaryname_customer.Visibility == Visibility.Hidden)
            {
                if (e.Key == Key.Up)
                {
                    Textbox_enter_price_customer.Focus();
                }
            }
        }

       


        //---------------------------------------Button add,cancel brand-------------------------------------

        private void label_add_customer_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_add_customer.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_cancel_customer_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_cancel_customer.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_add_customer_MouseLeave(object sender, MouseEventArgs e)
        {
            border_add_customer.Effect = null;

        }
        private void label_add_customer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Textbox_enter_productname_customer.Text)== false && string.IsNullOrWhiteSpace(Textbox_enter_brandname_customer.Text) == false && string.IsNullOrWhiteSpace(Textbox_enter_modelyear_customer.Text) == false && string.IsNullOrWhiteSpace(Textbox_enter_price_customer.Text) == false && string.IsNullOrWhiteSpace(Textbox_enter_price_customer_2.Text) == false  )
            {
                int num_row = 0;
                command.CommandText = $"select first_name+last_name  from sales.customers where first_name+last_name ='{Textbox_enter_productname_customer.Text+Textbox_enter_brandname_customer.Text}'";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        num_row++;

                    }
                    reader.Close();
                }

                if (string.IsNullOrWhiteSpace(Textbox_enter_catogaryname_customer.Text) == false)
                {   
                    var answer = MessageBox.Show("Are you sure add new row ", "Warning", MessageBoxButton.YesNo);
                    if (answer == MessageBoxResult.Yes)
                    {
                        if (num_row == 0)
                        {
                            adb.SelectCommand = new SqlCommand($" insert into sales.customers(first_name,last_name,phone,email,city,state) values('{Textbox_enter_productname_customer.Text}','{Textbox_enter_brandname_customer.Text}','{Textbox_enter_catogaryname_customer.Text}','{Textbox_enter_modelyear_customer.Text}','{Textbox_enter_price_customer.Text}','{Textbox_enter_price_customer_2.Text}')", conn);
                            adb.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Added successfully");

                            adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by customer_id desc) as 'RowNumber', customer_id,first_name,last_name,phone,email,city,state from sales.customers ", conn);
                            tab_grideall.Clear();
                            adb.Fill(tab_grideall);
                            griddata_all_customer.Items.SortDescriptions.Clear();
                            foreach (var column in griddata_all_customer.Columns)
                            {
                                column.SortDirection = null;
                            }
                            griddata_all_customer.ItemsSource = tab_grideall.DefaultView;

                            Textbox_enter_productname_customer.Text = null;
                            Textbox_enter_brandname_customer.Text = null;
                            Textbox_enter_catogaryname_customer.Text = null;
                            Textbox_enter_modelyear_customer.Text = null;
                            Textbox_enter_price_customer.Text = null;
                            Textbox_enter_price_customer_2.Text = null;

                        }

                        else if (num_row >= 1)
                        {
                            MessageBox.Show("Sorry, Faild add new row, The name is in the data, Change the name and try again ");
                        }

                    }
                    else if (answer == MessageBoxResult.No)
                    {
                        MessageBox.Show("Canceled successfully");
                        Textbox_enter_productname_customer.Text = null;
                        Textbox_enter_brandname_customer.Text = null;
                        Textbox_enter_catogaryname_customer.Text = null;
                        Textbox_enter_modelyear_customer.Text = null;
                        Textbox_enter_price_customer.Text = null;
                        Textbox_enter_price_customer_2.Text = null;
                    }
                }
                else if (string.IsNullOrWhiteSpace(Textbox_enter_catogaryname_customer.Text) == true)
                {
                    var answer = MessageBox.Show("Are you sure add new row ", "Warning", MessageBoxButton.YesNo);
                    if (answer == MessageBoxResult.Yes)
                    {
                        if (num_row == 0)
                        {
                            adb.SelectCommand = new SqlCommand($" insert into sales.customers(first_name,last_name,phone,email,city,state) values('{Textbox_enter_productname_customer.Text}','{Textbox_enter_brandname_customer.Text}',null,'{Textbox_enter_modelyear_customer.Text}','{Textbox_enter_price_customer.Text}','{Textbox_enter_price_customer_2.Text}')", conn);
                            adb.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Added successfully");

                            adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by customer_id desc) as 'RowNumber', customer_id,first_name,last_name,phone,email,city,state from sales.customers ", conn);
                            tab_grideall.Clear();
                            adb.Fill(tab_grideall);
                            griddata_all_customer.Items.SortDescriptions.Clear();
                            foreach (var column in griddata_all_customer.Columns)
                            {
                                column.SortDirection = null;
                            }
                            griddata_all_customer.ItemsSource = tab_grideall.DefaultView;

                            Textbox_enter_productname_customer.Text = null;
                            Textbox_enter_brandname_customer.Text = null;
                            Textbox_enter_catogaryname_customer.Text = null;
                            Textbox_enter_modelyear_customer.Text = null;
                            Textbox_enter_price_customer.Text = null;
                            Textbox_enter_price_customer_2.Text = null;
                        }
                        else if (num_row >= 1)
                        {
                            MessageBox.Show("Sorry, Faild add new row, The name is in the data, Change the name and try again ");
                        }

                    }
                    else if (answer == MessageBoxResult.No)
                    {
                        MessageBox.Show("Canceled successfully");
                        Textbox_enter_productname_customer.Text = null;
                        Textbox_enter_brandname_customer.Text = null;
                        Textbox_enter_catogaryname_customer.Text = null;
                        Textbox_enter_modelyear_customer.Text = null;
                        Textbox_enter_price_customer.Text = null;
                        Textbox_enter_price_customer_2.Text = null;
                    }
                }
               
            }
            else if (string.IsNullOrWhiteSpace(Textbox_enter_productname_customer.Text) == true || string.IsNullOrWhiteSpace(Textbox_enter_brandname_customer.Text) == true || string.IsNullOrWhiteSpace(Textbox_enter_modelyear_customer.Text) == true || string.IsNullOrWhiteSpace(Textbox_enter_price_customer.Text) == true || string.IsNullOrWhiteSpace(Textbox_enter_price_customer_2.Text) == true)
            {
                MessageBox.Show("Sorry, Faild add new row, Please check first name,last name,email,city and state its must have text");
            }
        }

        private void label_cancel_customer_MouseLeave(object sender, MouseEventArgs e)
        {
            border_cancel_customer.Effect = null;

        }
        private void label_cancel_customer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textbox_enter_productname_customer.Text = null;
            Textbox_enter_brandname_customer.Text = null;
            Textbox_enter_catogaryname_customer.Text = null;
            Textbox_enter_modelyear_customer.Text = null;
            Textbox_enter_price_customer.Text = null;
            Textbox_enter_price_customer_2.Text = null;
        }


        //--------------------------------------------------------gridedat-all_customer ---------------------------


        string namepinding="";
        private void griddata_all_customer_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            namepinding = griddata_all_customer.CurrentCell.Column.SortMemberPath;
            var textBox_2 = e.EditingElement as TextBox;
            textBox_2.Text = "";

            if (textBox_2 != null)
            {
                textBox_2.TextChanged += TextBox_2TextChanged1;
                textBox_2.PreviewKeyDown += textBox_2privew;
                textBox_2.LostFocus += textBox_2lostfocus;
                textBox_2.PreviewTextInput += textBox_2textinput;
            }
        }
        private void TextBox_2TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBox textBox_2 = sender as TextBox;

            if (namepinding == "city")
            {
                if (textBox_2.Text == null || textBox_2.Text == "")
                {
                    griddata_brandname_customer.Visibility = Visibility.Hidden;

                    Textbox_enter_price_customer.Height = 36;
                    Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;
                    Textbox_enter_price_customer.Effect = null;

                }
                else if (textBox_2.Text != null || textBox_2.Text != "")
                {
                    try
                    {


                        adb.SelectCommand = new SqlCommand($"select distinct top 5  city from sales.customers where city like '{textBox_2.Text}%' order by city asc  ", conn);
                        tab_textcity.Clear();
                        adb.Fill(tab_textcity);
                        griddata_brandname_customer.ItemsSource = tab_textcity.DefaultView;
                        griddata_brandname_customer.Visibility = Visibility.Visible;

                        Textbox_enter_price_customer.Height = 165;
                        Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Top;
                        System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
                        Textbox_enter_price_customer.Effect = effect;
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
            else if (namepinding == "state")
            {
                if (textBox_2.Text == null || textBox_2.Text == "")
                {
                    griddata_catogaryname_customer.Visibility = Visibility.Hidden;

                    Textbox_enter_price_customer_2.Height = 36;
                    Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;
                    Textbox_enter_price_customer_2.Effect = null;

                }
                else if (textBox_2.Text != null || textBox_2.Text != "")
                {
                    try
                    {


                        adb.SelectCommand = new SqlCommand($"select distinct top 5  state from sales.customers where state like '{textBox_2.Text}%' order by state asc  ", conn);
                        tab_textstate.Clear();
                        adb.Fill(tab_textstate);
                        griddata_catogaryname_customer.ItemsSource = tab_textstate.DefaultView;
                        griddata_catogaryname_customer.Visibility = Visibility.Visible;

                        Textbox_enter_price_customer_2.Height = 165;
                        Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Top;
                        System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
                        Textbox_enter_price_customer_2.Effect = effect;
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

        bool key_enter_text_cell_customer = false;
        private void textBox_2privew(object sender, KeyEventArgs e)
        {
            TextBox textBox_2 = sender as TextBox;
            if (namepinding == "city")
            {
                if (griddata_brandname_customer.Visibility == Visibility)
                {


                    if (e.Key == Key.Down)
                    {

                        if (griddata_brandname_customer.SelectedIndex >= -1 && griddata_brandname_customer.SelectedIndex <= 3)
                        {
                            griddata_brandname_customer.SelectedIndex = griddata_brandname_customer.SelectedIndex + 1;
                        }
                        else if (griddata_brandname_customer.SelectedIndex == 4)
                        {
                            griddata_brandname_customer.SelectedIndex = 0;
                        }

                    }
                    else if (e.Key == Key.Up)
                    {
                        if (griddata_brandname_customer.SelectedIndex <= 4 && griddata_brandname_customer.SelectedIndex >= 1)
                        {
                            griddata_brandname_customer.SelectedIndex = griddata_brandname_customer.SelectedIndex - 1;
                        }
                        else if (griddata_brandname_customer.SelectedIndex == 0)
                        {
                            griddata_brandname_customer.SelectedIndex = 4;
                        }

                    }
                    else if (e.Key == Key.Enter)
                    {
                        int x = griddata_brandname_customer.SelectedIndex;
                        if (x >= 0)
                        {
                            var cellValue = griddata_brandname_customer.Items[x] as DataRowView;


                            string value = cellValue[0].ToString();

                            textBox_2.Text = value;
                            griddata_brandname_customer.Visibility = Visibility.Hidden;

                            Textbox_enter_price_customer.Height = 36;
                            Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;
                            Textbox_enter_price_customer.Effect = null;


                        }

                    }
                    
                }
                
            }
            else if (namepinding == "state")
            {
                if (griddata_catogaryname_customer.Visibility == Visibility)
                {


                    if (e.Key == Key.Down)
                    {

                        if (griddata_catogaryname_customer.SelectedIndex >= -1 && griddata_catogaryname_customer.SelectedIndex <= 3)
                        {
                            griddata_catogaryname_customer.SelectedIndex = griddata_catogaryname_customer.SelectedIndex + 1;
                        }
                        else if (griddata_catogaryname_customer.SelectedIndex == 4)
                        {
                            griddata_catogaryname_customer.SelectedIndex = 0;
                        }

                    }
                    else if (e.Key == Key.Up)
                    {
                        if (griddata_catogaryname_customer.SelectedIndex <= 4 && griddata_catogaryname_customer.SelectedIndex >= 1)
                        {
                            griddata_catogaryname_customer.SelectedIndex = griddata_catogaryname_customer.SelectedIndex - 1;
                        }
                        else if (griddata_catogaryname_customer.SelectedIndex == 0)
                        {
                            griddata_catogaryname_customer.SelectedIndex = 4;
                        }

                    }
                    else if (e.Key == Key.Enter)
                    {
                        int x = griddata_catogaryname_customer.SelectedIndex;
                        if (x >= 0)
                        {
                            var cellValue = griddata_catogaryname_customer.Items[x] as DataRowView;


                            string value = cellValue[0].ToString();

                            textBox_2.Text = value;
                            griddata_catogaryname_customer.Visibility = Visibility.Hidden;

                            Textbox_enter_price_customer_2.Height = 36;
                            Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;
                            Textbox_enter_price_customer_2.Effect = null;


                        }

                    }

                }
            }

            if (e.Key == Key.Enter)
            {
                key_enter_text_cell_customer = true;
            }
        }

        private void textBox_2lostfocus(object sender, RoutedEventArgs e)
        {
            if (namepinding == "city")
            {
                TextBox textBox_2 = sender as TextBox;

                griddata_brandname_customer.Visibility = Visibility.Hidden;

                Textbox_enter_price_customer.Height = 36;
                Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_price_customer.Effect = null;
            }
            else  if (namepinding == "state")
            {
                TextBox textBox_2 = sender as TextBox;

                griddata_catogaryname_customer.Visibility = Visibility.Hidden;

                Textbox_enter_price_customer_2.Height = 36;
                Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_price_customer_2.Effect = null;
            }

        }

        private void textBox_2textinput(object sender, TextCompositionEventArgs e)
        {
            if (namepinding == "phone")
            {
                if (e.Text.Length > 0)
                {
                    if (char.IsDigit(e.Text, 0) == false && e.Text != "+" && e.Text != "(" && e.Text != ")" && e.Text != "-")
                    {
                        e.Handled = true;
                    }
                }
            }

        }

        private void griddata_all_customer_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_customer == true)
            {
                if (griddata_all_customer.CurrentCell.Column != null)
                {
                    var namepinding = griddata_all_customer.CurrentCell.Column.SortMemberPath ;
                    var headercoulmn = griddata_all_customer.CurrentCell.Column.Header ;
                    var indexcoulmn = griddata_all_customer.CurrentCell.Column.DisplayIndex;
                    var cellInfo = griddata_all_customer.SelectedCells[indexcoulmn] ;
                    string content = cellInfo.Column.GetCellContent(cellInfo.Item).ToString();
                    string value=null;
                    if (content.Length >= 34)
                    {
                         value= content.Substring(33, content.Length - 33);
                    }
                    else if (content.Length == 31)
                    {
                        value = null;
                    }

                    int numberofindex = griddata_all_customer.SelectedIndex;
                    var cellValue = griddata_all_customer.Items[numberofindex] as DataRowView;
                    string value_id = "";
                    value_id = cellValue[1].ToString();
                    

                   
                    if (string.IsNullOrWhiteSpace(value)==false && namepinding.ToString()!= "RowNumber")
                    {
                        int num_row = 0;
                        if (namepinding == "first_name")
                        {
                            command.CommandText = $"select * from sales.customers where first_name+last_name='{value}'+(select last_name from sales.customers where customer_id ={value_id})";
                            using (reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    num_row++;

                                }
                                reader.Close();
                            }

                        }
                        else if (namepinding == "last_name")
                        {
                            command.CommandText = $"select * from sales.customers where first_name+last_name=(select first_name from sales.customers where customer_id={value_id})+'{value}'";
                            using (reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    num_row++;

                                }
                                reader.Close();
                            }

                        }

                        var answer = MessageBox.Show("Are you sure that the " + headercoulmn.ToString() + " has changed to " + value, "Warning", MessageBoxButton.YesNo);
                        if (answer == MessageBoxResult.Yes)
                        {
                            if (num_row == 0)
                            {
                                adb.SelectCommand = new SqlCommand($" update sales.customers set {namepinding.ToString()} = '{value}' where customer_id = {value_id}", conn);
                                adb.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Changes have been applied successfully");




                                griddata_brandname_customer.Visibility = Visibility.Hidden;
                                griddata_catogaryname_customer.Visibility = Visibility.Hidden;

                                Textbox_enter_price_customer_2.Height = 36;
                                Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;
                                Textbox_enter_price_customer_2.Effect = null;

                                Textbox_enter_price_customer.Height = 36;
                                Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;
                                Textbox_enter_price_customer.Effect = null;
                            }
                            else if (num_row >= 1)
                            {
                                griddata_all_customer.CancelEdit();
                                MessageBox.Show("Sorry, The name is in the data");
                            }



                        }
                        else if (answer == MessageBoxResult.No)
                        {
                            griddata_all_customer.CancelEdit();
                            MessageBox.Show("Changes have been canceled successfully");

                            griddata_brandname_customer.Visibility = Visibility.Hidden;
                            griddata_catogaryname_customer.Visibility = Visibility.Hidden;

                            Textbox_enter_price_customer_2.Height = 36;
                            Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;
                            Textbox_enter_price_customer_2.Effect = null;

                            Textbox_enter_price_customer.Height = 36;
                            Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;
                            Textbox_enter_price_customer.Effect = null;


                        }
                    }

                    else if (namepinding.ToString() == "RowNumber")
                    {
                        MessageBox.Show("Sorry, You can't change value this coulmn");
                        griddata_all_customer.CancelEdit();


                    }

                    else if (string.IsNullOrWhiteSpace(value) == true && (namepinding.ToString() == "first_name" || namepinding.ToString() == "last_name" || namepinding.ToString() == "email" || namepinding.ToString() == "state" || namepinding.ToString() == "city"))
                    {
                        MessageBox.Show("Sorry, Please Enter Text");
                        griddata_all_customer.CancelEdit();

                    }

                    else if (string.IsNullOrWhiteSpace(value) == true &&  namepinding.ToString() == "phone")
                    {
                        var answer = MessageBox.Show("Are you sure that the " + headercoulmn.ToString() + " has changed " + "is null", "Warning", MessageBoxButton.YesNo);
                        if (answer == MessageBoxResult.Yes)
                        {
                            adb.SelectCommand = new SqlCommand($" update sales.customers set {namepinding.ToString()} = null where customer_id = {value_id}", conn);
                            adb.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Changes have been applied successfully");


                        }
                        else if (answer == MessageBoxResult.No)
                        {
                            griddata_all_customer.CancelEdit();
                            MessageBox.Show("Changes have been canceled successfully");


                        }

                    }

                }

                else
                {
                    griddata_all_customer.CancelEdit();
                    griddata_all_customer.SelectedItem = null;

                    griddata_brandname_customer.Visibility = Visibility.Hidden;
                    griddata_catogaryname_customer.Visibility = Visibility.Hidden;

                    Textbox_enter_price_customer_2.Height = 36;
                    Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;
                    Textbox_enter_price_customer_2.Effect = null;

                    Textbox_enter_price_customer.Height = 36;
                    Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;
                    Textbox_enter_price_customer.Effect = null;
                }

                key_enter_text_cell_customer = false;
            }

            else if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_customer == false)
            {
                griddata_all_customer.CancelEdit();

                griddata_brandname_customer.Visibility = Visibility.Hidden;
                griddata_catogaryname_customer.Visibility = Visibility.Hidden;

                Textbox_enter_price_customer_2.Height = 36;
                Textbox_enter_price_customer_2.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_price_customer_2.Effect = null;

                Textbox_enter_price_customer.Height = 36;
                Textbox_enter_price_customer.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_price_customer.Effect = null;
            }
        }



        private void gride_customer_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by  customer_id asc) as 'RowNumber', customer_id,first_name,last_name,phone,email,city,state from sales.customers ", conn);
                tab_grideall.Clear();
                adb.Fill(tab_grideall);
                griddata_all_customer.Items.SortDescriptions.Clear();
                foreach (var column in griddata_all_customer.Columns)
                {
                    column.SortDirection = null;
                }
                griddata_all_customer.ItemsSource = tab_grideall.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gride_notification_MouseEnter(object sender, MouseEventArgs e)
        {

        }

       
    }
}
