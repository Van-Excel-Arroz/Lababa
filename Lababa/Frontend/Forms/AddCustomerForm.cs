using Lababa.Backend.Models;
using Lababa.Backend.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lababa.Frontend.Forms
{
    public partial class AddCustomerForm : Form
    {
        private readonly CustomerService _customerService;

        public AddCustomerForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            SetupDataGridView();
            LoadCustomers();
            txtSearchCustomers.TextChanged += TxtSearchCustomers_TextChanged;
        }


        private void SetupDataGridView()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.Columns[3].DefaultCellStyle.Format = "MMM dd, yyyy";
        }


        private void TxtSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCustomers.Text.ToLower();

            var allCustomers = _customerService.GetAllCustomers();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvCustomers.DataSource = allCustomers;
            }
            else
            {
                var filtered = allCustomers.Where(c =>
                    c.FullName.ToLower().Contains(searchText) ||
                    c.PhoneNumber.Contains(searchText) ||
                    c.Address.ToLower().Contains(searchText)
                ).ToList();

                dgvCustomers.DataSource = filtered;
            }
        }

        private void LoadCustomers()
        {
            try
            {
                var customers = _customerService.GetAllCustomers();
                dgvCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer
                {
                    FullName = txtCustomerName.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                _customerService.AddCustomer(customer);

                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCustomerName.ResetText();
                txtPhoneNumber.ResetText();
                txtAddress.ResetText();

                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var customer = (Customer)dgvCustomers.Rows[e.RowIndex].DataBoundItem;
                _customerService.UpdateCustomer(customer);

                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadCustomers();
            }
        }
    }
}