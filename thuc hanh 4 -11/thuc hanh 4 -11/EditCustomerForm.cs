using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuc_hanh_4__11
{
    public partial class EditCustomerForm : Form
    {
        private Customer customer;
        public EditCustomerForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer; // Gán đối tượng khách hàng

            // Hiển thị thông tin hiện tại của khách hàng trong các TextBox
            txtName.Text = customer.Name;
            txtPhone.Text = customer.Phone;
            txtAddress.Text = customer.Address;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin khách hàng từ các TextBox
            customer.Name = txtName.Text;
            customer.Phone = txtPhone.Text;
            customer.Address = txtAddress.Text;

            // Đóng form và trả về DialogResult là OK để thông báo rằng thông tin đã được lưu
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
