using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElaboratoBDD.Utils;

namespace ElaboratoBDD
{
    public partial class Orders : Form
    {
        ModelAgencyDataContext ctx = new ModelAgencyDataContext();
        SuccessRateCalculator src;

        public Orders()
        {
            InitializeComponent();
            this.src = new SuccessRateCalculator(ctx);
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            this.refresh_data_sources();
        }

        private void refresh_data_sources()
        {

            cmbProposedModels.DataSource = from m in ctx.Model
                                           select m;

            cmbProposedModels.DisplayMember = "Row";
            cmbProposedModels.ValueMember = "iden_card_numb";


            dataGridView1.DataSource = from o in ctx.Offer
                                       join c in ctx.Customer on o.Customer.iden_card_numb equals c.iden_card_numb
                                       join l in ctx.Location on o.Location.ID equals l.ID
                                       join ot in ctx.OfferType on o.OfferType.name equals ot.name
                                       select new
                                       {
                                           approval_date = o.approval_date,
                                           CodOffer = o.codOffer,
                                           date = o.date_,
                                           status = o.status,
                                           requested_models = o.requested_models,
                                           short_desc = o.short_description,
                                           long_desc = o.long_description,
                                           budget = o.budget,
                                           customer_id = c.iden_card_numb,
                                           customer_name = c.name,
                                           locationID = l.ID,
                                           address = l.Row,
                                           offer_type = ot.name
                                       };

            cmbCustomers.DataSource = from c in ctx.Customer
                                      select c;
            cmbCustomers.DisplayMember = "name";
            cmbCustomers.ValueMember = "iden_card_numb";

            cmbOfferType.DataSource = from ot in ctx.OfferType
                                      select ot;
            cmbOfferType.DisplayMember = "name";
            cmbOfferType.ValueMember = "name";

            cmbLocation.DataSource = from l in ctx.Location
                                     select l;

            cmbLocation.DisplayMember = "Row";
            cmbLocation.ValueMember = "ID";
        }




   

        private void btnAddOffer_Click_1(object sender, EventArgs e)
        {
            var ctx = new ModelAgencyDataContext();
            var offer = new Offer();

            offer.budget = Convert.ToInt32(txtOfferBudget.Text);
            if(dtpOfferApprovalDate.Value.Date != DateTime.Today.Date)
                offer.approval_date = dtpOfferApprovalDate.Value;
            offer.date_ = dtpOfferDate.Value;
            offer.status = txtOfferStatus.Text;
            offer.requested_models = Convert.ToInt32(txtRequestedModels.Text);
            offer.short_description = txtOfferShortDesc.Text;
            offer.long_description = txtOfferLongDesc.Text;
            offer.customer_iden_card_numb = cmbCustomers.SelectedValue.ToString();
            offer.location_ID = Convert.ToInt32(cmbLocation.SelectedValue);
            offer.offer_type_name = cmbOfferType.SelectedValue.ToString();

            ctx.Offer.InsertOnSubmit(offer);
            ctx.SubmitChanges();

            this.refresh_data_sources();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.refresh_listbox_items();
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            if(row.Cells[0].Value!=null)
                dtpOfferApprovalDate.Value = Convert.ToDateTime(row.Cells[0].Value.ToString());
            dtpOfferDate.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());

            txtOfferStatus.Text = row.Cells[3].Value.ToString();
            txtRequestedModels.Text = row.Cells[4].Value.ToString();
            txtOfferShortDesc.Text = row.Cells[5].Value.ToString();
            txtOfferLongDesc.Text = row.Cells[6].Value.ToString();
            txtOfferBudget.Text = row.Cells[7].Value.ToString();

            cmbCustomers.SelectedValue = row.Cells[8].Value.ToString();
            cmbOfferType.SelectedValue = row.Cells[12].Value.ToString();
            cmbLocation.SelectedText = row.Cells[11].Value.ToString();


            
        }

        private void refresh_listbox_items()
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            lbProposedModels.Items.Clear();
            var proposed_models = from p in ctx.proposal
                                  join o in ctx.Offer on p.codOffer equals o.codOffer
                                  join m in ctx.Model on p.model_iden_card_numb equals m.iden_card_numb
                                  where o.codOffer == Convert.ToInt32(row.Cells[1].Value)
                                  select m;

            foreach (var m in proposed_models)
            {
                lbProposedModels.Items.Add(m.Row);
            }
        }

        private void lbProposedModels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            var proposal = new proposal();
            proposal.status = 'p';
            proposal.model_iden_card_numb = cmbProposedModels.SelectedValue.ToString(); 
            var offer = (from o in ctx.Offer
                        where o.codOffer == Convert.ToInt32(row.Cells[1].Value)
                        select o).FirstOrDefault();

            proposal.Offer = offer;
            ctx.proposal.InsertOnSubmit(proposal);
            ctx.SubmitChanges();

            this.refresh_listbox_items();
            src.UpdateSuccessRateFromProposal(proposal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

            ctx.ExecuteCommand(@"UPDATE dbo.proposal SET status='a' WHERE dbo.proposal.codOffer={0}", Convert.ToInt32(row.Cells[1].Value));

            ctx.SubmitChanges();

            var offer = (from o in ctx.Offer where o.codOffer == Convert.ToInt32(row.Cells[1].Value) select o).FirstOrDefault();
            src.UpdateSuccessRateFromOffer(offer);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

            var offer = (from o in ctx.Offer
                         where o.codOffer == Convert.ToInt32(row.Cells[1].Value)
                         select o).FirstOrDefault();


            if (dtpOfferApprovalDate.Value.Date != DateTime.Today.Date)
                offer.approval_date = dtpOfferApprovalDate.Value;
            offer.status = txtOfferStatus.Text;
            offer.requested_models = Convert.ToInt32(txtRequestedModels.Text);
            offer.short_description = txtOfferShortDesc.Text;
            offer.long_description = txtOfferLongDesc.Text;

            ctx.SubmitChanges();

            this.refresh_data_sources();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

            ctx.ExecuteCommand(@"UPDATE dbo.Offer SET status='closed' WHERE dbo.Offer.codOffer={0}", Convert.ToInt32(row.Cells[1].Value));

            ctx.SubmitChanges();

            this.refresh_data_sources();
        }
    }
}
