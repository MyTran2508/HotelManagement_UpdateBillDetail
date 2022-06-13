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
    public partial class AccountForm : Form
    {
        AccountController ac = null;
        EmployeeController emc = null;

        List<Employee> emps = null;

        

        public AccountForm()
        {
            InitializeComponent();
            ac = new AccountController();
            emc = new EmployeeController();
        }

        public void GetEmployees()
        {
            string error = "";
            this.emps = emc.GetAllEmployees(ref error);
        }
        private void ClearAllTextBox()
        {
            TBUsername.ResetText();
            TBPassword.ResetText();
            TBUsername.Focus();
        }

        // Get datatable fill in DataGrid
        private void FillDataGrid()
        {
            string error = "";
            var acs = ac.GetAllAccounts(ref error);

            if (acs != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Tên NV",
                    "Tên Đăng Nhập",
                    "Mật Khẩu"
                    );

                foreach (var a in acs)
                {

                    dt.Rows.Add(a.EmployeeId, a.Username, a.Password);

                }
                // Return databale 
                this.GridViewAccounts.DataSource = dt;

                // Set Width Column
                this.GridViewAccounts.Columns[0].Width = 100;
                this.GridViewAccounts.Columns[1].Width = 200;
                this.GridViewAccounts.Columns[2].Width = 200;
            }
        }

        // Fill ComboBox Employees
        private void FillComboBoxEmployees()
        {
            /*string error = "";
            var emps = emc.GetAllEmployees(ref error);*/

            // Refesh data 
            this.GetEmployees();

            DataTable dt = Common.FillDataTable(emps);
            if (dt != null)
            {
                CBEmployees.DataSource = dt;
                CBEmployees.DisplayMember = "Name";
                CBEmployees.ValueMember = "Id";
            }
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new HomeForm()); 
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            ClearAllTextBox();
            FillDataGrid();
            FillComboBoxEmployees();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string Username = Common.
                    GetValueTextBox(TBUsername);
                string Password = Common.
                    GetValueTextBox(TBPassword);
                string EmployeeId = Common.
                    GetValueComboBox(this.CBEmployees);
               
                string error = "";
                bool isCreated = ac.
                    InsertAccount(EmployeeId, Username, Password, ref error);
                if (isCreated)
                {
                    this.FillComboBoxEmployees();
                    this.ClearAllTextBox();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridViewAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get Value of current row
            int rowIndex = Common.GetCurrentRowSelected(this.GridViewAccounts);
            if (rowIndex != -1)
            {
                string EmployeeId = Common.
                    GetValueOfCellGridView(GridViewAccounts, rowIndex, 0);
                string UserName = Common.
                    GetValueOfCellGridView(GridViewAccounts, rowIndex, 1);
                string Password = Common.
                    GetValueOfCellGridView(GridViewAccounts, rowIndex, 2);

                this.TBUsername.Text = UserName;
                this.TBPassword.Text = Password;
                //this.CBEmployees.SelectedIndex = 1;
               /* foreach(var em in this.emps)
                {
                    if(em.Id == EmployeeId)
                    {
                        this.CBEmployees.SelectedItem = new { Id = EmployeeId, Name = em.Name };
                        break;
                    }
                }*/
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.GetCurrentRowSelected(this.GridViewAccounts);

                // Get Values
                string EmployeeId = Common.
                    GetValueOfCellGridView(this.GridViewAccounts, rowIndex, 0);
                string password = Common.GetValueTextBox(TBPassword);

                string error = "";
                bool isUpdated = ac.
                    UpdateAccountByEmployeeId(EmployeeId, password, ref error);
                if (isUpdated)
                {
                    this.FillDataGrid();
                    this.FillComboBoxEmployees();
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
