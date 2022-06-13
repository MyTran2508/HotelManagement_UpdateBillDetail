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
using HotelManagement.Resources.Utils;

namespace HotelManagement.Forms
{
    public partial class EmployeeForm : Form
    {
        EmployeeController emp = null;

        public EmployeeForm()
        {
            InitializeComponent();
            this.emp = new EmployeeController();
        }

        // Clear Data textbox
        private void ClearAllTextBox()
        {
            TBId.ResetText();
            TBName.ResetText();
            TBAddress.ResetText();
            TBPhonenumber.ResetText();
            TBId.Focus();
        }

        private void FillDataGrid()
        {
            string error = "";
            var employees = emp.GetAllEmployees(ref error);

            if (employees != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Mã NV",
                    "Họ Tên",
                    "Địa Chỉ",
                    "Số Điện Thoại"
                    );

                foreach (var ee in employees)
                {

                    dt.Rows.Add(ee.Id, ee.Name, ee.Address, ee.Phonenumber);

                }
                // Return databale 
                this.GridViewEmployees.DataSource = dt;

                // Set Width Column
                this.GridViewEmployees.Columns[0].Width = 120;
                this.GridViewEmployees.Columns[1].Width = 200;
                this.GridViewEmployees.Columns[2].Width = 200;
                this.GridViewEmployees.Columns[3].Width = 180;

            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ClearAllTextBox();
            FillDataGrid();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = TBId.Text;
                string EmployeeName = TBName.Text;
                string Address = TBAddress.Text;
                string PhoneNumber = TBPhonenumber.Text;

                string error = "";
                bool isCreated = emp.
                    InsertEmployee(Id, EmployeeName, PhoneNumber, Address, ref error);
                if (isCreated)
                {
                    // Refresh Data
                    this.FillDataGrid();

                    // Clear Text Box If Insert success
                    this.ClearAllTextBox();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Đã Xảy Ra Lỗi, Vui Lòng Thử Lại");
            }
        }

        private void GridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get Current Row Selected
            int rowIndex = this.GridViewEmployees.CurrentCell.RowIndex;

            // Get Value of current row
            string Id = Common
                .GetValueOfCellGridView(GridViewEmployees, rowIndex, 0);
            string EmployeeName = Common
                .GetValueOfCellGridView(GridViewEmployees, rowIndex, 1);
            string Address = Common
                .GetValueOfCellGridView(GridViewEmployees, rowIndex, 2);
            string PhoneNumber = Common
                .GetValueOfCellGridView(GridViewEmployees, rowIndex, 3);

            // Assign Value
            this.TBId.Text = Id;
            this.TBName.Text = EmployeeName;
            this.TBAddress.Text = Address;
            this.TBPhonenumber.Text = PhoneNumber;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = TBId.Text;
                string EmployeeName = TBName.Text;
                string Address = TBAddress.Text;
                string PhoneNumber = TBPhonenumber.Text;

                string error = "";
                bool isUpdated = emp.
                    UpdateEmployeeById(Id, EmployeeName, PhoneNumber, Address, ref error);
                
                if (isUpdated)
                {
                    this.ClearAllTextBox();
                    this.FillDataGrid();
                }
                MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show("Update Employee failure!!!");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new HomeForm());
        }
    }
}
