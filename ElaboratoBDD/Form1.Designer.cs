namespace ElaboratoBDD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.offerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEarning = new System.Windows.Forms.TextBox();
            this.txtClosedOffers = new System.Windows.Forms.TextBox();
            this.txtCustomerWithHighestBudget = new System.Windows.Forms.TextBox();
            this.textCustomerWithMostCLosedOffers = new System.Windows.Forms.TextBox();
            this.txtTopModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.dtpTransportArrivalDT = new System.Windows.Forms.DateTimePicker();
            this.dtpTransportStartDT = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTransportDestPlace = new System.Windows.Forms.TextBox();
            this.txtTransportDepPlace = new System.Windows.Forms.TextBox();
            this.txtTransportDesc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransportType = new System.Windows.Forms.TextBox();
            this.cmbRelatedOffer = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.offerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // offerBindingSource
            // 
            this.offerBindingSource.DataSource = typeof(ElaboratoBDD.Offer);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(ElaboratoBDD.Customer);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.modelsToolStripMenuItem,
            this.locationsToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Checked = true;
            this.ordersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ordersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.ordersToolStripMenuItem.Text = "Dashboard";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // modelsToolStripMenuItem
            // 
            this.modelsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelsToolStripMenuItem.Name = "modelsToolStripMenuItem";
            this.modelsToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.modelsToolStripMenuItem.Text = "Models";
            this.modelsToolStripMenuItem.Click += new System.EventHandler(this.modelsToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.locationsToolStripMenuItem.Text = "Offers";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 187);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(ElaboratoBDD.Model);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEarning);
            this.groupBox1.Controls.Add(this.txtClosedOffers);
            this.groupBox1.Controls.Add(this.txtCustomerWithHighestBudget);
            this.groupBox1.Controls.Add(this.textCustomerWithMostCLosedOffers);
            this.groupBox1.Controls.Add(this.txtTopModel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // txtEarning
            // 
            this.txtEarning.Location = new System.Drawing.Point(308, 220);
            this.txtEarning.Name = "txtEarning";
            this.txtEarning.ReadOnly = true;
            this.txtEarning.Size = new System.Drawing.Size(171, 23);
            this.txtEarning.TabIndex = 9;
            // 
            // txtClosedOffers
            // 
            this.txtClosedOffers.Location = new System.Drawing.Point(308, 172);
            this.txtClosedOffers.Name = "txtClosedOffers";
            this.txtClosedOffers.ReadOnly = true;
            this.txtClosedOffers.Size = new System.Drawing.Size(171, 23);
            this.txtClosedOffers.TabIndex = 8;
            // 
            // txtCustomerWithHighestBudget
            // 
            this.txtCustomerWithHighestBudget.Location = new System.Drawing.Point(308, 128);
            this.txtCustomerWithHighestBudget.Name = "txtCustomerWithHighestBudget";
            this.txtCustomerWithHighestBudget.ReadOnly = true;
            this.txtCustomerWithHighestBudget.Size = new System.Drawing.Size(171, 23);
            this.txtCustomerWithHighestBudget.TabIndex = 7;
            // 
            // textCustomerWithMostCLosedOffers
            // 
            this.textCustomerWithMostCLosedOffers.Location = new System.Drawing.Point(308, 79);
            this.textCustomerWithMostCLosedOffers.Name = "textCustomerWithMostCLosedOffers";
            this.textCustomerWithMostCLosedOffers.ReadOnly = true;
            this.textCustomerWithMostCLosedOffers.Size = new System.Drawing.Size(171, 23);
            this.textCustomerWithMostCLosedOffers.TabIndex = 6;
            // 
            // txtTopModel
            // 
            this.txtTopModel.Location = new System.Drawing.Point(308, 35);
            this.txtTopModel.Name = "txtTopModel";
            this.txtTopModel.ReadOnly = true;
            this.txtTopModel.Size = new System.Drawing.Size(171, 23);
            this.txtTopModel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Earning total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of closed offer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer with the highest offer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer with most closed deals:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model with highest success rate:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.btnNextImage);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(518, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 263);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model Details";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 80);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(266, 220);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(218, 22);
            this.btnNextImage.TabIndex = 1;
            this.btnNextImage.Text = "Next";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(266, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnCreateEvent);
            this.groupBox3.Controls.Add(this.dtpTransportArrivalDT);
            this.groupBox3.Controls.Add(this.dtpTransportStartDT);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtTransportDestPlace);
            this.groupBox3.Controls.Add(this.txtTransportDepPlace);
            this.groupBox3.Controls.Add(this.txtTransportDesc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTransportType);
            this.groupBox3.Controls.Add(this.cmbRelatedOffer);
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Location = new System.Drawing.Point(12, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1008, 153);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Events";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(753, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Transport arrival datetime";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(534, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Transport start datetime";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(798, 104);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(109, 23);
            this.btnCreateEvent.TabIndex = 23;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // dtpTransportArrivalDT
            // 
            this.dtpTransportArrivalDT.Location = new System.Drawing.Point(753, 47);
            this.dtpTransportArrivalDT.Name = "dtpTransportArrivalDT";
            this.dtpTransportArrivalDT.Size = new System.Drawing.Size(200, 23);
            this.dtpTransportArrivalDT.TabIndex = 22;
            // 
            // dtpTransportStartDT
            // 
            this.dtpTransportStartDT.Location = new System.Drawing.Point(534, 105);
            this.dtpTransportStartDT.Name = "dtpTransportStartDT";
            this.dtpTransportStartDT.Size = new System.Drawing.Size(200, 23);
            this.dtpTransportStartDT.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(534, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Destination Place";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(387, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Departure Place";
            // 
            // txtTransportDestPlace
            // 
            this.txtTransportDestPlace.Location = new System.Drawing.Point(534, 47);
            this.txtTransportDestPlace.Name = "txtTransportDestPlace";
            this.txtTransportDestPlace.Size = new System.Drawing.Size(198, 23);
            this.txtTransportDestPlace.TabIndex = 18;
            // 
            // txtTransportDepPlace
            // 
            this.txtTransportDepPlace.Location = new System.Drawing.Point(387, 105);
            this.txtTransportDepPlace.Name = "txtTransportDepPlace";
            this.txtTransportDepPlace.Size = new System.Drawing.Size(121, 23);
            this.txtTransportDepPlace.TabIndex = 17;
            // 
            // txtTransportDesc
            // 
            this.txtTransportDesc.Location = new System.Drawing.Point(387, 47);
            this.txtTransportDesc.Name = "txtTransportDesc";
            this.txtTransportDesc.Size = new System.Drawing.Size(121, 23);
            this.txtTransportDesc.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Transport Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Transport Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Related Offer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "End datetime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Start datetime";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // txtTransportType
            // 
            this.txtTransportType.Location = new System.Drawing.Point(239, 105);
            this.txtTransportType.Name = "txtTransportType";
            this.txtTransportType.Size = new System.Drawing.Size(121, 23);
            this.txtTransportType.TabIndex = 5;
            // 
            // cmbRelatedOffer
            // 
            this.cmbRelatedOffer.FormattingEnabled = true;
            this.cmbRelatedOffer.Location = new System.Drawing.Point(239, 47);
            this.cmbRelatedOffer.Name = "cmbRelatedOffer";
            this.cmbRelatedOffer.Size = new System.Drawing.Size(121, 23);
            this.cmbRelatedOffer.TabIndex = 2;
            this.cmbRelatedOffer.SelectedIndexChanged += new System.EventHandler(this.cmbRelatedOffer_SelectedIndexChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(12, 102);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEndDate.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(12, 47);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDate.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(12, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "Calendario Eventi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 671);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource offerBindingSource;
        private BindingSource customerBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem modelsToolStripMenuItem;
        private ToolStripMenuItem locationsToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private DataGridView dataGridView1;
        private BindingSource modelBindingSource;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtEarning;
        private TextBox txtClosedOffers;
        private TextBox txtCustomerWithHighestBudget;
        private TextBox textCustomerWithMostCLosedOffers;
        private TextBox txtTopModel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox1;
        private Button btnNextImage;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox3;
        private ComboBox cmbRelatedOffer;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtTransportType;
        private Label label15;
        private Label label14;
        private Button btnCreateEvent;
        private DateTimePicker dtpTransportArrivalDT;
        private DateTimePicker dtpTransportStartDT;
        private Label label13;
        private Label label12;
        private TextBox txtTransportDestPlace;
        private TextBox txtTransportDepPlace;
        private TextBox txtTransportDesc;
        private Label label11;
        private Label label10;
        private System.Windows.Forms.Timer timer1;
        private Label label16;
    }
}