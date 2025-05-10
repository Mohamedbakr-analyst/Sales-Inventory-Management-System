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
using Microsoft.Win32;
using System.IO;
using System.Drawing;



namespace BikeStore10
{
    /// <summary>
    /// Interaction logic for User_1.xaml
    /// </summary>
    public partial class User_1 : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_44330760199;Integrated Security=True");

        //  SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_2;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter adb = new SqlDataAdapter();
        DataTable tab_user = new DataTable();

        public User_1()
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


        private void text_name_user_Loaded(object sender, RoutedEventArgs e)
        {
            text_name_user.Content = TextReference.StoredText;
            image_user.Source = TextReference.StoredBitmapImage;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            conn.Close();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            InputLanguageManager.Current.CurrentInputLanguage = CultureInfo.GetCultureInfo("en-US");

            if (gride_stock.Visibility==Visibility.Visible)
            {
                if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.A))
                {
                    label_add_user_MouseLeftButtonDown(sender, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.C))
                {
                    label_cancel_user_MouseLeftButtonDown(sender, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.U))
                {
                    if (griddata_all_stock.IsReadOnly == true)
                    {
                        griddata_all_stock.IsReadOnly = false;
                        MessageBox.Show("Allows editing data");
                    }
                    else if (griddata_all_stock.IsReadOnly == false)
                    {
                        griddata_all_stock.IsReadOnly = true;
                        MessageBox.Show("Does not allow editing data");

                    }
                }
            }
             
            if (e.KeyboardDevice.IsKeyDown(Key.OemQuotes))
            {
                e.Handled = true;
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
           
        }

        private void image_menu_6_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
          
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


        //--------------------------------------- 1-Sign in---------------------------------------------------

        //---------------------------------------Text box entery user-------------------------------------


        private void Textbox_enter_productname_signin_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_productname_signin.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = System.Windows.Media.Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_brandname_signin_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_brandname_signin.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = System.Windows.Media.Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_productname_signin_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_productname_signin.Effect = null;

        }

        private void Textbox_enter_brandname_signin_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_brandname_signin.Effect = null;

        }

        private void gride_user_signin_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                if (Textbox_enter_productname_signin.IsFocused == true)
                {
                    Textbox_enter_brandname_signin.Focus();
                }
            }




            else if (e.Key == Key.Up)
            {
                if (Textbox_enter_brandname_signin.IsFocused == true)
                {
                    Textbox_enter_productname_signin.Focus();
                }
            }

            else if (e.Key == Key.Enter)
            {
                if (Textbox_enter_productname_signin.IsFocused == true)
                {
                    Textbox_enter_brandname_signin.Focus();
                }

                else  if (Textbox_enter_brandname_signin.IsFocused == true)
                {
                    label_add_saels_user_signin_MouseLeftButtonDown(null, null);
                }
            }
        }



        //---------------------------------------Button sign in user-------------------------------------

        private void label_add_saels_user_signin_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_add_user_signin.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_add_saels_user_signin_MouseLeave(object sender, MouseEventArgs e)
        {
            border_add_user_signin.Effect = null;

        }

        private void label_add_saels_user_signin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int num_row_username = 0;
            command.CommandText = $"select * from sales.add_user where user_name =@va_1 and acceas = 'Yes' ";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@va_1", Textbox_enter_productname_signin.Text);
            using (reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    num_row_username++;

                }
                reader.Close();
            }
            if (num_row_username >= 1)
            {
                string password = null;
                command.CommandText = $"select password from sales.add_user where user_name =@va_1 and acceas = 'Yes'";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@va_1", Textbox_enter_productname_signin.Text);
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        password = reader["password"].ToString();

                    }
                    reader.Close();
                }

                if(password == Textbox_enter_brandname_signin.Text )
                {
                    gride_user_signin.Visibility = Visibility.Hidden;
                    gride_stock.Visibility = Visibility.Visible;
                }
                else if (password != Textbox_enter_brandname_signin.Text )
                {
                    MessageBox.Show($"Sorry, Enter correct password of user name {Textbox_enter_productname_signin.Text}");
                }

            }
            else if (num_row_username == 0)
            {
                MessageBox.Show("Sorry, The user name dont't find at user data that can acceas the program ");
            }
        }




        //--------------------------------------- 2-User---------------------------------------------------

        //---------------------------------------search user-------------------------------------

        private void textbox_search_user_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_user.Effect = effectbo;
            effectbo.ShadowDepth = 1;
            textbox_search_user.BorderThickness = new Thickness(0);
        }

        private void textbox_search_user_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_user.Effect = null;

        }

        private void label_search_user_1_MouseEnter(object sender, MouseEventArgs e)
        {

            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_user.Effect = effectbo;
            effectbo.ShadowDepth = 1;
        }

        private void label_search_user_1_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_user.Effect = null;

        }

        private void textbox_search_user_TextChanged(object sender, TextChangedEventArgs e)
        {
            label_search_user.Visibility = Visibility.Hidden;
            if (textbox_search_user.Text == null || textbox_search_user.Text == "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by add_user.id asc) as 'RowNumber',id,user_name,password,there_image  from sales.add_user where acceas = 'No'  ", conn);
                    tab_user.Clear();
                    adb.Fill(tab_user);
                    griddata_all_stock.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_stock.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_stock.ItemsSource = tab_user.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (textbox_search_user.Text != null || textbox_search_user.Text != "")
            {

                try
                {
                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by user_name asc) as 'RowNumber',id,user_name,password,there_image  from sales.add_user where user_name Like @va_1+'%' and acceas = 'No' ", conn);
                    adb.SelectCommand.Parameters.Clear();
                    adb.SelectCommand.Parameters.AddWithValue("@va_1", textbox_search_user.Text);
                    tab_user.Clear();
                    adb.Fill(tab_user);
                    griddata_all_stock.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_stock.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_stock.ItemsSource = tab_user.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

        }

        private void textbox_search_user_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox_search_user.Text == " " || textbox_search_user.Text == "")
            {
                label_search_user.Visibility = Visibility.Visible;

            }
        }



        //---------------------------------------Text box entery user-------------------------------------


        private void Textbox_enter_productname_user_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_productname_user.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color =System.Windows.Media.Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF); ;
        }

        private void Textbox_enter_brandname_user_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_brandname_user.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = System.Windows.Media.Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF); ;
        }

        private void Textbox_enter_productname_user_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_productname_user.Effect = null;

        }
        private void Textbox_enter_brandname_user_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_brandname_user.Effect = null;

        }

       

        private void gride_stock_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                if (Textbox_enter_productname_user.IsFocused == true)
                {
                    Textbox_enter_brandname_user.Focus();
                }
            }
            else if (e.Key == Key.Up)
            {
                if (Textbox_enter_brandname_user.IsFocused == true)
                {
                    Textbox_enter_productname_user.Focus();
                }

            }
        }

       


        //---------------------------------------Button add,cancel user-------------------------------------

        private void label_add_user_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_add_user.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_cancel_user_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_cancel_user.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_add_user_MouseLeave(object sender, MouseEventArgs e)
        {
            border_add_user.Effect = null;

        }

        private void label_add_user_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var answer = MessageBox.Show("Are you sure add new user ", "Warning", MessageBoxButton.YesNo);
            if (answer == MessageBoxResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(Textbox_enter_productname_user.Text) == false && string.IsNullOrWhiteSpace(Textbox_enter_brandname_user.Text) == false && Textbox_enter_brandname_user.Text.Length >= 8)
                {
                    int num_row_username = 0;
                    command.CommandText = $"select * from sales.add_user where user_name =@va_1";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@va_1", Textbox_enter_productname_user.Text);
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            num_row_username++;

                        }
                        reader.Close();
                    }


                    if (num_row_username == 0)
                    {
                        command.CommandText = $"insert into sales.add_user(user_name,password,image_source,there_image,acceas) values(@va_1,@va_2,@va_3,@va_4,'No')";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@va_1", Textbox_enter_productname_user.Text);
                        command.Parameters.AddWithValue("@va_2", Textbox_enter_brandname_user.Text);
                        command.Parameters.AddWithValue("@va_3", image_source);
                        if (image_source == Environment.CurrentDirectory + @"\man.png")
                        {
                            command.Parameters.AddWithValue("@va_4", "No");
                        }
                        else if (image_source != Environment.CurrentDirectory + @"\man.png")
                        {
                            command.Parameters.AddWithValue("@va_4", "Yes");
                        }
                        command.ExecuteNonQuery();

                        command.CommandText = $"select top 1 id from sales.add_user order by id desc ";
                        reader = command.ExecuteReader();
                        reader.Read();
                        string id = reader["id"].ToString();
                        reader.Close();


                        if (image_source != Environment.CurrentDirectory + @"\man.png")
                        {
                            
                                int len = image_source.Length;
                                string emdad = image_source.Substring(len - 4, 4);
                                string url = @"\imagofuser\" + id + emdad;
                                File.Copy(image_source, Environment.CurrentDirectory + @"\imagofuser\" + id + emdad);
                                command.CommandText = $"update sales.add_user set image_source = @va_1 where id ={id} ";
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@va_1", url);
                                command.ExecuteNonQuery();
                            
                            

                        }
                        else if (image_source == Environment.CurrentDirectory + @"\man.png")
                        {
                            command.CommandText = $"update sales.add_user set image_source = @va_1 where id ={id} ";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@va_1", @"\man.png");
                            command.ExecuteNonQuery();
                        }







                        label_cancel_user_MouseLeftButtonDown(null, null);

                        MessageBox.Show("Saved Successfully");

                        adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by add_user.id desc) as 'RowNumber',id,user_name,password,there_image  from sales.add_user where acceas='No'  ", conn);
                        tab_user.Clear();
                        adb.Fill(tab_user);
                        griddata_all_stock.Items.SortDescriptions.Clear();
                        foreach (var column in griddata_all_stock.Columns)
                        {
                            column.SortDirection = null;
                        }
                        griddata_all_stock.ItemsSource = tab_user.DefaultView;
                    }
                    else if (num_row_username >= 1)
                    {
                        MessageBox.Show("Sorry, The User Name is in normal and acceas users data, Please enter another name");
                    }

                }
                else if (string.IsNullOrWhiteSpace(Textbox_enter_productname_user.Text) == true || string.IsNullOrWhiteSpace(Textbox_enter_brandname_user.Text) == true || Textbox_enter_brandname_user.Text.Length < 8)
                {
                    MessageBox.Show("Sorry,check the user name, password it must have text and password length equal 8 or greater");
                }
            }
            else if (answer == MessageBoxResult.No)
            {
                label_cancel_user_MouseLeftButtonDown(null, null);
            }

        }


        private void label_cancel_user_MouseLeave(object sender, MouseEventArgs e)
        {
            border_cancel_user.Effect = null;

        }

        private void label_cancel_user_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string url = Environment.CurrentDirectory + @"\man.png";
            border_image_user.Background = new ImageBrush(new BitmapImage(new Uri(url)));
            image_source = Environment.CurrentDirectory + @"\man.png";
            border_image_delete.Visibility = Visibility.Hidden;
            Textbox_enter_productname_user.Text = "";
            Textbox_enter_brandname_user.Text = "";
            Textbox_enter_productname_user.Focus();
        }


        //---------------------------------------border image close and image user-------------------------------------


        private void border_image_user_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_image_user.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void border_image_user_MouseLeave(object sender, MouseEventArgs e)
        {
            border_image_user.Effect = null;
        }

        string image_source = Environment.CurrentDirectory + @"\man.png";
        private void border_image_user_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textbox_enter_productname_user.Focus();
            OpenFileDialog opfi = new OpenFileDialog();
            opfi.Filter = "Image files (*.jpg, *.png) | *.jpg;  *.png;";
            bool? res = opfi.ShowDialog();

            if (res == true)
            {
                try
                {

                   

                    border_image_user.Background = new ImageBrush(new BitmapImage(new Uri(opfi.FileName)));
                    image_source = opfi.FileName;
                    border_image_delete.Visibility = Visibility.Visible;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }




            }
        }


        private void border_image_delete_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_image_delete.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void border_image_delete_MouseLeave(object sender, MouseEventArgs e)
        {
            border_image_delete.Effect = null;

        }

        private void border_image_delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string url = Environment.CurrentDirectory + @"\man.png";
            border_image_user.Background = new ImageBrush(new BitmapImage(new Uri(url)));
            image_source = Environment.CurrentDirectory + @"\man.png";
            border_image_delete.Visibility = Visibility.Hidden;
        }



        //--------------------------------------------------------gridedat-all_user---------------------------

        

        string namepinding_user = "";
        private void griddata_all_stock_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            namepinding_user = griddata_all_stock.CurrentCell.Column.SortMemberPath;
            var textBox_2 = e.EditingElement as TextBox;
            if(textBox_2!= null)
            {
                textBox_2.Text = "";
                textBox_2.PreviewKeyDown += textBox_2privew_user;
            }
        }
        bool key_enter_text_cell_user = false;
        private void textBox_2privew_user(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                key_enter_text_cell_user = true;
            }
        }


        private void griddata_all_stock_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

            if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_user == true)
            {
                if (griddata_all_stock.CurrentCell.Column != null)
                {
                    var namepinding = griddata_all_stock.CurrentCell.Column.SortMemberPath;
                    var headercoulmn = griddata_all_stock.CurrentCell.Column.Header;
                    var indexcoulmn = griddata_all_stock.CurrentCell.Column.DisplayIndex;
                    var cellInfo = griddata_all_stock.SelectedCells[indexcoulmn];
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

                    int numberofindex = griddata_all_stock.SelectedIndex;
                    var cellValue = griddata_all_stock.Items[numberofindex] as DataRowView;
                    string value_id = "";
                    value_id = cellValue[1].ToString();

                    if (string.IsNullOrWhiteSpace(value) == false && namepinding.ToString() != "RowNumber" && namepinding.ToString() != "there_image")
                    {
                        var answer = MessageBox.Show("Are you sure that the " + headercoulmn.ToString() + " has changed to " + value, "Warning", MessageBoxButton.YesNo);
                        if (answer == MessageBoxResult.Yes)
                        {
                            int num_row = 0;
                            if (namepinding == "user_name")
                            {

                                command.CommandText = $"select * from sales.add_user where user_name =@va_1";
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@va_1", value);
                                using (reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        num_row++;

                                    }
                                    reader.Close();
                                }

                                if (num_row == 0)
                                {
                                    adb.SelectCommand = new SqlCommand($" update sales.add_user set user_name =@va_1 where id={value_id}", conn);
                                    adb.SelectCommand.Parameters.Clear();
                                    adb.SelectCommand.Parameters.AddWithValue("@va_1", value);
                                    adb.SelectCommand.ExecuteNonQuery();
                                    MessageBox.Show("Changes have been applied successfully");
                                }
                                else if (num_row >= 1)
                                {
                                    griddata_all_stock.CancelEdit();
                                    MessageBox.Show("Sorry, The User name is in normal and acceas users data, Please Write User name is't in the data");
                                }

                            }
                            else if (namepinding == "password")
                            {
                                if (value.Length >= 8)
                                {
                                    adb.SelectCommand = new SqlCommand($" update sales.add_user set password =@va_1 where id={value_id}", conn);
                                    adb.SelectCommand.Parameters.Clear();
                                    adb.SelectCommand.Parameters.AddWithValue("@va_1", value);
                                    adb.SelectCommand.ExecuteNonQuery();
                                    MessageBox.Show("Changes have been applied successfully");
                                }
                                else if (value.Length < 8)
                                {
                                    griddata_all_stock.CancelEdit();
                                    MessageBox.Show("Sorry The password length must equal 8 or greater");
                                }

                            }

                        }
                        else if (answer == MessageBoxResult.No)
                        {
                            griddata_all_stock.CancelEdit();
                            MessageBox.Show("Changes have been canceled successfully");
                        }
                    }
                    else if (namepinding.ToString() == "RowNumber" || namepinding.ToString() == "there_image")
                    {

                        griddata_all_stock.CancelEdit();
                        MessageBox.Show("Sorry, You can't change value this coulmn");

                    }

                    else if (string.IsNullOrWhiteSpace(value) == true && (namepinding.ToString() == "user_name" || namepinding.ToString() == "password"))
                    {
                        MessageBox.Show("Sorry, Please Enter Text");
                        griddata_all_stock.CancelEdit();

                    }

                }
                else
                {
                    griddata_all_stock.CancelEdit();
                    griddata_all_stock.SelectedItem = null;
                }
                key_enter_text_cell_user = false;
            }
            else if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_user == false)
            {
                griddata_all_stock.CancelEdit();
            }
        }

        private void griddata_all_stock_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && griddata_all_stock.CurrentCell.Column.DisplayIndex == 5)
            {
                image_user_MouseLeftButtonDown_1(null, null);
            }
        }

        private void image_user_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (griddata_all_stock.SelectedIndex >= 0)
            {
                var answer = MessageBox.Show("Are you sure Delete the Row","Warning", MessageBoxButton.YesNo);

                if (answer == MessageBoxResult.Yes)
                {
                    int numberofindex = griddata_all_stock.SelectedIndex;
                    var cellValue = griddata_all_stock.Items[numberofindex] as DataRowView;
                    string value_id = "";
                    value_id = cellValue[1].ToString();

                    string image_path="";
                    string user_name="";
                    command.CommandText = $"select image_source,user_name from sales.add_user where id ={value_id}";
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            image_path= reader["image_source"].ToString();
                            user_name = reader["user_name"].ToString();
                        }
                        reader.Close();
                    }

                    if (image_path !=  @"\man.png")
                    {
                        if (File.Exists(Environment.CurrentDirectory + image_path))
                        {
                            File.Delete(Environment.CurrentDirectory+image_path);
                            image_path = Environment.CurrentDirectory + @"\man.png";
                            border_image_user.Background = new ImageBrush(new BitmapImage(new Uri(image_path)));
                        }
                    }

                    command.CommandText = $"delete from sales.add_user where id ={value_id}";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete have been applied successfully");

                    if (user_name == text_name_user.Content.ToString().Substring(6))
                    {
                        MainWindow mainWindow_1_1 = new MainWindow();
                        mainWindow_1_1.Show();
                        this.Close();
                    }
                    else  if (user_name != text_name_user.Content.ToString().Substring(6))
                    {
                        try
                        {
                            adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by add_user.id asc) as 'RowNumber',id,user_name,password,there_image  from sales.add_user where acceas ='No'  ", conn);
                            tab_user.Clear();
                            adb.Fill(tab_user);
                            griddata_all_stock.ItemsSource = tab_user.DefaultView;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                  


                }
                else if (answer == MessageBoxResult.No)
                {
                    MessageBox.Show("Delete have been canceled successfully");

                }
            }
        }

        private void griddata_all_stock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (griddata_all_stock.SelectedIndex != -1 )
            { 
                int numberofindex = griddata_all_stock.SelectedIndex;
                var cellValue = griddata_all_stock.Items[numberofindex] as DataRowView;
                string value_id = "";
                value_id = cellValue[1].ToString();

                string image_path= "";
                command.CommandText = $"select image_source from sales.add_user where id ={value_id}";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        image_path = reader["image_source"].ToString();

                    }
                    reader.Close();
                }

                if (File.Exists(Environment.CurrentDirectory+image_path))
                {
                    using (FileStream imgFileStream = new FileStream(Environment.CurrentDirectory + image_path, FileMode.Open, FileAccess.Read))
                    {
               
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.StreamSource = imgFileStream;
                        bitmapImage.EndInit();
                        border_image_user.Background = new ImageBrush(bitmapImage);
                    }


                    Textbox_enter_productname_user.Text = "";
                    Textbox_enter_brandname_user.Text = "";
                    border_image_delete.Visibility = Visibility.Hidden;

                }

            }
        }

        private void griddata_all_stock_LostFocus(object sender, RoutedEventArgs e)
        {
            if (griddata_all_stock.CurrentCell.Column == null )
            {
                string url = Environment.CurrentDirectory + @"\man.png";
                border_image_user.Background = new ImageBrush(new BitmapImage(new Uri(url)));
                image_source = Environment.CurrentDirectory + @"\man.png";
                border_image_delete.Visibility = Visibility.Hidden;
                griddata_all_stock.SelectedIndex = -1;

            }
        }

       

        private void griddata_all_stock_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (gride_stock.Visibility == Visibility.Visible)
            {
                try
                {
                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by add_user.id asc) as 'RowNumber',id,user_name,password,there_image  from sales.add_user where acceas ='No'  ", conn);
                    tab_user.Clear();
                    adb.Fill(tab_user);
                    griddata_all_stock.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_stock.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_stock.ItemsSource = tab_user.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (gride_stock.Visibility == Visibility.Hidden)
            {
                griddata_all_stock.IsReadOnly = true;

            }
        }

       
    }
}
