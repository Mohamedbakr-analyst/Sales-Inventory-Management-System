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
using System.Globalization;
using System.Data.SqlClient;
using System.Data;
using System.IO;



namespace BikeStore10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_44330760199;Integrated Security=True");

        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_2;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        SqlDataAdapter adb = new SqlDataAdapter();
        DataTable tab_user = new DataTable();


        public MainWindow()
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

            textbox_1.Focus();
            textbox_1.BorderThickness = new Thickness(0);


        }

        private void Window_Closed(object sender, EventArgs e)
        {
            conn.Close();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            InputLanguageManager.Current.CurrentInputLanguage = CultureInfo.GetCultureInfo("en-US");
            if (e.KeyboardDevice.IsKeyDown(Key.OemQuotes))
            {
                e.Handled = true;
            }
        }



        private void textbox_2_MouseEnter(object sender, MouseEventArgs e)
        {
            textbox_2.BorderThickness = new Thickness(0);
            

        }

     

        private void textbox_1_MouseEnter_1(object sender, MouseEventArgs e)
        {
            textbox_1.BorderThickness = new Thickness(0);

        }

        private void textbox_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            lable_1.Visibility = Visibility.Hidden;
        }


        private void textbox_1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox_1.Text == " " || textbox_1.Text == "")
            {
                lable_1.Visibility = Visibility.Visible;

                lable_1.Content = "Write name...";

            }
        }

      

        private void textbox_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            lable_2.Visibility = Visibility.Hidden;
        }
        private void textbox_2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox_2.Text == " " || textbox_2.Text == "")
            {
                lable_2.Visibility = Visibility.Visible;
                lable_2.Content = "Write password...";

            }
        }

     

        private void textbox_1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down|| e.Key ==Key.Enter)
            {
                textbox_2.Focus();
                textbox_2.BorderThickness = new Thickness(0);

            }
        }

        private void textbox_2_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                textbox_1.Focus();
                textbox_1.BorderThickness = new Thickness(0);

            }

            else if (e.Key == Key.Enter)
            {

                label_signin_MouseLeftButtonDown(null, null);
            }


        }

        private void label_signin_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowEffect effect = new System.Windows.Media.Effects.DropShadowEffect();
            border_signin.Effect = effect;
            effect.ShadowDepth = 1;
        }

        private void label_signin_MouseLeave(object sender, MouseEventArgs e)
        {
            border_signin.Effect = null;
        }


    
        private void label_signin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            homebage_1 homebage_1_1 = new homebage_1();
            Saels_1 saels_1_1 = new Saels_1();
            Products_1 products_1_1 = new Products_1();
            Customer_1 customer_1_1 = new Customer_1();
            Rebort_1 rebort_1_1 = new Rebort_1();
            User_1 user_1_1 = new User_1();



            int num_row_user = 0;
            command.CommandText = $"select * from sales.add_user where user_name = @va_1";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@va_1", textbox_1.Text);
            using (reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    num_row_user++;

                }
                reader.Close();
            }

            if (num_row_user >= 1)
            {
                int id_normal = 0;
                string password = null;
                string user_name = null;
                string image = null;
                command.CommandText = $"select * from sales.add_user where user_name = @va_1";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@va_1", textbox_1.Text);
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_normal = int.Parse(reader["id"].ToString());
                        password = reader["password"].ToString();
                        user_name = reader["user_name"].ToString();
                        image = reader["image_source"].ToString();
                    }
                    reader.Close();
                }

                if (password == textbox_2.Text)
                {

                    if (File.Exists(Environment.CurrentDirectory + image))
                    {
                        using (FileStream imgFileStream = new FileStream(Environment.CurrentDirectory + image, FileMode.Open, FileAccess.Read))
                        {

                            BitmapImage bitmapImage = new BitmapImage();
                            bitmapImage.BeginInit();
                            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                            bitmapImage.StreamSource = imgFileStream;
                            bitmapImage.EndInit();
                            
                           TextReference.StoredBitmapImage = bitmapImage;
                        }

                    }

                    TextReference.StoredText ="Hello,"+user_name;

                    homebage_1_1.Show();
                    this.Close();

                }
                else if (password != textbox_2.Text)
                {
                   text_meesage.Text= $"Sorry, Enter correct password of user name {textbox_1.Text}";
                    text_meesage.Visibility = Visibility.Visible;
                    border_meesage.Visibility = Visibility.Visible;
                }
            }

            else if (num_row_user == 0)
            {
                text_meesage.Text = "Sorry, The user name dont't find at normal and acceas users data ";
                text_meesage.Visibility = Visibility.Visible;
                border_meesage.Visibility = Visibility.Visible;




            }




        }

     

        
    }
    public class TextReference
    {
        public static string StoredText { get; set; }

        private static BitmapImage _storedBitmapImage;

        public static BitmapImage StoredBitmapImage
        {
            get { return _storedBitmapImage; }
            set { _storedBitmapImage = value; }
        }
    }
}
