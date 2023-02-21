using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
namespace nxtologinsystem
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=nxtodatabase;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private void main_Load(object sender, EventArgs e)
        {

        }
        private void nxtologin()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM nxtosignup", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["ID"].ToString() == ıdtext.Text.ToString() && dr["Pass"].ToString() == passtext.Text.ToString())
                {
                    MessageBox.Show("SUCCESFULLY");
                }
                else
                {
                    MessageBox.Show("Please Check your Username and Password", "Error",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error
                   );
                }
            }
            conn.Close();
        }
        private void txtcontrol() //Bu Bölümde Login Denetimi Yapılmaktadır.
        {
            if (ıdtext.Text == "ID" && passtext.Text == "Password")
            {
                MessageBox.Show("Please Check your Username and Password", "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                    );
            }
            else if (ıdtext.Text == "" && passtext.Text == "")
            {
                MessageBox.Show("Please Check your Username and Password", "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                    );
            }
            else if (ıdtext.Text.Length < 8 && passtext.Text.Length < 8)
            {
                MessageBox.Show("Please Check your Username and Password", "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void ıdtext_Click(object sender, EventArgs e)
        {
            ıdtext.Clear();
            ıdtext.Text = "";
        }

        private void passtext_Click(object sender, EventArgs e)
        {
            passtext.Clear();
            passtext.Text = "";
        }

        private void passtext_Enter(object sender, EventArgs e)
        {
            passtext.Clear();
            passtext.PasswordChar = '*';
        }

        private void signlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//signUpForm' a geçiş
        {
            signUpForm frm2 = new signUpForm();
            frm2.Show();
            this.Hide();
        }


        private void main_Click(object sender, EventArgs e)//Form Üzerine basıldığındaki Koşul
        {
            ıdtext.Text = "ID";
            passtext.PasswordChar = '\0';//PasswordCharımıza Boş Değer Atama
            passtext.Text = "Password";
        }


        private void loginbtn_Click(object sender, EventArgs e)
        {
            nxtologin();
            txtcontrol();//txtcontrol Classımızı Bu Bölümde Çağırıyoruz. Sebebi ise butona bastığımızda aktif olması.
        }
    }
}
