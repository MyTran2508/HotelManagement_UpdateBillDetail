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
using BUS.Controllers;

namespace HotelManagement.Forms
{
    public partial class BillForm : Form
    {
        ReservationController rec = null;
        public BillForm()
        {
            InitializeComponent();
            this.rec = new ReservationController();
        }
        private void BillForm_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new HomeForm());
        }

        private void BtnBillDetail_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new BillDetailForm());    
        }
    }
}
