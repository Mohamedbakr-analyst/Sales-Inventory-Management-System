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
    /// Interaction logic for Products_1.xaml
    /// </summary>
    public partial class Products_1 : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_44330760199;Integrated Security=True");

        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_2;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter adb = new SqlDataAdapter();
        DataTable tab_product = new DataTable();
        DataTable tab_brand = new DataTable();
        DataTable tab_catogary = new DataTable();
        DataTable tab_stock = new DataTable();
        DataTable tab_textbrand = new DataTable();
        DataTable tab_textcatogary = new DataTable();



        public Products_1()
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
            if (gride_product.Visibility == Visibility.Visible)
            {
                if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.U))
                {
                    if (griddata_all_product.IsReadOnly == true)
                    {
                        griddata_all_product.IsReadOnly = false;
                        MessageBox.Show("Allows editing data");
                    }
                    else if (griddata_all_product.IsReadOnly == false)
                    {
                        griddata_all_product.IsReadOnly = true;
                        MessageBox.Show("Does not allow editing data");

                    }

                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.A))
                {
                    label_add_product_MouseLeftButtonDown(sender, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.C))
                {
                    label_cancel_product_MouseLeftButtonDown(sender, null);
                }
            }

            else if (gride_brand.Visibility == Visibility.Visible)
            {
                if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.U))
                {
                    if (griddata_all_brand.IsReadOnly == true)
                    {
                        griddata_all_brand.IsReadOnly = false;
                        MessageBox.Show("Allows editing data");
                    }
                    else if (griddata_all_brand.IsReadOnly == false)
                    {
                        griddata_all_brand.IsReadOnly = true;
                        MessageBox.Show("Does not allow editing data");

                    }

                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.A))
                {
                   label_add_brand_MouseLeftButtonDown(sender, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.C))
                {
                    label_cancel_brand_MouseLeftButtonDown(sender, null);
                }
            }

            else if (gride_category.Visibility == Visibility.Visible)
            {
                if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.U))
                {
                    if (griddata_all_category.IsReadOnly == true)
                    {
                        griddata_all_category.IsReadOnly = false;
                        MessageBox.Show("Allows editing data");
                    }
                    else if (griddata_all_category.IsReadOnly == false)
                    {
                        griddata_all_category.IsReadOnly = true;
                        MessageBox.Show("Does not allow editing data");

                    }

                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.A))
                {
                    label_add_category_MouseLeftButtonDown(sender, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.C))
                {
                    label_cancel_category_MouseLeftButtonDown(sender, null);
                }
            }

            else if (gride_stock.Visibility == Visibility.Visible)
            {
                if (e.KeyboardDevice.IsKeyDown(Key.LeftAlt) && e.KeyboardDevice.IsKeyDown(Key.U))
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
            
        }

        private void image_menu_3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
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
            gride_product.Visibility = Visibility.Visible;
            gride_brand.Visibility = Visibility.Hidden;
            gride_category.Visibility = Visibility.Hidden;
            gride_stock.Visibility = Visibility.Hidden;



            label_open_product.Background = null;
            border_open_product.Background = null;

            label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
        }

        private void lable_moreproduct_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gride_brand.Visibility = Visibility.Visible;
            gride_product.Visibility = Visibility.Hidden;
            gride_category.Visibility = Visibility.Hidden;
            gride_stock.Visibility = Visibility.Hidden;


            label_open_brand.Background = null;
            border_open_brand.Background = null;

            label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
        }

        private void lable_moreproduct_3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gride_category.Visibility = Visibility.Visible;
            gride_stock.Visibility = Visibility.Hidden;
            gride_brand.Visibility = Visibility.Hidden;
            gride_product.Visibility = Visibility.Hidden;

            label_open_category.Background = null;
            border_open_category.Background = null;

            label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
        }

        private void lable_moreproduct_4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gride_stock.Visibility = Visibility.Visible;
            gride_category.Visibility = Visibility.Hidden;
            gride_brand.Visibility = Visibility.Hidden;
            gride_product.Visibility = Visibility.Hidden;

            label_open_stock.Background = null;
            border_open_stock.Background = null;

            label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
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

        //-------------------------------- gride 4 type product brand catogary stock---------------------------------------------------

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
                label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));

              

            }
            else if (label_open_product.Background != null)
            {
                

                gride_product.Visibility = Visibility.Visible;
                gride_brand.Visibility = Visibility.Hidden;
                gride_category.Visibility = Visibility.Hidden;
                gride_stock.Visibility = Visibility.Hidden;



                label_open_product.Background = null;
                border_open_product.Background = null;

                label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));

               

            }

            textbox_search_product.Text = string.Empty;
            Textbox_enter_productname_product.Text = string.Empty;
            Textbox_enter_brandname_product.Text = string.Empty;
            Textbox_enter_catogaryname_product.Text = string.Empty;
            Textbox_enter_modelyear_product.Text = string.Empty;
            Textbox_enter_price_product.Text = string.Empty;
            textbox_search_brand.Text = string.Empty;
            Textbox_enter_productname_brand.Text = string.Empty;
            textbox_search_category.Text = string.Empty;
            Textbox_enter_productname_category.Text = string.Empty;
            textbox_search_stock.Text = string.Empty;
           

            label_search_product.Visibility = Visibility.Visible;
            label_search_brand.Visibility = Visibility.Visible;
            label_search_category.Visibility= Visibility.Visible;
            label_search_stock.Visibility= Visibility.Visible;

            label_search_product_1.Focus();
            label_search_brand_1.Focus();
            label_search_category_1.Focus();
            label_search_stock_1.Focus();




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
                label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            }
            else if (label_open_brand.Background != null)
            {
                gride_brand.Visibility = Visibility.Visible;
                gride_product.Visibility = Visibility.Hidden;
                gride_category.Visibility = Visibility.Hidden;
                gride_stock.Visibility = Visibility.Hidden;


                label_open_brand.Background = null;
                border_open_brand.Background = null;

                label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));

            }

            textbox_search_product.Text = string.Empty;
            Textbox_enter_productname_product.Text = string.Empty;
            Textbox_enter_brandname_product.Text = string.Empty;
            Textbox_enter_catogaryname_product.Text = string.Empty;
            Textbox_enter_modelyear_product.Text = string.Empty;
            Textbox_enter_price_product.Text = string.Empty;
            textbox_search_brand.Text = string.Empty;
            Textbox_enter_productname_brand.Text = string.Empty;
            textbox_search_category.Text = string.Empty;
            Textbox_enter_productname_category.Text = string.Empty;
            textbox_search_stock.Text = string.Empty;
           

            label_search_product.Visibility = Visibility.Visible;
            label_search_brand.Visibility = Visibility.Visible;
            label_search_category.Visibility = Visibility.Visible;
            label_search_stock.Visibility = Visibility.Visible;

            label_search_product_1.Focus();
            label_search_brand_1.Focus();
            label_search_category_1.Focus();
            label_search_stock_1.Focus();
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
                label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            }
            else if (label_open_category.Background != null)
            {
                gride_category.Visibility = Visibility.Visible;
                gride_stock.Visibility = Visibility.Hidden;
                gride_brand.Visibility = Visibility.Hidden;
                gride_product.Visibility = Visibility.Hidden;

                label_open_category.Background = null;
                border_open_category.Background = null;

                label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));

            }

            textbox_search_product.Text = string.Empty;
            Textbox_enter_productname_product.Text = string.Empty;
            Textbox_enter_brandname_product.Text = string.Empty;
            Textbox_enter_catogaryname_product.Text = string.Empty;
            Textbox_enter_modelyear_product.Text = string.Empty;
            Textbox_enter_price_product.Text = string.Empty;
            textbox_search_brand.Text = string.Empty;
            Textbox_enter_productname_brand.Text = string.Empty;
            textbox_search_category.Text = string.Empty;
            Textbox_enter_productname_category.Text = string.Empty;
            textbox_search_stock.Text = string.Empty;
           

            label_search_product.Visibility = Visibility.Visible;
            label_search_brand.Visibility = Visibility.Visible;
            label_search_category.Visibility = Visibility.Visible;
            label_search_stock.Visibility = Visibility.Visible;

            label_search_product_1.Focus();
            label_search_brand_1.Focus();
            label_search_category_1.Focus();
            label_search_stock_1.Focus();
        }

        //4
        private void label_open_stock_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            label_open_stock.Effect = effect;
            border_open_stock.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
        }

        private void label_open_stock_MouseLeave(object sender, MouseEventArgs e)
        {
            label_open_stock.Effect = null;
            border_open_stock.Effect = null;
        }

        private void label_open_stock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (label_open_stock.Background == null)
            {
                gride_stock.Visibility = Visibility.Hidden;
                label_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_stock.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
            }
            else if (label_open_stock.Background != null)
            {
                gride_stock.Visibility = Visibility.Visible;
                gride_category.Visibility = Visibility.Hidden;
                gride_brand.Visibility = Visibility.Hidden;
                gride_product.Visibility = Visibility.Hidden;

                label_open_stock.Background = null;
                border_open_stock.Background = null;

                label_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_product.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_brand.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                label_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));
                border_open_category.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xD9, 0xD9));

            }

            textbox_search_product.Text = string.Empty;
            Textbox_enter_productname_product.Text = string.Empty;
            Textbox_enter_brandname_product.Text = string.Empty;
            Textbox_enter_catogaryname_product.Text = string.Empty;
            Textbox_enter_modelyear_product.Text = string.Empty;
            Textbox_enter_price_product.Text = string.Empty;
            textbox_search_brand.Text = string.Empty;
            Textbox_enter_productname_brand.Text = string.Empty;
            textbox_search_category.Text = string.Empty;
            Textbox_enter_productname_category.Text = string.Empty;
            textbox_search_stock.Text = string.Empty;
            

            label_search_product.Visibility = Visibility.Visible;
            label_search_brand.Visibility = Visibility.Visible;
            label_search_category.Visibility = Visibility.Visible;
            label_search_stock.Visibility = Visibility.Visible;

            label_search_product_1.Focus();
            label_search_brand_1.Focus();
            label_search_category_1.Focus();
            label_search_stock_1.Focus();
        }




        //--------------------------------------- 1-Product---------------------------------------------------
        //---------------------------------------Text box search product-------------------------------------

        private void textbox_search_product_MouseEnter(object sender, MouseEventArgs e)
        {
           
            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_product.Effect = effectbo;
            effectbo.ShadowDepth = 1;
            textbox_search_product.BorderThickness = new Thickness(0);
        }

        private void textbox_search_product_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_product.Effect = null;

        }

        private void label_search_product_1_MouseEnter(object sender, MouseEventArgs e)
        {

            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_product.Effect = effectbo;
            effectbo.ShadowDepth = 1;
        }

        private void label_search_product_1_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_product.Effect = null;

        }

        private void textbox_search_product_TextChanged(object sender, TextChangedEventArgs e)
        {
            label_search_product.Visibility = Visibility.Hidden;
            if (textbox_search_product.Text == null || textbox_search_product.Text == "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by products.product_id asc) as 'RowNumber', products.product_id,product_name,brands.brand_name , categories.category_name,model_year,list_price from production.products join production.brands on products.brand_id= brands.brand_id join production.categories on products.category_id= categories.category_id ", conn);
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
            }
            else if (textbox_search_product.Text != null || textbox_search_product.Text != "")
            {

                try
                {
                    adb.SelectCommand = new SqlCommand($"select ROW_NUMBER() over(order by product_name asc) as 'RowNumber', products.product_id,product_name,brands.brand_name , categories.category_name,model_year,list_price from production.products join production.brands on products.brand_id= brands.brand_id join production.categories on products.category_id= categories.category_id where product_name Like '{textbox_search_product.Text}%'  ", conn);
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

            }

        }

        private void textbox_search_product_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox_search_product.Text == " " || textbox_search_product.Text == "")
            {
                label_search_product.Visibility = Visibility.Visible;

            }
        }


        //---------------------------------------Text box entery product-------------------------------------

        private void Textbox_enter_productname_product_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_productname_product.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_brandname_product_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_brandname_product.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_catogaryname_product_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_catogaryname_product.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_modelyear_product_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_modelyear_product.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
            
        }

        private void Textbox_enter_price_product_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_price_product.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_productname_product_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_productname_product.Effect = null;

        }
        private void Textbox_enter_productname_product_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                Textbox_enter_brandname_product.Focus();
            }
            else if (e.Key == Key.Up)
            {
                Textbox_enter_productname_product.Focus();
            }
        }

        private void Textbox_enter_brandname_product_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_brandname_product.Effect = null;

            griddata_brandname_product.Visibility = Visibility.Hidden;
            Textbox_enter_brandname_product.Height = 36;
            Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;

        }
        private void Textbox_enter_brandname_product_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Textbox_enter_brandname_product.Text == null || Textbox_enter_brandname_product.Text == "")
            {
                griddata_brandname_product.Visibility = Visibility.Hidden;
                Textbox_enter_brandname_product.Height = 36;
                Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;

            }
            else if (Textbox_enter_brandname_product.Text != null || Textbox_enter_brandname_product.Text != "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand($" select distinct top 5  brand_name from production.brands where brand_name like '{Textbox_enter_brandname_product.Text}%' order by brand_name asc ", conn);

                    tab_textbrand.Clear();
                    adb.Fill(tab_textbrand);
                    griddata_brandname_product.ItemsSource = tab_textbrand.DefaultView;
                    griddata_brandname_product.Visibility = Visibility.Visible;

                    Textbox_enter_brandname_product.Height = 165;
                    Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Top;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        private void Textbox_enter_brandname_product_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (griddata_brandname_product.Visibility == Visibility)
            {


                if (e.Key == Key.Down)
                {

                    if (griddata_brandname_product.SelectedIndex >= -1 && griddata_brandname_product.SelectedIndex <= 3)
                    {
                        griddata_brandname_product.SelectedIndex = griddata_brandname_product.SelectedIndex + 1;
                    }
                    else if (griddata_brandname_product.SelectedIndex == 4)
                    {
                        griddata_brandname_product.SelectedIndex = 0;
                    }

                }
                else if (e.Key == Key.Up)
                {
                    if (griddata_brandname_product.SelectedIndex <= 4 && griddata_brandname_product.SelectedIndex >= 1)
                    {
                        griddata_brandname_product.SelectedIndex = griddata_brandname_product.SelectedIndex - 1;
                    }
                    else if (griddata_brandname_product.SelectedIndex == 0)
                    {
                        griddata_brandname_product.SelectedIndex = 4;
                    }

                }
                else if (e.Key == Key.Enter)
                {
                    int x = griddata_brandname_product.SelectedIndex;
                    if (x >= 0)
                    {
                        var cellValue = griddata_brandname_product.Items[x] as DataRowView;


                        string value = cellValue[0].ToString();

                        Textbox_enter_brandname_product.Text = value;
                        Textbox_enter_brandname_product.SelectionStart = value.Length;
                        griddata_brandname_product.Visibility = Visibility.Hidden;

                        Textbox_enter_brandname_product.Height = 36;
                        Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;

                    }

                }
                else if (e.Key == Key.Escape)
                {
                    griddata_brandname_product.Visibility = Visibility.Hidden;

                    Textbox_enter_brandname_product.Height = 36;
                    Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;

                }
            }
            else if (griddata_brandname_product.Visibility == Visibility.Hidden)
            {
                if (e.Key == Key.Up)
                {
                    Textbox_enter_productname_product.Focus();
                }
                else if (e.Key == Key.Down)
                {
                    Textbox_enter_catogaryname_product.Focus();
                }
            }
        }

        private void Textbox_enter_catogaryname_product_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_catogaryname_product.Effect = null;

            griddata_catogaryname_product.Visibility = Visibility.Hidden;
            Textbox_enter_catogaryname_product.Height = 36;
            Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;

        }
        private void Textbox_enter_catogaryname_product_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Textbox_enter_catogaryname_product.Text == null || Textbox_enter_catogaryname_product.Text == "")
            {
                griddata_catogaryname_product.Visibility = Visibility.Hidden;
                Textbox_enter_catogaryname_product.Height = 36;
                Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;

            }
            else if (Textbox_enter_catogaryname_product.Text != null || Textbox_enter_catogaryname_product.Text != "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand($" select distinct top 5  category_name from production.categories where category_name like '{Textbox_enter_catogaryname_product.Text}%' order by category_name asc ", conn);

                    tab_textcatogary.Clear();
                    adb.Fill(tab_textcatogary);
                    griddata_catogaryname_product.ItemsSource = tab_textcatogary.DefaultView;
                    griddata_catogaryname_product.Visibility = Visibility.Visible;

                    Textbox_enter_catogaryname_product.Height = 165;
                    Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Top;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        private void Textbox_enter_catogaryname_product_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (griddata_catogaryname_product.Visibility == Visibility)
            {

                if (e.Key == Key.Down)
                {
                    if (griddata_catogaryname_product.SelectedIndex >= -1 && griddata_catogaryname_product.SelectedIndex <= 3)
                    {
                        griddata_catogaryname_product.SelectedIndex = griddata_catogaryname_product.SelectedIndex + 1;
                    }
                    else if (griddata_catogaryname_product.SelectedIndex == 4)
                    {
                        griddata_catogaryname_product.SelectedIndex = 0;
                    }

                }
                else if (e.Key == Key.Up)
                {
                    if (griddata_catogaryname_product.SelectedIndex <= 4 && griddata_catogaryname_product.SelectedIndex >= 1)
                    {
                        griddata_catogaryname_product.SelectedIndex = griddata_catogaryname_product.SelectedIndex - 1;
                    }
                    else if (griddata_catogaryname_product.SelectedIndex == 0)
                    {
                        griddata_catogaryname_product.SelectedIndex = 4;
                    }

                }
                else if (e.Key == Key.Enter)
                {
                    int x = griddata_catogaryname_product.SelectedIndex;
                    if (x >= 0)
                    {
                        var cellValue = griddata_catogaryname_product.Items[x] as DataRowView;


                        string value = cellValue[0].ToString();

                        Textbox_enter_catogaryname_product.Text = value;
                        Textbox_enter_catogaryname_product.SelectionStart = value.Length;
                        griddata_catogaryname_product.Visibility = Visibility.Hidden;

                        Textbox_enter_catogaryname_product.Height = 36;
                        Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;

                    }

                }
                else if (e.Key == Key.Escape)
                {
                    griddata_catogaryname_product.Visibility = Visibility.Hidden;

                    Textbox_enter_catogaryname_product.Height = 36;
                    Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;

                }

            }
            else if (griddata_catogaryname_product.Visibility == Visibility.Hidden)
            {
                if (e.Key == Key.Up)
                {
                    Textbox_enter_brandname_product.Focus();
                }
                else if (e.Key == Key.Down)
                {
                    Textbox_enter_modelyear_product.Focus();
                }
            }
        }

        private void Textbox_enter_modelyear_product_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_modelyear_product.Effect = null;

        }
        private void Textbox_enter_modelyear_product_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                Textbox_enter_price_product.Focus();
            }
            else if (e.Key == Key.Up)
            {
                Textbox_enter_catogaryname_product.Focus();
            }
        }


        private void Textbox_enter_price_product_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_price_product.Effect = null;

        }
        private void Textbox_enter_price_product_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Up)
            {
                Textbox_enter_modelyear_product.Focus();
            }
        }



        private void Textbox_enter_modelyear_product_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Textbox_enter_modelyear_product.Text.Length < 4)
            {
                if (e.Text.Length > 0)
                {
                    if (char.IsDigit(e.Text, 0) == false)
                    {
                        e.Handled = true;
                    }
                }
            }
            else if(Textbox_enter_modelyear_product.Text.Length >= 4)
            {
                e.Handled = true;
            }
           
        }

        private void Textbox_enter_price_product_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Length > 0)
            {
                if (!char.IsDigit(e.Text, 0) && e.Text != ".")
                {
                    e.Handled = true;
                }

                else if (e.Text == "." && ((TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }


        //---------------------------------------Button add,update,cancel product-------------------------------------


        private void label_add_product_MouseEnter(object sender, MouseEventArgs e)
        {

            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_add_product.Effect = effect;
            effect.ShadowDepth = 1;
        }

       
        private void label_cancel_product_MouseEnter(object sender, MouseEventArgs e)
        {

            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_cancel_product.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_add_product_MouseLeave(object sender, MouseEventArgs e)
        {
           border_add_product.Effect = null;

        }
        private void label_add_product_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(Textbox_enter_productname_product.Text) == false && string.IsNullOrWhiteSpace(Textbox_enter_brandname_product.Text) == false && string.IsNullOrWhiteSpace(Textbox_enter_modelyear_product.Text) == false && string.IsNullOrWhiteSpace(Textbox_enter_price_product.Text) == false && string.IsNullOrWhiteSpace(Textbox_enter_catogaryname_product.Text) == false)
            {

                var answer = MessageBox.Show("Are you sure add new row ", "Warning", MessageBoxButton.YesNo);
                if (answer == MessageBoxResult.Yes)
                {
                    int num_row_product = 0;
                    command.CommandText = $"select * from production.products where product_name='{Textbox_enter_productname_product.Text}'";
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            num_row_product++;

                        }
                        reader.Close();
                    }
                    int num_row_brand = 0;
                    command.CommandText = $"select * from production.brands where brand_name ='{Textbox_enter_brandname_product.Text}'";
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            num_row_brand++;

                        }
                        reader.Close();
                    }
                    int num_row_catogary = 0;
                    command.CommandText = $"select * from production.categories where category_name ='{Textbox_enter_catogaryname_product.Text}'";
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            num_row_catogary++;

                        }
                        reader.Close();
                    }

                    if (num_row_product >= 1 || num_row_brand == 0 || num_row_catogary == 0)
                    {
                        if (num_row_product >= 1)
                        {
                            MessageBox.Show("Sorry, Faild add new row, The product name is in the data, Change the product name and try again ");
                        }
                        else if(num_row_brand==0)
                        {
                            MessageBox.Show("Sorry, Faild add new row, The brand name not found,Please enter brand name is in the data and try again ");
                        }
                        else if(num_row_catogary == 0)
                        {
                            MessageBox.Show("Sorry, Faild add new row, The catogary name not found,Please enter catogary name is in the data and try again ");

                        }
                    }
                    else if(num_row_product==0 && num_row_brand>=1 && num_row_catogary >= 1)
                    {

                        adb.SelectCommand = new SqlCommand($"insert into production.products(product_name,brand_id,category_id,model_year,list_price) values('{Textbox_enter_productname_product.Text}',(select brand_id from production.brands where brand_name='{Textbox_enter_brandname_product.Text}'),(select category_id from production.categories where category_name ='{Textbox_enter_catogaryname_product.Text}'),{Textbox_enter_modelyear_product.Text},{Textbox_enter_price_product.Text})", conn);
                        adb.SelectCommand.ExecuteNonQuery();
                        adb.SelectCommand = new SqlCommand($"insert into production.stocks(store_id,product_id,quantity) values(3,(select top 1 product_id from production.products order by product_id desc),0)", conn);
                        adb.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("Added successfully");

                        adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by products.product_id desc) as 'RowNumber', products.product_id,product_name,brands.brand_name , categories.category_name,model_year,list_price from production.products join production.brands on products.brand_id= brands.brand_id join production.categories on products.category_id= categories.category_id  ", conn);
                        tab_product.Clear();
                        adb.Fill(tab_product);
                        griddata_all_product.Items.SortDescriptions.Clear();
                        foreach (var column in griddata_all_product.Columns)
                        {
                            column.SortDirection = null;
                        }
                        griddata_all_product.ItemsSource = tab_product.DefaultView;

                        Textbox_enter_productname_product.Text = null;
                        Textbox_enter_brandname_product.Text = null;
                        Textbox_enter_catogaryname_product.Text = null;
                        Textbox_enter_modelyear_product.Text = null;
                        Textbox_enter_price_product.Text = null;
                    }
                }
                else if (answer == MessageBoxResult.No)
                {
                    MessageBox.Show("Canceled successfully");
                    Textbox_enter_productname_product.Text = null;
                    Textbox_enter_brandname_product.Text = null;
                    Textbox_enter_catogaryname_product.Text = null;
                    Textbox_enter_modelyear_product.Text = null;
                    Textbox_enter_price_product.Text = null;
                }
            }
            else if (string.IsNullOrWhiteSpace(Textbox_enter_productname_product.Text) == true ||  string.IsNullOrWhiteSpace(Textbox_enter_brandname_product.Text) == true || string.IsNullOrWhiteSpace(Textbox_enter_modelyear_product.Text) == true || string.IsNullOrWhiteSpace(Textbox_enter_price_product.Text) == true || string.IsNullOrWhiteSpace(Textbox_enter_catogaryname_product.Text) == true)
            {
                MessageBox.Show("Sorry, Faild add new row, Please check product name,brandname, catogary name,model year and price its must have text");

            }
        }


        private void label_cancel_product_MouseLeave(object sender, MouseEventArgs e)
        {
            border_cancel_product.Effect = null;

        }
        private void label_cancel_product_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textbox_enter_productname_product.Text = null;
            Textbox_enter_brandname_product.Text = null;
            Textbox_enter_catogaryname_product.Text = null;
            Textbox_enter_modelyear_product.Text = null;
            Textbox_enter_price_product.Text = null;
        }

        //--------------------------------------------------------gridedat-all_product ---------------------------
        string namepinding_product = "";
        private void griddata_all_product_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            namepinding_product = griddata_all_product.CurrentCell.Column.SortMemberPath;
            var textBox_2 = e.EditingElement as TextBox;
            textBox_2.Text = "";

            if (textBox_2 != null)
            {
                textBox_2.TextChanged += TextBox_2TextChanged1_product;
                textBox_2.PreviewKeyDown += textBox_2privew_product;
                textBox_2.LostFocus += textBox_2lostfocus_product;
                textBox_2.PreviewTextInput += textBox_2textinput_product;
            }
        }

        private void TextBox_2TextChanged1_product(object sender, TextChangedEventArgs e)
        {
            TextBox textBox_2 = sender as TextBox;

            if (namepinding_product == "brand_name")
            {
                if (textBox_2.Text == null || textBox_2.Text == "")
                {
                    griddata_brandname_product.Visibility = Visibility.Hidden;

                    Textbox_enter_brandname_product.Height = 36;
                    Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;
                    Textbox_enter_brandname_product.Effect = null;

                }
                else if (textBox_2.Text != null || textBox_2.Text != "")
                {
                    try
                    {


                        adb.SelectCommand = new SqlCommand($" select distinct top 5  brand_name from production.brands where brand_name like '{textBox_2.Text}%' order by brand_name asc  ", conn);
                        tab_textbrand.Clear();
                        adb.Fill(tab_textbrand);
                        griddata_brandname_product.ItemsSource = tab_textbrand.DefaultView;
                        griddata_brandname_product.Visibility = Visibility.Visible;

                        Textbox_enter_brandname_product.Height = 165;
                        Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Top;
                        System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
                        Textbox_enter_brandname_product.Effect = effect;
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
            else if (namepinding_product == "category_name")
            {
                if (textBox_2.Text == null || textBox_2.Text == "")
                {
                    griddata_catogaryname_product.Visibility = Visibility.Hidden;

                    Textbox_enter_catogaryname_product.Height = 36;
                    Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;
                    Textbox_enter_catogaryname_product.Effect = null;

                }
                else if (textBox_2.Text != null || textBox_2.Text != "")
                {
                    try
                    {


                        adb.SelectCommand = new SqlCommand($"select distinct top 5  category_name from production.categories where category_name like '{textBox_2.Text}%' order by category_name asc  ", conn);
                        tab_textcatogary.Clear();
                        adb.Fill(tab_textcatogary);
                        griddata_catogaryname_product.ItemsSource = tab_textcatogary.DefaultView;
                        griddata_catogaryname_product.Visibility = Visibility.Visible;

                        Textbox_enter_catogaryname_product.Height = 165;
                        Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Top;
                        System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
                        Textbox_enter_catogaryname_product.Effect = effect;
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

        bool key_enter_text_cell_product = false;
        private void textBox_2privew_product(object sender, KeyEventArgs e)
        {
            TextBox textBox_2 = sender as TextBox;
            if (namepinding_product == "brand_name")
            {
                if (griddata_brandname_product.Visibility == Visibility)
                {


                    if (e.Key == Key.Down)
                    {

                        if (griddata_brandname_product.SelectedIndex >= -1 && griddata_brandname_product.SelectedIndex <= 3)
                        {
                            griddata_brandname_product.SelectedIndex = griddata_brandname_product.SelectedIndex + 1;
                        }
                        else if (griddata_brandname_product.SelectedIndex == 4)
                        {
                            griddata_brandname_product.SelectedIndex = 0;
                        }

                    }
                    else if (e.Key == Key.Up)
                    {
                        if (griddata_brandname_product.SelectedIndex <= 4 && griddata_brandname_product.SelectedIndex >= 1)
                        {
                            griddata_brandname_product.SelectedIndex = griddata_brandname_product.SelectedIndex - 1;
                        }
                        else if (griddata_brandname_product.SelectedIndex == 0)
                        {
                            griddata_brandname_product.SelectedIndex = 4;
                        }

                    }
                    else if (e.Key == Key.Enter)
                    {
                        int x = griddata_brandname_product.SelectedIndex;
                        if (x >= 0)
                        {
                            var cellValue = griddata_brandname_product.Items[x] as DataRowView;


                            string value = cellValue[0].ToString();

                            textBox_2.Text = value;
                            griddata_brandname_product.Visibility = Visibility.Hidden;

                            Textbox_enter_brandname_product.Height = 36;
                            Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;
                            Textbox_enter_brandname_product.Effect = null;


                        }

                    }

                }

            }
            else if (namepinding_product == "category_name")
            {
                if (griddata_catogaryname_product.Visibility == Visibility)
                {


                    if (e.Key == Key.Down)
                    {

                        if (griddata_catogaryname_product.SelectedIndex >= -1 && griddata_catogaryname_product.SelectedIndex <= 3)
                        {
                            griddata_catogaryname_product.SelectedIndex = griddata_catogaryname_product.SelectedIndex + 1;
                        }
                        else if (griddata_catogaryname_product.SelectedIndex == 4)
                        {
                            griddata_catogaryname_product.SelectedIndex = 0;
                        }

                    }
                    else if (e.Key == Key.Up)
                    {
                        if (griddata_catogaryname_product.SelectedIndex <= 4 && griddata_catogaryname_product.SelectedIndex >= 1)
                        {
                            griddata_catogaryname_product.SelectedIndex = griddata_catogaryname_product.SelectedIndex - 1;
                        }
                        else if (griddata_catogaryname_product.SelectedIndex == 0)
                        {
                            griddata_catogaryname_product.SelectedIndex = 4;
                        }

                    }
                    else if (e.Key == Key.Enter)
                    {
                        int x = griddata_catogaryname_product.SelectedIndex;
                        if (x >= 0)
                        {
                            var cellValue = griddata_catogaryname_product.Items[x] as DataRowView;


                            string value = cellValue[0].ToString();

                            textBox_2.Text = value;
                            griddata_catogaryname_product.Visibility = Visibility.Hidden;

                            Textbox_enter_catogaryname_product.Height = 36;
                            Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;
                            Textbox_enter_catogaryname_product.Effect = null;


                        }

                    }

                }
            }

            if (e.Key == Key.Enter)
            {
                key_enter_text_cell_product = true;
            }
        }

        private void textBox_2lostfocus_product(object sender, RoutedEventArgs e)
        {
            if (namepinding_product == "brand_name")
            {
                TextBox textBox_2 = sender as TextBox;

                griddata_brandname_product.Visibility = Visibility.Hidden;

                Textbox_enter_brandname_product.Height = 36;
                Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_brandname_product.Effect = null;
            }
            else if (namepinding_product == "category_name")
            {
                TextBox textBox_2 = sender as TextBox;

                griddata_catogaryname_product.Visibility = Visibility.Hidden;

                Textbox_enter_catogaryname_product.Height = 36;
                Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_catogaryname_product.Effect = null;
            }

        }

        private void textBox_2textinput_product(object sender, TextCompositionEventArgs e)
        {

            TextBox textBox_2 = sender as TextBox;

            if (namepinding_product == "model_year")
            {
                if (textBox_2.Text.Length < 4)
                {
                    if (e.Text.Length > 0)
                    {
                        if (char.IsDigit(e.Text, 0) == false)
                        {
                            e.Handled = true;
                        }
                    }
                }
                else if (textBox_2.Text.Length >= 4)
                {
                    e.Handled = true;
                }
            }

            else if (namepinding_product == "list_price")
            {
                if (e.Text.Length > 0)
                {
                    if (!char.IsDigit(e.Text, 0) && e.Text != ".")
                    {
                        e.Handled = true;
                    }

                    else if (e.Text == "." && ((TextBox)sender).Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
            }

        }

        private void griddata_all_product_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_product == true)
            {
                if (griddata_all_product.CurrentCell.Column != null)
                {
                    var namepinding = griddata_all_product.CurrentCell.Column.SortMemberPath;
                    var headercoulmn = griddata_all_product.CurrentCell.Column.Header;
                    var indexcoulmn = griddata_all_product.CurrentCell.Column.DisplayIndex;
                    var cellInfo = griddata_all_product.SelectedCells[indexcoulmn];
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

                    int numberofindex = griddata_all_product.SelectedIndex;
                    var cellValue = griddata_all_product.Items[numberofindex] as DataRowView;
                    string value_id = "";
                    value_id = cellValue[1].ToString();






                    if (string.IsNullOrWhiteSpace(value) == false && namepinding.ToString() != "RowNumber")
                    {

                        var answer = MessageBox.Show("Are you sure that the " + headercoulmn.ToString() + " has changed to " + value, "Warning", MessageBoxButton.YesNo);
                        if (answer == MessageBoxResult.Yes)
                        {
                            int num_row = 0;
                            
                            if (namepinding == "brand_name")
                            {
                                command.CommandText = $"select * from production.brands where brand_name ='{value}'";
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
                                    griddata_all_product.CancelEdit();
                                    MessageBox.Show($"Sorry, The {headercoulmn.ToString()} name not found,Please enter {headercoulmn.ToString()} name is in the data   ");
                                }
                                else if (num_row >= 1)
                                {
                                    adb.SelectCommand = new SqlCommand($" update production.products set brand_id =(select brand_id from production.brands where brand_name ='{value}') where product_id = {value_id}", conn);
                                    adb.SelectCommand.ExecuteNonQuery();
                                    MessageBox.Show("Changes have been applied successfully");




                                    griddata_brandname_product.Visibility = Visibility.Hidden;

                                    Textbox_enter_brandname_product.Height = 36;
                                    Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;
                                    Textbox_enter_brandname_product.Effect = null;

                                    
                                }

                            }


                            else if (namepinding == "category_name")
                            {
                                command.CommandText = $"select * from production.categories where category_name ='{value}'";
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
                                    griddata_all_product.CancelEdit();
                                    MessageBox.Show($"Sorry, The {headercoulmn.ToString()} name not found,Please enter {headercoulmn.ToString()} name is in the data   ");
                                }
                                else if (num_row >= 1)
                                {
                                    adb.SelectCommand = new SqlCommand($" update production.products set category_id =(select category_id from production.categories where category_name ='{value}') where product_id = {value_id}", conn);
                                    adb.SelectCommand.ExecuteNonQuery();
                                    MessageBox.Show("Changes have been applied successfully");




                                    griddata_catogaryname_product.Visibility = Visibility.Hidden;

                                  

                                    Textbox_enter_catogaryname_product.Height = 36;
                                    Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;
                                    Textbox_enter_catogaryname_product.Effect = null;
                                }

                            }
                            else if(namepinding == "product_name")
                            {
                                command.CommandText = $"select * from production.products where product_name='{value}'";
                                using (reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        num_row++;

                                    }
                                    reader.Close();
                                }
                                if(num_row==0)
                                {
                                    adb.SelectCommand = new SqlCommand($" update production.products set product_name ='{value}' where product_id = {value_id}", conn);
                                    adb.SelectCommand.ExecuteNonQuery();
                                    MessageBox.Show("Changes have been applied successfully");
                                }
                                if(num_row>=1)
                                {
                                    griddata_all_product.CancelEdit();
                                    MessageBox.Show("Sorry, The product name is in the data, Please Write product name is't in the data");
                                }
                               
                            }
                            else if (namepinding == "model_year")
                            {
                                adb.SelectCommand = new SqlCommand($" update production.products set model_year ={value} where product_id = {value_id}", conn);
                                adb.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Changes have been applied successfully");
                            }
                            else if (namepinding == "list_price")
                            {
                                adb.SelectCommand = new SqlCommand($" update production.products set list_price ={value} where product_id = {value_id}", conn);
                                adb.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Changes have been applied successfully");
                              
                            }





                        }
                        else if (answer == MessageBoxResult.No)
                        {
                            griddata_all_product.CancelEdit();
                            MessageBox.Show("Changes have been canceled successfully");


                            griddata_brandname_product.Visibility = Visibility.Hidden;
                            griddata_catogaryname_product.Visibility = Visibility.Hidden;

                            Textbox_enter_brandname_product.Height = 36;
                            Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;
                            Textbox_enter_brandname_product.Effect = null;

                            Textbox_enter_catogaryname_product.Height = 36;
                            Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;
                            Textbox_enter_catogaryname_product.Effect = null;


                        }
                    }

                    else if (namepinding.ToString() == "RowNumber")
                    {
                        MessageBox.Show("Sorry, You can't change value this coulmn");
                        griddata_all_product.CancelEdit();
                    }

                    else if (string.IsNullOrWhiteSpace(value) == true && (namepinding.ToString() == "product_name" || namepinding.ToString() == "brand_name" || namepinding.ToString() == "category_name" || namepinding.ToString() == "model_year" || namepinding.ToString() == "list_price"))
                    {
                        MessageBox.Show("Sorry, Please Enter Text");
                        griddata_all_product.CancelEdit();

                    }

                   

                }

                else
                {
                    griddata_all_product.CancelEdit();
                    griddata_all_product.SelectedItem = null;

                    griddata_brandname_product.Visibility = Visibility.Hidden;
                    griddata_catogaryname_product.Visibility = Visibility.Hidden;

                    Textbox_enter_brandname_product.Height = 36;
                    Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;
                    Textbox_enter_brandname_product.Effect = null;

                    Textbox_enter_catogaryname_product.Height = 36;
                    Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;
                    Textbox_enter_catogaryname_product.Effect = null;
                }

                key_enter_text_cell_product = false;
            }

            else if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_product == false)
            {
                griddata_all_product.CancelEdit();

                griddata_brandname_product.Visibility = Visibility.Hidden;
                griddata_catogaryname_product.Visibility = Visibility.Hidden;

                Textbox_enter_brandname_product.Height = 36;
                Textbox_enter_brandname_product.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_brandname_product.Effect = null;

                Textbox_enter_catogaryname_product.Height = 36;
                Textbox_enter_catogaryname_product.VerticalContentAlignment = VerticalAlignment.Center;
                Textbox_enter_catogaryname_product.Effect = null;
            }
        }

        

        private void gride_product_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (gride_product.Visibility == Visibility.Visible)
            {
                try
                {
                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by products.product_id asc) as 'RowNumber', products.product_id,product_name,brands.brand_name , categories.category_name,model_year,list_price from production.products join production.brands on products.brand_id= brands.brand_id join production.categories on products.category_id= categories.category_id ", conn);
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

            }
            else if (gride_product.Visibility == Visibility.Hidden)
            {
                griddata_all_product.IsReadOnly = true;
                
            }
        }


        //--------------------------------------- 2-Brand---------------------------------------------------

        //---------------------------------------Text box search brand-------------------------------------
        private void textbox_search_brand_MouseEnter(object sender, MouseEventArgs e)
        {

            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_brand.Effect = effectbo;
            effectbo.ShadowDepth = 1;
            textbox_search_brand.BorderThickness = new Thickness(0);
        }

        private void textbox_search_brand_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_brand.Effect = null;

        }

        private void label_search_brand_1_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_brand.Effect = effectbo;
            effectbo.ShadowDepth = 1;
        }

        private void label_search_brand_1_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_brand.Effect = null;

        }

        private void textbox_search_brand_TextChanged(object sender, TextChangedEventArgs e)
        {
            label_search_brand.Visibility = Visibility.Hidden;
            if (textbox_search_brand.Text == null || textbox_search_brand.Text == "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand("select ROW_NUMBER() over(order by  brands.brand_id asc) as 'RowNumber', brands.brand_id,brands.brand_name,count(product_name) as 'num_of_product_brand' from production.brands left join production.products on brands.brand_id= products.brand_id group by brands.brand_id,brands.brand_name ", conn);
                    tab_brand.Clear();
                    adb.Fill(tab_brand);
                    griddata_all_brand.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_brand.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_brand.ItemsSource = tab_brand.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (textbox_search_brand.Text != null || textbox_search_brand.Text != "")
            {

                try
                {
                    adb.SelectCommand = new SqlCommand($"select ROW_NUMBER() over(order by brands.brand_name asc) as 'RowNumber',  brands.brand_id,brands.brand_name,count(product_name) as 'num_of_product_brand' from production.brands left join production.products on brands.brand_id= products.brand_id where brands.brand_name Like '{textbox_search_brand.Text}%' group by brands.brand_id,brands.brand_name  ", conn);
                    tab_brand.Clear();
                    adb.Fill(tab_brand);
                    griddata_all_brand.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_brand.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_brand.ItemsSource = tab_brand.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
               
            }


        }

        private void textbox_search_brand_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox_search_brand.Text == " " || textbox_search_brand.Text == "")
            {
                label_search_brand.Visibility = Visibility.Visible;

            }
        }


        //---------------------------------------Text box entery brand-------------------------------------
        private void Textbox_enter_productname_brand_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_productname_brand.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_productname_brand_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_productname_brand.Effect = null;

        }



        //---------------------------------------Button add,update,cancel brand-------------------------------------

        private void label_add_brand_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_add_brand.Effect = effect;
            effect.ShadowDepth = 1;
        }


        private void label_cancel_brand_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_cancel_brand.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_add_brand_MouseLeave(object sender, MouseEventArgs e)
        {
            border_add_brand.Effect = null;

        }
        private void label_add_brand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Textbox_enter_productname_brand.Text) == false )
            {
                int num_row = 0;
                command.CommandText = $"select * from production.brands where brand_name='{Textbox_enter_productname_brand.Text}'";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        num_row++;

                    }
                    reader.Close();
                }

                if (string.IsNullOrWhiteSpace(Textbox_enter_productname_brand.Text) == false)
                {
                    var answer = MessageBox.Show("Are you sure add new row ", "Warning", MessageBoxButton.YesNo);
                    if (answer == MessageBoxResult.Yes)
                    {
                        if (num_row == 0)
                        {
                            adb.SelectCommand = new SqlCommand($" insert into production.brands(brand_name) values('{Textbox_enter_productname_brand.Text}')", conn);
                            adb.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Added successfully");

                            adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by brands.brand_id desc) as 'RowNumber',  brands.brand_id,brands.brand_name,count(product_name) as 'num_of_product_brand' from production.brands left join production.products on brands.brand_id= products.brand_id group by brands.brand_id,brands.brand_name  ", conn);
                            tab_brand.Clear();
                            adb.Fill(tab_brand);
                            griddata_all_brand.Items.SortDescriptions.Clear();
                            foreach (var column in griddata_all_brand.Columns)
                            {
                                column.SortDirection = null;
                            }
                            griddata_all_brand.ItemsSource = tab_brand.DefaultView;

                            Textbox_enter_productname_brand.Text = null;
                            

                        }

                        else if (num_row >= 1)
                        {
                            MessageBox.Show("Sorry, Faild add new row, The brand name is in the data, Change the brand name and try again ");
                        }

                    }
                    else if (answer == MessageBoxResult.No)
                    {
                        MessageBox.Show("Canceled successfully");
                        Textbox_enter_productname_brand.Text = null;
                        
                    }
                }
                
                

            }
            else if (string.IsNullOrWhiteSpace(Textbox_enter_productname_brand.Text) == true )
            {
                MessageBox.Show("Sorry, Faild add new row, Please check brand name its must have text");
            }
        }


        private void label_cancel_brand_MouseLeave(object sender, MouseEventArgs e)
        {
            border_cancel_brand.Effect = null;

        }
        private void label_cancel_brand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textbox_enter_productname_brand.Text=null;
        }

        //--------------------------------------------------------gridedat-all_brand ---------------------------

        string namepinding_brand = "";
        private void griddata_all_brand_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            namepinding_brand = griddata_all_brand.CurrentCell.Column.SortMemberPath;
            var textBox_2 = e.EditingElement as TextBox;
            textBox_2.Text = "";
            textBox_2.PreviewKeyDown += textBox_2privew_brand;

        }

        bool key_enter_text_cell_brand = false;
        private void textBox_2privew_brand(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                key_enter_text_cell_brand = true;
            }
        }

        private void griddata_all_brand_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_brand == true)
            {
                if (griddata_all_brand.CurrentCell.Column != null)
                {
                    var namepinding = griddata_all_brand.CurrentCell.Column.SortMemberPath ;
                    var headercoulmn = griddata_all_brand.CurrentCell.Column.Header ;
                    var indexcoulmn = griddata_all_brand.CurrentCell.Column.DisplayIndex;
                    var cellInfo = griddata_all_brand.SelectedCells[indexcoulmn] ;
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

                    int numberofindex = griddata_all_brand.SelectedIndex;
                    var cellValue = griddata_all_brand.Items[numberofindex] as DataRowView;
                    string value_id = "";
                    value_id = cellValue[1].ToString();
                    

                   
                    if (string.IsNullOrWhiteSpace(value)==false && namepinding.ToString()!= "RowNumber" && namepinding.ToString() != "num_of_product_brand")
                    {
                        int num_row = 0;
                        if (namepinding == "brand_name")
                        {
                            command.CommandText = $"select * from production.brands where brand_name='{value}'";
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
                                adb.SelectCommand = new SqlCommand($"update production.brands set brand_name ='{value}' where brand_id ={value_id}", conn);
                                adb.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Changes have been applied successfully");
   
                            }
                            else if (num_row >= 1)
                            {
                                griddata_all_brand.CancelEdit();
                                MessageBox.Show("Sorry, The brand name is in the data");
                            }



                        }
                        else if (answer == MessageBoxResult.No)
                        {
                            griddata_all_brand.CancelEdit();
                            MessageBox.Show("Changes have been canceled successfully");


                        }
                    }

                    else if (namepinding.ToString() == "RowNumber" || namepinding.ToString() == "num_of_product_brand")
                    {
                        
                        griddata_all_brand.CancelEdit();
                        MessageBox.Show("Sorry, You can't change value this coulmn");

                    }

                    else if (string.IsNullOrWhiteSpace(value) == true && namepinding.ToString() == "brand_name")
                    {
                        MessageBox.Show("Sorry, Please Enter Text");
                        griddata_all_brand.CancelEdit();

                    }

                }

                else
                {
                    griddata_all_brand.CancelEdit();
                    griddata_all_brand.SelectedItem = null;

                }

                key_enter_text_cell_brand= false;

            }

            else if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_brand == false)
            {
                griddata_all_brand.CancelEdit();
            }
        }

       

        private void gride_brand_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (gride_brand.Visibility == Visibility.Visible)
            {
                try
                {
                    adb.SelectCommand = new SqlCommand("select ROW_NUMBER() over(order by brands.brand_id asc) as 'RowNumber',  brands.brand_id,brands.brand_name,count(product_name) as 'num_of_product_brand' from production.brands left join production.products on brands.brand_id= products.brand_id group by brands.brand_id,brands.brand_name ", conn);
                    tab_brand.Clear();
                    adb.Fill(tab_brand);
                    griddata_all_brand.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_brand.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_brand.ItemsSource = tab_brand.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (gride_brand.Visibility == Visibility.Hidden)
            {
                griddata_all_brand.IsReadOnly = true;

            }
        }

        //--------------------------------------- 3-Category---------------------------------------------------

        //---------------------------------------Text box search category-------------------------------------

        private void textbox_search_category_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_category.Effect = effectbo;
            effectbo.ShadowDepth = 1;
            textbox_search_category.BorderThickness = new Thickness(0);
        }

        private void textbox_search_category_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_category.Effect = null;
        }

        private void label_search_category_1_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_category.Effect = effectbo;
            effectbo.ShadowDepth = 1;
        }

        private void label_search_category_1_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_category.Effect = null;
        }

        private void textbox_search_category_TextChanged(object sender, TextChangedEventArgs e)
        {
            label_search_category.Visibility = Visibility.Hidden;
            if (textbox_search_category.Text == null || textbox_search_category.Text == "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by categories.category_id asc) as 'RowNumber',  categories.category_id,categories.category_name,count(product_name) as 'num_of_product_category' from production.categories left join production.products on categories.category_id= products.category_id group by categories.category_id,categories.category_name ", conn);
                    tab_catogary.Clear();
                    adb.Fill(tab_catogary);
                    griddata_all_category.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_category.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_category.ItemsSource = tab_catogary.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (textbox_search_category.Text != null || textbox_search_category.Text != "")
            {

                try
                {
                    adb.SelectCommand = new SqlCommand($" select ROW_NUMBER() over(order by categories.category_name asc) as 'RowNumber',  categories.category_id,categories.category_name,count(product_name) as 'num_of_product_category' from production.categories left join production.products on categories.category_id= products.category_id where categories.category_name Like '{textbox_search_category.Text}%' group by categories.category_id,categories.category_name   ", conn);
                    tab_catogary.Clear();
                    adb.Fill(tab_catogary);
                    griddata_all_category.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_category.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_category.ItemsSource = tab_catogary.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

        }

        private void textbox_search_category_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox_search_category.Text == " " || textbox_search_category.Text == "")
            {
                label_search_category.Visibility = Visibility.Visible;

            }
        }

        //---------------------------------------Text box entery category-------------------------------------
        private void Textbox_enter_productname_category_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            Textbox_enter_productname_category.Effect = effect;
            effect.ShadowDepth = 1;
            effect.BlurRadius = 10;
            effect.Color = Color.FromArgb(0xFF, 0x00, 0xFF, 0xDF);
        }

        private void Textbox_enter_productname_category_LostFocus(object sender, RoutedEventArgs e)
        {
            Textbox_enter_productname_category.Effect = null;
        }


        //---------------------------------------Button add,update,cancel category-------------------------------------

        private void label_add_category_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_add_category.Effect = effect;
            effect.ShadowDepth = 1;
        }

        
        private void label_cancel_category_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_cancel_category.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_add_category_MouseLeave(object sender, MouseEventArgs e)
        {
            border_add_category.Effect = null;

        }
        private void label_add_category_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Textbox_enter_productname_category.Text) == false)
            {
                int num_row = 0;
                command.CommandText = $"select * from production.categories where category_name='{Textbox_enter_productname_category.Text}'";
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        num_row++;

                    }
                    reader.Close();
                }

                if (string.IsNullOrWhiteSpace(Textbox_enter_productname_category.Text) == false)
                {
                    var answer = MessageBox.Show("Are you sure add new row ", "Warning", MessageBoxButton.YesNo);
                    if (answer == MessageBoxResult.Yes)
                    {
                        if (num_row == 0)
                        {
                            adb.SelectCommand = new SqlCommand($"insert into production.categories(category_name) values('{Textbox_enter_productname_category.Text}')", conn);
                            adb.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Added successfully");

                            adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by categories.category_id desc) as 'RowNumber',  categories.category_id,categories.category_name,count(product_name) as 'num_of_product_category' from production.categories left join production.products on categories.category_id= products.category_id group by categories.category_id,categories.category_name   ", conn);
                            tab_catogary.Clear();
                            adb.Fill(tab_catogary);
                            griddata_all_category.Items.SortDescriptions.Clear();
                            foreach (var column in griddata_all_category.Columns)
                            {
                                column.SortDirection = null;
                            }
                            griddata_all_category.ItemsSource = tab_catogary.DefaultView;

                            Textbox_enter_productname_category.Text = null;


                        }

                        else if (num_row >= 1)
                        {
                            MessageBox.Show("Sorry, Faild add new row, The catogary name is in the data, Change the brand name and try again ");
                        }

                    }
                    else if (answer == MessageBoxResult.No)
                    {
                        MessageBox.Show("Canceled successfully");
                        Textbox_enter_productname_category.Text = null;

                    }
                }



            }
            else if (string.IsNullOrWhiteSpace(Textbox_enter_productname_category.Text) == true)
            {
                MessageBox.Show("Sorry, Faild add new row, Please check catogary name its must have text");
            }
        }

        private void label_cancel_category_MouseLeave(object sender, MouseEventArgs e)
        {
            border_cancel_category.Effect = null;

        }
        private void label_cancel_category_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textbox_enter_productname_category.Text = null;
        }
       

        //--------------------------------------------------------gridedat-all_catogary ---------------------------
        string namepinding_category = "";
        private void griddata_all_category_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            namepinding_category = griddata_all_category.CurrentCell.Column.SortMemberPath;
            var textBox_2 = e.EditingElement as TextBox;
            textBox_2.Text = "";
            textBox_2.PreviewKeyDown += textBox_2privew_category;
        }

        bool key_enter_text_cell_category = false;
        private void textBox_2privew_category(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                key_enter_text_cell_category = true;
            }
        }

        private void griddata_all_category_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_category == true)
            {
                if (griddata_all_category.CurrentCell.Column != null)
                {
                    var namepinding = griddata_all_category.CurrentCell.Column.SortMemberPath;
                    var headercoulmn = griddata_all_category.CurrentCell.Column.Header;
                    var indexcoulmn = griddata_all_category.CurrentCell.Column.DisplayIndex;
                    var cellInfo = griddata_all_category.SelectedCells[indexcoulmn];
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

                    int numberofindex = griddata_all_category.SelectedIndex;
                    var cellValue = griddata_all_category.Items[numberofindex] as DataRowView;
                    string value_id = "";
                    value_id = cellValue[1].ToString();



                    if (string.IsNullOrWhiteSpace(value) == false && namepinding.ToString() != "RowNumber" && namepinding.ToString() != "num_of_product_category")
                    {
                        int num_row = 0;
                        if (namepinding == "category_name")
                        {
                            command.CommandText = $"select * from production.categories where category_name='{value}'";
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
                                adb.SelectCommand = new SqlCommand($"update production.categories set category_name ='{value}' where category_id ={value_id}", conn);
                                adb.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Changes have been applied successfully");

                            }
                            else if (num_row >= 1)
                            {
                                griddata_all_category.CancelEdit();
                                MessageBox.Show("Sorry, The catogary name is in the data");
                            }



                        }
                        else if (answer == MessageBoxResult.No)
                        {
                            griddata_all_category.CancelEdit();
                            MessageBox.Show("Changes have been canceled successfully");


                        }
                    }
                    
                    else if (namepinding.ToString() == "RowNumber" || namepinding.ToString() == "num_of_product_category")
                    {

                        griddata_all_category.CancelEdit();
                        MessageBox.Show("Sorry, You can't change value this coulmn");

                    }

                    else if (string.IsNullOrWhiteSpace(value) == true && namepinding.ToString() == "category_name")
                    {
                        MessageBox.Show("Sorry, Please Enter Text");
                        griddata_all_category.CancelEdit();

                    }

                }

                else
                {
                    griddata_all_category.CancelEdit();
                    griddata_all_category.SelectedItem = null;

                }

                key_enter_text_cell_category = false;

            }

            else if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_category == false)
            {
                griddata_all_category.CancelEdit();
            }
        }

        

        private void gride_category_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (gride_category.Visibility == Visibility.Visible)
            {
                try
                {
                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by categories.category_id asc) as 'RowNumber', categories.category_id,categories.category_name,count(product_name) as 'num_of_product_category' from production.categories left join production.products on categories.category_id= products.category_id group by categories.category_id,categories.category_name ", conn);
                    tab_catogary.Clear();
                    adb.Fill(tab_catogary);
                    griddata_all_category.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_category.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_category.ItemsSource = tab_catogary.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            else if (gride_category.Visibility == Visibility.Hidden)
            {
                griddata_all_category.IsReadOnly = true;

            }
        }


        //--------------------------------------- 4-Stock---------------------------------------------------

        //---------------------------------------Text box search stock-------------------------------------


        private void textbox_search_stock_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_stock.Effect = effectbo;
            effectbo.ShadowDepth = 1;
            textbox_search_stock.BorderThickness = new Thickness(0);
        }

        private void textbox_search_stock_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_stock.Effect = null;

        }

        private void label_search_stock_1_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effectbo = new System.Windows.Media.Effects.DropShadowEffect();
            border_search_stock.Effect = effectbo;
            effectbo.ShadowDepth = 1;
        }

        private void label_search_stock_1_MouseLeave(object sender, MouseEventArgs e)
        {
            border_search_stock.Effect = null;

        }

        private void textbox_search_stock_TextChanged(object sender, TextChangedEventArgs e)
        {
            label_search_stock.Visibility = Visibility.Hidden;
            if (textbox_search_stock.Text == null || textbox_search_stock.Text == "")
            {
                try
                {

                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by products.product_id asc) as 'RowNumber',  products.product_id,product_name,quantity from production.stocks join production.products on stocks.product_id= products.product_id where  store_id=3", conn);
                    tab_stock.Clear();
                    adb.Fill(tab_stock);
                    griddata_all_stock.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_stock.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_stock.ItemsSource = tab_stock.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (textbox_search_stock.Text != null || textbox_search_stock.Text != "")
            {

                try
                {
                    adb.SelectCommand = new SqlCommand($" select ROW_NUMBER() over(order by product_name asc ) as 'RowNumber',  products.product_id,product_name,quantity from production.stocks join production.products on stocks.product_id= products.product_id where  store_id=3 and product_name Like '{textbox_search_stock.Text}%'    ", conn);
                    tab_stock.Clear();
                    adb.Fill(tab_stock);
                    griddata_all_stock.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_stock.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_stock.ItemsSource = tab_stock.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void textbox_search_stock_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox_search_stock.Text == " " || textbox_search_stock.Text == "")
            {
                label_search_stock.Visibility = Visibility.Visible;

            }
        }

        
        //--------------------------------------------------------gridedat-all_stock ---------------------------
        string namepinding_stock = "";
        private void griddata_all_stock_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            namepinding_stock = griddata_all_stock.CurrentCell.Column.SortMemberPath;
            var textBox_2 = e.EditingElement as TextBox;
            textBox_2.Text = "";

            if (textBox_2 != null)
            {
                textBox_2.PreviewTextInput += textBox_2textinput_stock;
                textBox_2.PreviewKeyDown += textBox_2privew_stock;
            }
        }

        bool key_enter_text_cell_stock = false;
        private void textBox_2privew_stock(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                key_enter_text_cell_stock = true;
            }
        }

        private void textBox_2textinput_stock(object sender, TextCompositionEventArgs e)
        {

            TextBox textBox_2 = sender as TextBox;
            if (namepinding_stock == "quantity")
            {
                if (char.IsDigit(e.Text, 0) == false )
                {
                    e.Handled = true;
                } 
            }
        }

        private void griddata_all_stock_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_stock == true)
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



                    if (string.IsNullOrWhiteSpace(value) == false && namepinding.ToString() != "RowNumber" && namepinding.ToString() != "product_name")
                    {
                       


                        var answer = MessageBox.Show("Are you sure that the " + headercoulmn.ToString() + " has changed to " + value, "Warning", MessageBoxButton.YesNo);
                        if (answer == MessageBoxResult.Yes)
                        {
                           
                            adb.SelectCommand = new SqlCommand($"update production.stocks set quantity = {value} where product_id= {value_id} and store_id=3 ", conn);
                            adb.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Changes have been applied successfully");

                        }
                        else if (answer == MessageBoxResult.No)
                        {
                            griddata_all_stock.CancelEdit();
                            MessageBox.Show("Changes have been canceled successfully");


                        }
                    }

                    else if (namepinding.ToString() == "RowNumber" || namepinding.ToString() == "product_name")
                    {

                        griddata_all_stock.CancelEdit();
                        MessageBox.Show("Sorry, You can't change value this coulmn");

                    }

                    else if (string.IsNullOrWhiteSpace(value) == true && namepinding.ToString() == "quantity")
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

                key_enter_text_cell_stock = false;

            }

            else if (e.EditAction == DataGridEditAction.Commit && key_enter_text_cell_stock == false)
            {
                griddata_all_stock.CancelEdit();
            }
        }

       

        private void gride_stock_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (gride_stock.Visibility == Visibility.Visible)
            {
                try
                {
                    adb.SelectCommand = new SqlCommand(" select ROW_NUMBER() over(order by products.product_id asc) as 'RowNumber',  products.product_id,product_name,quantity from production.stocks join production.products on stocks.product_id= products.product_id where  store_id=3  ", conn);
                    tab_stock.Clear();
                    adb.Fill(tab_stock);
                    griddata_all_stock.Items.SortDescriptions.Clear();
                    foreach (var column in griddata_all_stock.Columns)
                    {
                        column.SortDirection = null;
                    }
                    griddata_all_stock.ItemsSource = tab_stock.DefaultView;
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
