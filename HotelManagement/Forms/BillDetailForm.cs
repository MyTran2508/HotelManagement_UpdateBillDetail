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
    public partial class BillDetailForm : Form
    {
        BillController bc = null;
        ServiceController sc = null;
        BillDetailController bdc = null;
        ReservationController rec = null;
        public BillDetailForm()
        {
            InitializeComponent();
            this.bc = new BillController();
            this.sc = new ServiceController();
            this.bdc = new BillDetailController();
            this.rec = new ReservationController();
        }
        // Fill ComboBox Service
        private void FillComboBoxServices()
        {
            string error = "";
            var services = sc.GetAllServices(ref error);
            DataTable dt = Common.FillDataTable(services);
            if (dt != null)
            {
                CBServiceId.DataSource = dt;
                CBServiceId.DisplayMember = "Name";
                CBServiceId.ValueMember = "Id";
            }
        }

        // Fill ComboBox Bill
        private void FillComboBoxBills()
        {
            string error = "";
            var bills = bc.GetAllBills(ref error);
            DataTable dt = Common.FillDataTableBill(bills);
            if (dt != null)
            {
                CBBillId.DataSource = dt;
                CBBillId.DisplayMember = "Id";
                CBBillId.ValueMember = "Id";
            }
        }
      
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new HomeForm());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new BillForm());
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {
            this.FillComboBoxServices();
            this.FillComboBoxBills();
            this.FillDataGridViewBillDetail();
            
        }

        private void CBBillId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var BillId = (string)CBBillId.GetItemText(CBBillId.SelectedItem);
            string error = "";
            var reservations = rec.GetAllReservations(ref error);
            foreach (var re in reservations)
            {
                if (re.Id == BillId)
                {
                    TBCustomerId.Text = re.CustomerId;
                    TBCustomerName.Text = re.Customer.Name;
                    this.FillDataGridViewBillDetail();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string BillId = Common.GetValueComboBox(CBBillId);
                string ServiceId= Common.GetValueComboBox(CBServiceId);
                

                string error = "";
                bool isCreated = bdc.InsertBillDetail
                    (
                        ref error,
                        BillId,
                        ServiceId
                    );
                if (isCreated)
                {
                    this.FillDataGridViewBillDetail();
                    //this.ClearAllTextBox();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Fill Data BillDetail
        private void FillDataGridViewBillDetail()
        {
            string error = "";
            var BillId = (string)CBBillId.GetItemText(CBBillId.SelectedItem);
            var billdetail = bdc.GetBillDetailById(ref error, BillId);
            if (billdetail != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Mã Hóa Đơn",
                    "Tên DV",
                    "Tiền"
                    );

                foreach (var bi in billdetail)
                {
                    var Service = bi.Service.Name;
                    var price = bi.Service.Price;
                    dt.Rows.Add
                    (
                        bi.BillId,
                        Service,
                        price
                    );
                }
                GridViewBillDetail.DataSource = dt;
                this.GridViewBillDetail.Columns[0].Width = 150;
                this.GridViewBillDetail.Columns[1].Width = 150;
                this.GridViewBillDetail.Columns[2].Width = 150;

                float tong = bdc.TotalBillDetailsById(ref error, BillId);
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.GridViewBillDetail);

                // Get Values
                string BillId = Common.
                    GetValueOfCellGridView(this.GridViewBillDetail, rowIndex, 0);
                string ServiceId = Common.GetValueComboBox(CBServiceId);
                string error = "";
                bool isUpdated = bdc.UpdateBillDetail
                    (
                        ref error,
                        BillId,
                        ServiceId

                     );
                if (isUpdated)
                {
                    this.FillDataGridViewBillDetail();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridViewBillDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.GridViewBillDetail);
                // Get Id
                string Id = Common.
                    GetValueOfCellGridView(this.GridViewBillDetail, rowIndex, 0);

                // remove
                string error = "";
                bool isDeleted = bdc.RemoveBillDetatil(ref error, Id);
                if (isDeleted)
                {
                    this.FillDataGridViewBillDetail();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
