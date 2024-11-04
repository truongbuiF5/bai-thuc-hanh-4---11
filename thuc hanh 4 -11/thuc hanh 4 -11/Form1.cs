using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;


namespace thuc_hanh_4__11
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>(); 
        private List<Service> services = new List<Service>();
        public Form1()
        {
            InitializeComponent();
            LoadServices();       
            LoadCustomers();     
            UpdateCustomerList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var addCustomerForm = new AddCustomerForm(customers))
            {
                if (addCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateCustomerList(); 
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0) 
            {
                var selectedCustomer = (Customer)dgvKhachHang.SelectedRows[0].DataBoundItem;
                using (var editCustomerForm = new EditCustomerForm(selectedCustomer))
                {
                    if (editCustomerForm.ShowDialog() == DialogResult.OK)
                    {
                        UpdateCustomerList(); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để chỉnh sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0) 
            {
                var selectedCustomer = (Customer)dgvKhachHang.SelectedRows[0].DataBoundItem;
                customers.Remove(selectedCustomer);
                UpdateCustomerList();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0 && dgvDichVu.SelectedRows.Count > 0) 
            {
                var selectedCustomer = (Customer)dgvKhachHang.SelectedRows[0].DataBoundItem;
                double totalAmount = 0;

                foreach (DataGridViewRow row in dgvDichVu.SelectedRows)
                {
                    var selectedService = (Service)row.DataBoundItem;
                    totalAmount += selectedService.Price;
                }

                MessageBox.Show($"Hóa đơn cho {selectedCustomer.Name}:\nTổng tiền: {totalAmount} VND");
                txbTongTien.Text = totalAmount.ToString(); 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng và ít nhất một dịch vụ.");
            }
        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedService = (Service)dgvDichVu.Rows[e.RowIndex].DataBoundItem;
                try
                {
                    pictureBoxServiceImage.Image = Image.FromFile(selectedService.ImagePath);
                    pictureBoxServiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                }
            }
        }
        private void UpdateCustomerList()
        {
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = customers; 
        }

        private void LoadServices()
        {
            
            services.Add(new Service { Id = 1, Name = "Dịch vụ Spa", Price = 100000 });
            services.Add(new Service { Id = 2, Name = "Dịch vụ Massage", Price = 150000 });
            services.Add(new Service { Id = 3, Name = "Dịch vụ Cắt tóc", Price = 50000 });
            services.Add(new Service { Id = 4, Name = "Dịch vụ Làm móng", Price = 80000 });
            services.Add(new Service { Id = 5, Name = "Dịch vụ Gội đầu", Price = 30000 });
            

            
            dgvDichVu.DataSource = null;
            dgvDichVu.DataSource = services;

           
            dgvDichVu.Columns["Id"].HeaderText = "Mã DV";        
            dgvDichVu.Columns["Name"].HeaderText = "Tên dịch vụ";
            dgvDichVu.Columns["Price"].HeaderText = "Giá tiền";   

            
            if (dgvDichVu.Columns["ImagePath"] != null)
            {
                dgvDichVu.Columns["ImagePath"].Visible = false;
            }
        }
        private void LoadCustomers()
        {
            
            customers.Add(new Customer { Name = "Nguyễn Văn A", Phone = "0123456789", Address = "Hà Nội" });
            customers.Add(new Customer { Name = "Trần Thị B", Phone = "0987654321", Address = "TP Hồ Chí Minh" });
            customers.Add(new Customer { Name = "Lê Văn C", Phone = "0912345678", Address = "Đà Nẵng" });


            dgvKhachHang.DataSource = customers; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
