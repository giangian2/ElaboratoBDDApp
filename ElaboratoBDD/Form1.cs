namespace ElaboratoBDD
{
    using DevExpress.XtraEditors.Controls;
    using ElaboratoBDD.Properties;

    public partial class Form1 : Form
    {

        ModelAgencyDataContext ctx = new ModelAgencyDataContext();
        List<string> _surrentModelPhotosPath = new List<string>();
        int current = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.updateStats();

            pictureBox1.SizeMode= PictureBoxSizeMode.StretchImage;

            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

            cmbRelatedOffer.DataSource = ctx.ExecuteQuery<Offer>(@"SELECT Offer.* FROM Offer JOIn proposal ON dbo.Offer.codOffer=dbo.proposal.codOffer WHERE proposal.status = 'a' AND Offer.status = 'closed' AND proposal.model_iden_card_numb='{0}';", row.Cells[0].Value.ToString()).ToList();
        }

        private void updateStats()
        {
            

            

            dataGridView1.DataSource = from m in ctx.Model
                                       join c in ctx.Manager on m.manager_iden_card_numb equals c.iden_card_numb
                                       select new
                                       {
                                           iden_card_numb = m.iden_card_numb,
                                           name = m.name,
                                           surname = m.surname,
                                           birth_date = m.birth_date,
                                           address = m.address,
                                           eyes_color = m.eyes_color,
                                           age = m.age,
                                           email = m.email,
                                           hair_color = m.hair_color,
                                           shoes_number = m.shoes_number,
                                           height = m.height,
                                           waist = m.waist,
                                           manager_iden_card_numb = m.manager_iden_card_numb,
                                           manager_name = c.name
                                       };

            var topModel = (from m in ctx.Model
                            let maxSr = ctx.Model.Max(m => m.success_rate)
                            where m.success_rate == maxSr
                            select m).FirstOrDefault();


            var topCustomer = (from c in ctx.Customer
                               join o in ctx.Offer on c.iden_card_numb equals o.Customer.iden_card_numb
                               let maxBudget = ctx.Offer.Max(o => o.budget)
                               where o.budget == maxBudget
                               select c).FirstOrDefault();

            var customerWithMoreOffers = (from c in ctx.Customer
                                          join o in ctx.Offer on c.iden_card_numb equals o.Customer.iden_card_numb
                                          group o by c.iden_card_numb into oc
                                          select new
                                          {
                                              customer_iden_card_numb = oc.Key,
                                              Count = oc.Count(),
                                          }).OrderByDescending(x => x.Count).FirstOrDefault();



            int totClosedOffers = (from o in ctx.Offer
                                   where o.status == "closed"
                                   select o).Count();

            int? earning = (from o in ctx.Offer
                            where o.budget.HasValue
                            select o).Sum(o => o.budget);


            if (customerWithMoreOffers != null)
            {
                var final = (from c in ctx.Customer
                             where c.iden_card_numb == customerWithMoreOffers.customer_iden_card_numb
                             select c).FirstOrDefault();
                textCustomerWithMostCLosedOffers.Text = final != null ? final.name + " " + final.surname : "none";
            }

            txtTopModel.Text = topModel != null ? topModel.name + " " + topModel.surname : "none";
            txtCustomerWithHighestBudget.Text = topCustomer != null ? topCustomer.name + " " + topCustomer.surname : "none";
            txtClosedOffers.Text = totClosedOffers.ToString();
            txtEarning.Text = earning.HasValue ? earning.Value.ToString() : "none";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOffer_Click(object sender, EventArgs e)
        {
       
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderForm = new Orders();
            orderForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = null;
            this._surrentModelPhotosPath.Clear();
            this.current = 0;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


            var images = from m in ctx.Model
                         where m.iden_card_numb == row.Cells[0].Value.ToString()
                         select m.Photo;

            foreach (var image in images)
            {
                foreach (var i in image)
                {
                    this._surrentModelPhotosPath.Add(i.path);
                }
            }

            if(this._surrentModelPhotosPath.Count > 0)  
                pictureBox1.ImageLocation = String.Format(@".\..\Images\{0}", this._surrentModelPhotosPath[this.current]);

            var res = (from o in ctx.Offer
                       join p in ctx.proposal on o.codOffer equals p.codOffer
                       where p.status == 'a'
                       where o.status == "closed"
                       where p.model_iden_card_numb == row.Cells[0].Value.ToString()
                       select o);

            cmbRelatedOffer.DataSource = res;
            cmbRelatedOffer.DisplayMember = "codOffer";
            cmbRelatedOffer.ValueMember = "codOffer";
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            if (this._surrentModelPhotosPath.Count-1 == (this.current )) this.current = 0;
            else this.current++;

            if (this._surrentModelPhotosPath.Count > 0)
                pictureBox1.ImageLocation = String.Format(@".\..\Images\{0}", this._surrentModelPhotosPath[this.current]);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var date = Convert.ToDateTime(monthCalendar1.SelectionRange.End.ToString());

            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

            var events = from ev in ctx.Event
                         join t in ctx.Transport on ev.Transport.ID equals t.ID
                         where ev.model_iden_card_numb == row.Cells[0].Value.ToString()
                         where ev.offer_date.Date == date.Date
                         select new
                         {
                             codEvent = ev.codEvent,
                             codOffer = ev.codOffer,
                             offer_date = ev.offer_date,
                             start_time = ev.start_time,
                             end_time = ev.end_time,
                             transport_ID = ev.transport_ID,
                             transport_type = t.type,
                             transport_description = t.description,
                             transport_start_datetime = t.start_datetime,
                             transport_arrival_datetime = t.arrival_datetime,
                             transport_departure_place = t.departure_place,
                             transport_destination_place = t.destination_place
                         };

            foreach(var ev in events)
            {
                txtTransportDesc.Text = ev.transport_description;
                txtTransportDepPlace.Text = ev.transport_departure_place;
                txtTransportDestPlace.Text = ev.transport_destination_place;
                txtTransportType.Text = ev.transport_type;
                dtpEndDate.Value = ev.end_time;
                dtpStartDate.Value = ev.start_time;
                if(ev.transport_arrival_datetime.HasValue)
                    dtpTransportArrivalDT.Value = ev.transport_arrival_datetime.Value;
                dtpTransportStartDT.Value = ev.transport_start_datetime;
            }
            
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            var _event = new Event();

            _event.model_iden_card_numb = row.Cells[0].Value.ToString();
            _event.codOffer = Convert.ToInt32(cmbRelatedOffer.SelectedValue);
            _event.start_time = dtpStartDate.Value;
            _event.end_time = dtpEndDate.Value;
            _event.offer_date = (from o in ctx.Offer
                                where o.codOffer == Convert.ToInt32(cmbRelatedOffer.SelectedValue)
                                select o.date_).FirstOrDefault();

            var transport = new Transport();
            transport.start_datetime = dtpTransportStartDT.Value;
            transport.arrival_datetime = dtpTransportArrivalDT.Value;
            transport.description = txtTransportDesc.Text;
            transport.departure_place = txtTransportDepPlace.Text;
            transport.destination_place = txtTransportDestPlace.Text;

            ctx.Transport.InsertOnSubmit(transport);
            ctx.SubmitChanges();

            _event.Transport = transport;

            ctx.Event.InsertOnSubmit(_event);
            ctx.SubmitChanges();
        }
    }
}