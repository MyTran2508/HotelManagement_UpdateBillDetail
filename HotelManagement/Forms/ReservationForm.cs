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
using HotelManagement.Resources.Utils;

namespace HotelManagement.Forms
{
    public partial class ReservationForm : Form
    {

        RoomController rc = null;
        CustomerController cc = null;
        EmployeeController ec = null;
        ReservationController rec = null;
       
        public ReservationForm()
        {
            InitializeComponent();
            this.rc = new RoomController();
            this.cc = new CustomerController();
            this.ec = new EmployeeController();
            this.rec = new ReservationController();
        }

        // Fill Data Grid View
        private void FillDataGridViewReservations()
        {
            string error = "";
            var reservations = rec.GetAllReservations(ref error);
            if (reservations != null)
            {
                DataTable dt = Common.GetDataTable(
                    "Mã DK",
                    "Tên NV",
                    "Số Phòng",
                    "Khách Hàng",
                    "Ngày Thuê",
                    "Ngày Trả",
                    "Trạng Thái"
                    );

                foreach (var re in reservations)
                {
                    var EmployeeName = re.Employee.Name;
                    var CustomerName = re.Customer.Name;
                    var RoomName = re.Room.Name;
                    var DateIn = re.DateIn.ToShortDateString();
                    var DateOut = re.DateOut.ToShortDateString();
                    string Status;
                    if (re.Status)
                        Status = "Đã Thanh Toán";
                    else
                        Status = "Chưa Thanh Toán";
                    dt.Rows.Add
                    (

                        re.Id,
                        EmployeeName,
                        RoomName,
                        CustomerName, 
                        DateIn, 
                        DateOut, 
                        Status
                    );
                }
                GridViewReservation.DataSource = dt;
                //int[] widths = { 170, 170, 180 };
                this.GridViewReservation.Columns[2].Width = 150;
                this.GridViewReservation.Columns[3].Width = 150;
                this.GridViewReservation.Columns[4].Width = 190;
                this.GridViewReservation.Columns[5].Width = 190;
                this.GridViewReservation.Columns[6].Width = 150;

            }
        }

        // Fill ComboBox Rooms
        private void FillComboBoxRooms()
        {
            string error = "";
            var rooms = rc.GetAllRooms(ref error);
            DataTable dt = Common.FillDataTable(rooms);
            if (dt != null)
            {
                CBRoomId.DataSource = dt;
                CBRoomId.DisplayMember = "Name";
                CBRoomId.ValueMember = "Id";
            }
        }

        // Fill ComboBox Customers
        private void FillComboBoxCustomers()
        {
            string error = "";
            var customers = cc.GetAllCustomer(ref error);
            DataTable dt = Common.FillDataTable(customers);
            if (dt != null)
            {
                CBCustomerId.DataSource = dt;
                CBCustomerId.DisplayMember = "Name";
                CBCustomerId.ValueMember = "Id";
            }
        }

        // Fill ComboBox Employees
        private void FillComboBoxEmployees()
        {
            string error = "";
            var employees = ec.GetAllEmployees(ref error);
            DataTable dt = Common.FillDataTable(employees);
            if (dt != null)
            {
                CBEmployeeId.DataSource = dt;
                CBEmployeeId.DisplayMember = "Name";
                CBEmployeeId.ValueMember = "Id";
            }
        }

        private void ClearAllTextBox()
        {
            TBId.ResetText();
            CBCustomerId.ResetText();
            CBEmployeeId.ResetText();
            CBRoomId.ResetText();
        }

        // Event handler
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            this.ClearAllTextBox();
            this.FillComboBoxRooms();
            this.FillComboBoxCustomers();
            this.FillComboBoxEmployees();
            this.FillDataGridViewReservations();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new HomeForm());  
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            Common.ShowForm(this, new BillForm());  
        }

        private void GridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                // Get Value of current row
                int rowIndex = Common.GetCurrentRowSelected(this.GridViewReservation);
                if (rowIndex != -1)
                {
                    string Id = Common.
                        GetValueOfCellGridView(GridViewReservation, rowIndex, 0);
                    string EmployeeId = Common.GetValueOfCellGridView(GridViewReservation, rowIndex, 1);
                    string RoomId = Common.GetValueOfCellGridView(GridViewReservation, rowIndex, 2);
                    string CustomerId = Common.GetValueOfCellGridView(GridViewReservation, rowIndex, 3);
                    string DateIn = Common.GetValueOfCellGridView(GridViewReservation, rowIndex, 4);
                    string DateOut = Common.GetValueOfCellGridView(GridViewReservation, rowIndex, 5);


                    this.TBId.Text = Id;
                    this.CBEmployeeId.Text = EmployeeId;
                    this.CBRoomId.Text = RoomId;
                    this.CBCustomerId.Text = CustomerId;
                    this.DTIn.Value = DateTime.Parse(DateIn);
                    this.DTOut.Value = DateTime.Parse(DateOut);
                }
            }
            catch
            {
                return;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = Common.GetValueTextBox(TBId);
                string EmployeeId = Common.GetValueComboBox(this.CBEmployeeId);
                string CustomerId = Common.GetValueComboBox(this.CBCustomerId);
                string RoomId = Common.GetValueComboBox(this.CBRoomId);
                DateTime DateIn = Common.GetValueDateTimePicker(DTIn);
                DateTime DateOut = Common.GetValueDateTimePicker(DTOut);

                string error = "";
                bool isCreated = rec.InsertReservation
                    (
                        ref error,
                        Id,
                        EmployeeId, 
                        RoomId, 
                        CustomerId, 
                        DateIn, 
                        DateOut
                    );
                if (isCreated)
                {
                    this.FillDataGridViewReservations();
                    this.ClearAllTextBox();
                }
                MessageBox.Show(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get current Index
                int rowIndex = Common.
                    GetCurrentRowSelected(this.GridViewReservation);

                // Get Values
                string id = Common.
                    GetValueOfCellGridView(this.GridViewReservation, rowIndex, 0);
                string EmployeeId = Common.
                    GetValueComboBox(this.CBEmployeeId);
                string CustomerId = Common.
                    GetValueComboBox(this.CBCustomerId);
                string RoomId = Common.
                    GetValueComboBox(this.CBRoomId);
                DateTime DateIn = Common.
                    GetValueDateTimePicker(DTIn);
                DateTime DateOut = Common.
                    GetValueDateTimePicker(DTOut);

                string error = "";
                bool isUpdated = rec.UpdateReservation
                    (
                        ref error,
                        id,
                        EmployeeId, 
                        RoomId, 
                        CustomerId, 
                        DateIn, 
                        DateOut
                    );
                if (isUpdated)
                {
                    this.FillComboBoxRooms();
                    this.FillComboBoxCustomers();
                    this.FillComboBoxEmployees();
                    this.FillDataGridViewReservations();
                    //this.FillTextBox();
                    this.ClearAllTextBox();
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
