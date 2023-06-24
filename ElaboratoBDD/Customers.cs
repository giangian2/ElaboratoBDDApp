using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElaboratoBDD
{
    public partial class Customers : Form
    {
        ModelAgencyDataContext ctx = new ModelAgencyDataContext();

        public Customers()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var customer = new Customer();

            customer.iden_card_numb= txtIdenCardNumb.Text;
            customer.name = txtname.Text;
            customer.surname= txtSurname.Text;
            customer.birth_date= dateTimePicker1.Value;
            customer.address= txtAddress.Text;
            customer.P_IVA= txtPIVA.Text;
            customer.final_client = txtFinalCLient.Text;

            ctx.Customer.InsertOnSubmit(customer);
            ctx.SubmitChanges();
            this.refresh_customers_table();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

            var customer = (from c in ctx.Customer
                            where c.iden_card_numb == row.Cells[0].Value.ToString()
                            select c).FirstOrDefault();

            customer.iden_card_numb = txtIdenCardNumb.Text;
            customer.name = txtname.Text;
            customer.surname = txtSurname.Text;
            customer.birth_date = dateTimePicker1.Value;
            customer.address = txtAddress.Text;
            customer.P_IVA = txtPIVA.Text;
            customer.final_client = txtFinalCLient.Text;

            ctx.SubmitChanges();
            this.refresh_customers_table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            txtIdenCardNumb.Text= row.Cells[0].Value.ToString();
            txtname.Text= row.Cells[1].Value.ToString();
            txtSurname.Text= row.Cells[2].Value.ToString();
            if(row.Cells[3].Value!=null)
                dateTimePicker1.Value= Convert.ToDateTime(row.Cells[3].Value.ToString());
            if(row.Cells[4].Value!=null)
                txtAddress.Text= row.Cells[4].Value.ToString();
            if (row.Cells[5].Value != null)
                txtPIVA.Text= row.Cells[5].Value.ToString();
            if (row.Cells[6].Value != null)
                txtFinalCLient.Text= row.Cells[6].Value.ToString();
        }

        private void refresh_customers_table()
        {
            var customers = (from c in ctx.Customer
                             select c).ToList();

            dataGridView1.DataSource = customers;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            this.refresh_customers_table();
        }
    }
}
