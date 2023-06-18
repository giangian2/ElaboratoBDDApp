namespace ElaboratoBDD
{

    using ElaboratoBDD.Properties;

    public partial class Form1 : Form
    {

        ModelAgencyDataContext ctx = new ModelAgencyDataContext();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from m in ctx.Model
                                       join c in ctx.Manager on m.manager_iden_card_numb equals c.iden_card_numb
                                       select new
                                       {
                                           iden_card_numb=m.iden_card_numb,
                                           name=m.name,
                                           surname=m.surname,
                                           birth_date=m.birth_date,
                                           address= m.address,
                                           eyes_color=m.eyes_color,
                                           age=m.age,
                                           email=m.email,
                                           hair_color=m.hair_color,
                                           shoes_number=m.shoes_number,
                                           height=m.height,
                                           waist=m.waist,
                                           manager_iden_card_numb=m.manager_iden_card_numb,
                                           manager_name=c.name
                                       };

            var topModel=  (from m in ctx.Model 
                            let maxSr = ctx.Model.Max(m => m.success_rate)
                            where m.success_rate == maxSr
                            select m).FirstOrDefault();

            txtTopModel.Text = topModel.name + " " + topModel.surname;

            var topCustomer= (from c in ctx.Customer
                             join o in ctx.Offer on c.iden_card_numb equals o.Customer.iden_card_numb
                             let maxBudget= ctx.Offer.Max(o => o.budget)
                             where o.budget == maxBudget
                             select c).FirstOrDefault();

           //var top2Customer = ctx.ExecuteQuery<object>("SELECT TOP(1) C.iden_card_numb, COUNT(*) from dbo.Customer C inner join dbo.Offer O on C.iden_card_numb = O.customer_iden_card_numbwhere O.status = 'approved' group by C.iden_card_numborder by COUNT(*) DESC; ");

            txtCustomerWithHighestBudget.Text = topCustomer.name + " " + topCustomer.surname;

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

        }
    }
}