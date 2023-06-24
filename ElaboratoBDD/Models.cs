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
    public partial class Models : Form
    {
        ModelAgencyDataContext ctx = new ModelAgencyDataContext();
        List<string> _surrentModelPhotosPath = new List<string>();
        int current = 0;
        public Models()
        {
            InitializeComponent();
        }

        private void refresh_models_table()
        {
            dataGridView1.DataSource = (from m in ctx.Model
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
                                            success_rate = m.success_rate,
                                        }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = null;
            this._surrentModelPhotosPath.Clear();
            this.current = 0;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            var images = from m in ctx.Model
                         where m.iden_card_numb == row.Cells[0].Value.ToString()
                         select m.Photo;

            var model = (from m in ctx.Model
                        where m.iden_card_numb == row.Cells[0].Value.ToString()
                        select m).FirstOrDefault();

            foreach (var image in images)
            {
                foreach (var i in image)
                {
                    this._surrentModelPhotosPath.Add(i.path);
                }
            }

            if (this._surrentModelPhotosPath.Count > 0)
                pictureBox1.ImageLocation = String.Format(@".\..\Images\{0}", this._surrentModelPhotosPath[this.current]);

            this.fill_textBoxes(model);
        }

        private void fill_textBoxes(Model model)
        {

            txtName.Text = model.name==null ? "" : model.name;
            txtSurname.Text = model.surname==null ? "" : model.surname;
            txtIdenCardNumb.Text = model.iden_card_numb;
            txtAddress.Text = model.address==null ? "" : model.address;
            txtEmail.Text = model.email == null ? "" : model.email;
            txtWaist.Text = model.waist == null ? "" : model.waist.ToString();
            txtHeight.Text = model.height == null ? "" : model.height.ToString();
            txtHairColor.Text = model.hair_color == null ? "" : model.hair_color;
            if(model.birth_date!=null)
                dtpBirthDate.Value = Convert.ToDateTime(model.birth_date);
            txtEyesColor.Text = model.eyes_color == null ? "" : model.eyes_color;
            txtShoesNumber.Text = model.shoes_number == null ? "" : model.shoes_number.ToString();
            txtAge.Text = model.age == null ? "" : model.age.ToString();
            cmbManager.SelectedValue = model.manager_iden_card_numb.ToString();
        }

        private void Models_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            cmbManager.DataSource = (from m in ctx.Manager
                                     select m).ToList();
            cmbManager.DisplayMember = "name";
            cmbManager.ValueMember = "iden_card_numb";
            this.refresh_models_table();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

            this.openFileDialog1= new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Browse images";
            openFileDialog1.DefaultExt = "jpg";

            string filename=openFileDialog1.FileName;
            var splitted = filename.Split('\\');
            MessageBox.Show(splitted[splitted.Length - 1]);
            string new_filename = @".\..\Images\"+splitted[splitted.Length-1];
            File.Copy(filename, new_filename);

            var photo = new Photo();
            photo.path = new_filename;
            photo.name = splitted[splitted.Length-1];
            photo.size = new_filename.Length;
            photo.model_iden_card_numb = row.Cells[0].Value.ToString();

            ctx.Photo.InsertOnSubmit(photo);
            ctx.SubmitChanges();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this._surrentModelPhotosPath.Count - 1 == (this.current)) this.current = 0;
            else this.current++;

            if (this._surrentModelPhotosPath.Count > 0)
                pictureBox1.ImageLocation = String.Format(@".\..\Images\{0}", this._surrentModelPhotosPath[this.current]);
        }

        private void btnInsertModel_Click(object sender, EventArgs e)
        {
            var model = new Model();
            model.name = txtName.Text;
            model.surname = txtSurname.Text;
            model.iden_card_numb = txtIdenCardNumb.Text;
            model.address = txtAddress.Text;
            model.email = txtEmail.Text;
            model.waist = decimal.Parse(txtWaist.Text);
            model.height= decimal.Parse(txtHeight.Text);
            model.hair_color= txtHairColor.Text;
            model.birth_date = dtpBirthDate.Value;
            model.eyes_color = txtEyesColor.Text;
            model.shoes_number = Convert.ToInt16(txtShoesNumber.Text);
            model.age= Convert.ToInt16(txtAge.Text);
            model.manager_iden_card_numb = cmbManager.SelectedValue.ToString();

            ctx.Model.InsertOnSubmit(model);
            ctx.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = (from m in ctx.Model
                         where m.iden_card_numb== txtIdenCardNumb.Text
                         select m).FirstOrDefault();

            if (model != null)
            {
                if(txtName.Text!="")
                    model.name = txtName.Text;
                if(txtSurname.Text!="")
                    model.surname = txtSurname.Text;
                if(txtAddress.Text!="")
                    model.address = txtAddress.Text;
                if(txtEmail.Text!="")
                    model.email = txtEmail.Text;
                if(txtWaist.Text!="")
                    model.waist = decimal.Parse(txtWaist.Text);
                if(txtHeight.Text!="")
                    model.height = decimal.Parse(txtHeight.Text);
                if(txtHairColor.Text!="")
                    model.hair_color = txtHairColor.Text;
                if(dtpBirthDate.Value.Date != DateTime.Today.Date)
                    model.birth_date = dtpBirthDate.Value;
                if(txtEyesColor.Text!="")
                    model.eyes_color = txtEyesColor.Text;
                if(txtShoesNumber.Text!="")
                    model.shoes_number = Convert.ToInt16(txtShoesNumber.Text);
                if(txtAge.Text!="")
                    model.age = Convert.ToInt16(txtAge.Text);

                ctx.SubmitChanges();

                this.refresh_models_table();
            }
            

            
        }
    }
}
