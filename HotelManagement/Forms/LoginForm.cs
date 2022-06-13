using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS.Controllers;
using DTO.Entities;
using DTO;

namespace HotelManagement.Forms
{
    public partial class LoginForm : Form
    {
        bool flagHidePassword = true;
        AccountController ac = null;
        public LoginForm()
        {
            InitializeComponent();
            txtPassWord.PasswordChar = '●';
            this.ac = new AccountController();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Close();
            /*try
            {

                string username = txtUserName.Text;
                string password = txtPassWord.Text;

                string error = "";
                bool iscreated = ac.HandleLogin(username, password, ref error);
                if (iscreated)
                {
                    this.Hide();
                    HomeForm homeForm = new HomeForm();
                    homeForm.Show();
                    this.Close();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi vui lòng kiểm tra và thử lại");
            }*/
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.flagHidePassword = !this.flagHidePassword;

            if(!this.flagHidePassword)
            {
                this.label3.Text = "Ẩn";
                this.txtPassWord.PasswordChar = '\0';
            }
            else
            {
                this.label3.Text = "Hiện";
                txtPassWord.PasswordChar = '●';
            }
        }
    }
}
