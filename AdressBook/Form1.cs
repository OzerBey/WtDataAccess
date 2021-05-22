using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBook
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=AddressBookDb; Trusted_Connection=True;");

        //first running method of application
        public Form1()
        {
            con.Open();
            InitializeComponent();
            ShowDatas();
        }

        private void ShowDatas()
        {
            SqlCommand cmd = new SqlCommand("SELECT id, FirstName,LastName,PhoneNumber,Address FROM Addresses", con);

            SqlDataReader dr = cmd.ExecuteReader();

            dgvAddresses.Rows.Clear(); // firstly deleting all of rows

            while (dr.Read())
            {
                dgvAddresses.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            dr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            SqlCommand cmd =
                new SqlCommand(
                    "INSERT INTO Addresses (FirstName,LastName,PhoneNumber,Address) VALUES (@p1,@p2,@p3,@p4) ", con);
            cmd.Parameters.AddWithValue("@p1", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@p2", txtLastName.Text);
            cmd.Parameters.AddWithValue("@p3", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@p4", txtAddress.Text);
            int effectedRowsNumber = cmd.ExecuteNonQuery();

            FormattedCommand();
            ShowDatas();
            //MessageBox.Show("Person added ☑");
            showAlertMessage("add");
        }

        private void showAlertMessage(string str)
        {
            if (str.Equals("delete"))
            {
                string message = "Person deleted ☑";
                string title = "⚜ info";
                MessageBox.Show(message, title);
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
        }

        private void FormattedCommand()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvAddresses.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvAddresses.SelectedRows)
                {
                    var cmd = new SqlCommand("DELETE FROM Addresses WHERE id = @p1", con);
                    cmd.Parameters.AddWithValue("@p1", (int)row.Cells[0].Value);
                    int result = cmd.ExecuteNonQuery();
                }
                ShowDatas();

            }
        }
    }
}
