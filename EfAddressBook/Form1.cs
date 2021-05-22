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
        private AddressBookContext _db = new AddressBookContext();
        public Form1()
        {
            InitializeComponent();
            showDatas();
        }

        private void showDatas()
        {
            dataGridView12.DataSource = _db.Persons.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Address = txtAddress.Text
            };
            _db.Persons.Add(person);
            _db.SaveChanges();
            showDatas();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvAddresses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
