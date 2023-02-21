using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace nxtologinsystem
{
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=nxtodatabase;Integrated Security=True");
        SqlCommand cmd;
        private void signUpForm_Click(object sender, EventArgs e)
        {
            ıdntext.Text = "ID";
            emailtext.Text = "Email";
            passwordtext.PasswordChar = '\0';
            passwordtext.Text = "Password";
            passreptext.PasswordChar = '\0';
            passreptext.Text = "Password Repeat";
        }
        private void signUpForm_Load(object sender, EventArgs e)
        {
            ıdntext.MaxLength = 8;
            passwordtext.MaxLength = 8;
            passreptext.MaxLength = 8;
        }
        private void loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            main frm1 = new main();
            frm1.Show();
            this.Hide();
        }
        private void nxtosignup()
        {
            string ıd = ıdntext.Text;
            string email = emailtext.Text;
            string password = passwordtext.Text;
            string passwordrepeat = passreptext.Text;
            conn.Open();
            cmd = new SqlCommand("INSERT INTO nxtosignup(ID,Email,Pass,Passrep) VALUES ('" + ıd + "','" + email + "','" + password + "','" + passwordrepeat + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void controltovalidate()
        {
            //ID Control
            if (ıdntext.Text.Length == 8)
            {
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;
            }
            //Password Control
            if (passwordtext.Text.Length == 8)
            {
                label7.Visible = false;
            }
            else
            {
                label7.Visible = true;
            }
            //Password Repeat Control
            if (passwordtext.Text == passreptext.Text)
            {
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
        }

        private void ıdntext_TextChanged(object sender, EventArgs e)
        {
            controltovalidate();
        }
        private void passwordtext_Click(object sender, EventArgs e)
        {
            passwordtext.Clear();
            passwordtext.PasswordChar = '*';
        }

        private void passreptext_Click(object sender, EventArgs e)
        {
            passreptext.Clear();
            passreptext.PasswordChar = '*';
        }

        private void ıdntext_Click(object sender, EventArgs e)
        {
            ıdntext.Clear();
        }

        private void emailtext_Click(object sender, EventArgs e)
        {
            emailtext.Clear();
        }

        private void signbutton_Click(object sender, EventArgs e)
        {
            if (passwordtext.Text != passreptext.Text)
            {
                label8.Visible = true;
                MessageBox.Show("Password Check", "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                label8.Visible = false;
                controltovalidate();
                nxtosignup();
                MessageBox.Show("Succesfull!", "OK!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }
    }
}
