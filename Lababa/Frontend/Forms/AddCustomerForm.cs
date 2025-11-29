using Lababa.Backend.Models;
using Lababa.Backend.Services;
using System.Text.RegularExpressions;

namespace Lababa.Frontend.Forms
{
    public partial class AddCustomerForm : Form
    {
        private readonly CustomerService _customerService;
        public event EventHandler CustomerUpdated;

        public AddCustomerForm(CustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
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
                string pattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

                if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    MessageBox.Show("Customer Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Customer Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Focus();
                    return;
                }

                if (txtCustomerName.Text.Length > 50)
                {
                    MessageBox.Show("Customer name must not be greater than 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerName.Focus();
                    return;
                }

                if (!Regex.IsMatch(txtPhoneNumber.Text.Trim(), pattern))
                {
                    MessageBox.Show("Please enter a valid phone number format \n(e.g., 123-456-7890).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Focus();
                    return;
                }

                if (txtAddress.Text.Length > 100)
                {
                    MessageBox.Show("Address must not be greater than 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }

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

                CustomerUpdated?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadCustomers();
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCustomers.Columns["colDelete"].Index)
            {
                var customer = dgvCustomers.Rows[e.RowIndex].DataBoundItem as Customer;

                var result = MessageBox.Show($"Are you sure you want to delete {customer.FullName}", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _customerService.DeleteCustomer(customer.Id);
                    LoadCustomers();
                    CustomerUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}