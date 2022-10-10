using System;
using System.Collections.Generic;
using System.Text;
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

namespace Login_and_Reg
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            box1.Clear();
            box2.Clear();
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Connectinng.......");
                SqlConnection conn = new SqlConnection(@"Data Source=RCGPBR308PC11\SQLEXPRESS;Initial Catalog=Login_and_Reg;Integrated Security=True");
                conn.Open();
                MessageBox.Show("Connection succeeded");
                MessageBox.Show("Login in.........");


                String query = "SELECT * FROM Login where Email ='" + box1.Text + "'and Password='" + box2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Error Login in");
                }
            }
            catch
            {
                MessageBox.Show("Error Login: Connection or Login error");
            }
           
        }
    }
}
