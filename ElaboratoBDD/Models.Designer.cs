namespace ElaboratoBDD
{
    partial class Models
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnInsertModel = new System.Windows.Forms.Button();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWaist = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShoesNumber = new System.Windows.Forms.TextBox();
            this.txtHairColor = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEyesColor = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIdenCardNumb = new System.Windows.Forms.TextBox();
            this.Photos = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Photos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modelle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(852, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(ElaboratoBDD.Model);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.dtpBirthDate);
            this.groupBox2.Controls.Add(this.btnInsertModel);
            this.groupBox2.Controls.Add(this.cmbManager);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtWaist);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtShoesNumber);
            this.groupBox2.Controls.Add(this.txtHairColor);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.txtEyesColor);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtIdenCardNumb);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(235, 84);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(182, 23);
            this.dtpBirthDate.TabIndex = 29;
            // 
            // btnInsertModel
            // 
            this.btnInsertModel.Location = new System.Drawing.Point(235, 305);
            this.btnInsertModel.Name = "btnInsertModel";
            this.btnInsertModel.Size = new System.Drawing.Size(84, 39);
            this.btnInsertModel.TabIndex = 28;
            this.btnInsertModel.Text = "INSERT";
            this.btnInsertModel.UseVisualStyleBackColor = true;
            this.btnInsertModel.Click += new System.EventHandler(this.btnInsertModel_Click);
            // 
            // cmbManager
            // 
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Location = new System.Drawing.Point(15, 323);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(182, 23);
            this.cmbManager.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "waist";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "manager";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "height";
            // 
            // txtWaist
            // 
            this.txtWaist.Location = new System.Drawing.Point(235, 273);
            this.txtWaist.Name = "txtWaist";
            this.txtWaist.Size = new System.Drawing.Size(182, 23);
            this.txtWaist.TabIndex = 21;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(15, 273);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(182, 23);
            this.txtHeight.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "shoes_number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "eyes_color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "birth_date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "hair_color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "iden_card_numb";
            // 
            // txtShoesNumber
            // 
            this.txtShoesNumber.Location = new System.Drawing.Point(235, 229);
            this.txtShoesNumber.Name = "txtShoesNumber";
            this.txtShoesNumber.Size = new System.Drawing.Size(182, 23);
            this.txtShoesNumber.TabIndex = 9;
            // 
            // txtHairColor
            // 
            this.txtHairColor.Location = new System.Drawing.Point(15, 229);
            this.txtHairColor.Name = "txtHairColor";
            this.txtHairColor.Size = new System.Drawing.Size(182, 23);
            this.txtHairColor.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(235, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(15, 179);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(182, 23);
            this.txtAge.TabIndex = 6;
            // 
            // txtEyesColor
            // 
            this.txtEyesColor.Location = new System.Drawing.Point(235, 130);
            this.txtEyesColor.Name = "txtEyesColor";
            this.txtEyesColor.Size = new System.Drawing.Size(182, 23);
            this.txtEyesColor.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 130);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(182, 23);
            this.txtAddress.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(15, 84);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(182, 23);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtIdenCardNumb
            // 
            this.txtIdenCardNumb.Location = new System.Drawing.Point(15, 36);
            this.txtIdenCardNumb.Name = "txtIdenCardNumb";
            this.txtIdenCardNumb.Size = new System.Drawing.Size(182, 23);
            this.txtIdenCardNumb.TabIndex = 0;
            // 
            // Photos
            // 
            this.Photos.Controls.Add(this.btnNext);
            this.Photos.Controls.Add(this.pictureBox1);
            this.Photos.Controls.Add(this.btnSelectImage);
            this.Photos.Location = new System.Drawing.Point(464, 259);
            this.Photos.Name = "Photos";
            this.Photos.Size = new System.Drawing.Size(432, 350);
            this.Photos.TabIndex = 2;
            this.Photos.TabStop = false;
            this.Photos.Text = "Update";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(226, 36);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(189, 45);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 230);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(20, 36);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(189, 45);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "SELECT IMAGE";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(333, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 39);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Models
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 621);
            this.Controls.Add(this.Photos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Models";
            this.Text = "Models";
            this.Load += new System.EventHandler(this.Models_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Photos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox Photos;
        private DataGridView dataGridView1;
        private BindingSource modelBindingSource;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtShoesNumber;
        private TextBox txtHairColor;
        private TextBox txtEmail;
        private TextBox txtAge;
        private TextBox txtEyesColor;
        private TextBox txtAddress;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtIdenCardNumb;
        private Button btnInsertModel;
        private ComboBox cmbManager;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtWaist;
        private TextBox txtHeight;
        private Button btnSelectImage;
        private OpenFileDialog openFileDialog1;
        private Button btnNext;
        private PictureBox pictureBox1;
        private DateTimePicker dtpBirthDate;
        private Button btnUpdate;
    }
}