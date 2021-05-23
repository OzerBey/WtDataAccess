using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfAddressBook.Models;

namespace EfAddressBook
{
    public partial class Form1 : Form
    {
        private Person _person = null;

        private AddressBookContext _db = new AddressBookContext();
        public Form1()
        {
            InitializeComponent();
            showDatas();
        }

        private void showDatas()
        {
            string search = txtSearch.Text;
            if (txtSearch != null)
            {
                dataGridView12.DataSource = _db.Persons.Where(p => p.FirstName.Contains(search) || p.LastName.Contains(search) || p.PhoneNumber.Contains(search) || p.Address.Contains(search)).ToList();
            }
            else
            {
                dataGridView12.DataSource = _db.Persons.ToList();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this._person == null)
            {
                Person _person = new Person()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text

                };
                _db.Persons.Add(_person);
                showAlertMessage("add");
            }
            else
            {
                _person.FirstName = txtFirstName.Text;
                _person.LastName = txtLastName.Text;
                _person.PhoneNumber = txtPhoneNumber.Text;
                _person.Address = txtAddress.Text;
            }

            _db.SaveChanges();
            ResetForm();
            showDatas();
        }

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            btnAdd.Text = "Add";
            btnCancel.Hide();
            _person = null;
        }

        private void dgvAddresses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           string message = "Do you want to delete this record ?";
            string title = "Delete Record";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (dataGridView12.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView12.SelectedRows[0];
                    Person person = (Person)row.DataBoundItem;
                    _db.Persons.Remove(person);
                    _db.SaveChanges();
                    showDatas();
                    showAlertMessage("delete");
                }

            }
            else
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView12.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView12.SelectedRows[0];
                _person = (Person)row.DataBoundItem;
                txtFirstName.Text = _person.FirstName;
                txtLastName.Text = _person.LastName;
                txtPhoneNumber.Text = _person.PhoneNumber;
                txtAddress.Text = _person.Address;
                btnAdd.Text = "Save";
                btnCancel.Show();

            }
        }

        private void showAlertMessage(string str)
        {
            if (str.Equals("delete"))
            {
                string Alertmessage = "Person deleted ☑";
                string title = "⚜ info";
                MessageBox.Show(Alertmessage, title);
            }
            else if (str.Equals("add"))
            {
                string message = "Person added ☑";
                string title = "⚜ info";
                MessageBox.Show(message, title);
            }
            else if (str.Equals("update"))
            {
                string message = "Person updated ☑";
                string title = "⚜ info";
                MessageBox.Show(message, title);
            }
            else if (str.Equals("save"))
            {
                string message = "Person saved to Database ☑";
                string title = "⚜ info";
                MessageBox.Show(message, title);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            showDatas();
        }
    }
}
