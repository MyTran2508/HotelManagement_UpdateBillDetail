using HotelManagement.Resources.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }


        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var lg = new LoginForm();
            Common.ShowForm(this, lg);
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            var cusForm = new CustomerForm();
            Common.ShowForm(this, cusForm);
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            var empForm = new EmployeeForm();
            Common.ShowForm(this, empForm);
        }

        private void BtnRooms_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new RoomForm());

        }

        private void BtnReservations_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new ReservationForm());
        }

        private void BtnAccounts_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new AccountForm());
        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new ServiceForm());
        }

        private void BtnBills_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new BillForm());
        }
    }
}
