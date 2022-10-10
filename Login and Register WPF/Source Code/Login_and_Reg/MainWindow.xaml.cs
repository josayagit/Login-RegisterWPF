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
using System.Data.SqlClient;
using System.Data;

namespace Login_and_Reg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Connection Succeeded");
                SqlConnection conn = new SqlConnection(@"Data Source=RCGPBR308PC11\SQLEXPRESS;Initial Catalog=Login_and_Reg;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Login(username,Email,Password)values(@username,@Email,@Password)",conn);
                cmd.Parameters.AddWithValue("@username",BOX1.Text);
                cmd.Parameters.AddWithValue("@Email", BOX2.Text);
                cmd.Parameters.AddWithValue("@Password", BOX3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Registered");
            }
            catch 
            {
                MessageBox.Show("Registration errror : Connectior Error");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            BOX1.Clear();
            BOX2.Clear();
            BOX3.Clear();
        }

        private void BOX3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BOX2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login LG = new Login();
            LG.Show();
        }
    }
}
