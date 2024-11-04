using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace thuc_hanh_4__11
{
    public partial class AddCustomerForm : Form
    {
        private List<Customer> customers;
        public AddCustomerForm(List<Customer> customers)
        {
            InitializeComponent();
            this.customers = customers; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng Customer mới từ các TextBox
            var newCustomer = new Customer
            {
                Name = txtName.Text,       // Lấy giá trị từ TextBox "Tên"
                Phone = txtPhone.Text,     // Lấy giá trị từ TextBox "SDT"
                Address = txtAddress.Text  // Lấy giá trị từ TextBox "Địa chỉ"
            };

            // Thêm khách hàng mới vào danh sách khách hàng
            customers.Add(newCustomer);

            // Đóng form với kết quả OK để thông báo đã thêm thành công
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
