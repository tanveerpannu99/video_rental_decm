namespace video_rental_decm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VideoDelete = new System.Windows.Forms.Button();
            this.VideoUpdate = new System.Windows.Forms.Button();
            this.VideoAdd = new System.Windows.Forms.Button();
            this.VideoCopies = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.VideoCost = new System.Windows.Forms.TextBox();
            this.VideoDate = new System.Windows.Forms.TextBox();
            this.VideoRatting = new System.Windows.Forms.TextBox();
            this.VideoName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustomerDelete = new System.Windows.Forms.Button();
            this.CustomerAdd = new System.Windows.Forms.Button();
            this.CustomerUpdate = new System.Windows.Forms.Button();
            this.CustomerCountry = new System.Windows.Forms.TextBox();
            this.CustomerContact = new System.Windows.Forms.TextBox();
            this.CustomerCity = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PopularCustomer = new System.Windows.Forms.Button();
            this.RetnalVideoDelete = new System.Windows.Forms.Button();
            this.PopularVideo = new System.Windows.Forms.Button();
            this.VideoReturn = new System.Windows.Forms.Button();
            this.VideoIssue = new System.Windows.Forms.Button();
            this.RentalReturnDate = new System.Windows.Forms.DateTimePicker();
            this.RentalIssueDate = new System.Windows.Forms.DateTimePicker();
            this.CustomerPkID = new System.Windows.Forms.TextBox();
            this.VideoPkID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.VideoData = new System.Windows.Forms.Button();
            this.CustomerData = new System.Windows.Forms.Button();
            this.RentalData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.VideoDelete);
            this.groupBox1.Controls.Add(this.VideoUpdate);
            this.groupBox1.Controls.Add(this.VideoAdd);
            this.groupBox1.Controls.Add(this.VideoCopies);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.VideoCost);
            this.groupBox1.Controls.Add(this.VideoDate);
            this.groupBox1.Controls.Add(this.VideoRatting);
            this.groupBox1.Controls.Add(this.VideoName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Data";
            // 
            // VideoDelete
            // 
            this.VideoDelete.Location = new System.Drawing.Point(78, 335);
            this.VideoDelete.Name = "VideoDelete";
            this.VideoDelete.Size = new System.Drawing.Size(98, 34);
            this.VideoDelete.TabIndex = 15;
            this.VideoDelete.Text = "Delete data";
            this.VideoDelete.UseVisualStyleBackColor = true;
            this.VideoDelete.Click += new System.EventHandler(this.VideoDelete_Click);
            // 
            // VideoUpdate
            // 
            this.VideoUpdate.Location = new System.Drawing.Point(150, 295);
            this.VideoUpdate.Name = "VideoUpdate";
            this.VideoUpdate.Size = new System.Drawing.Size(98, 34);
            this.VideoUpdate.TabIndex = 14;
            this.VideoUpdate.Text = "Update data";
            this.VideoUpdate.UseVisualStyleBackColor = true;
            this.VideoUpdate.Click += new System.EventHandler(this.VideoUpdate_Click);
            // 
            // VideoAdd
            // 
            this.VideoAdd.Location = new System.Drawing.Point(9, 295);
            this.VideoAdd.Name = "VideoAdd";
            this.VideoAdd.Size = new System.Drawing.Size(98, 34);
            this.VideoAdd.TabIndex = 13;
            this.VideoAdd.Text = "Add data";
            this.VideoAdd.UseVisualStyleBackColor = true;
            this.VideoAdd.Click += new System.EventHandler(this.VideoAdd_Click);
            // 
            // VideoCopies
            // 
            this.VideoCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoCopies.Location = new System.Drawing.Point(120, 253);
            this.VideoCopies.Name = "VideoCopies";
            this.VideoCopies.Size = new System.Drawing.Size(148, 29);
            this.VideoCopies.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total Copies";
            // 
            // VideoCost
            // 
            this.VideoCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoCost.Location = new System.Drawing.Point(120, 191);
            this.VideoCost.Name = "VideoCost";
            this.VideoCost.ReadOnly = true;
            this.VideoCost.Size = new System.Drawing.Size(148, 29);
            this.VideoCost.TabIndex = 10;
            // 
            // VideoDate
            // 
            this.VideoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoDate.Location = new System.Drawing.Point(120, 133);
            this.VideoDate.Name = "VideoDate";
            this.VideoDate.Size = new System.Drawing.Size(148, 29);
            this.VideoDate.TabIndex = 9;
            // 
            // VideoRatting
            // 
            this.VideoRatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoRatting.Location = new System.Drawing.Point(120, 84);
            this.VideoRatting.Name = "VideoRatting";
            this.VideoRatting.Size = new System.Drawing.Size(148, 29);
            this.VideoRatting.TabIndex = 8;
            // 
            // VideoName
            // 
            this.VideoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoName.Location = new System.Drawing.Point(120, 34);
            this.VideoName.Name = "VideoName";
            this.VideoName.Size = new System.Drawing.Size(148, 29);
            this.VideoName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rate  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lauch Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per copy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox2.Controls.Add(this.CustomerDelete);
            this.groupBox2.Controls.Add(this.CustomerAdd);
            this.groupBox2.Controls.Add(this.CustomerUpdate);
            this.groupBox2.Controls.Add(this.CustomerCountry);
            this.groupBox2.Controls.Add(this.CustomerContact);
            this.groupBox2.Controls.Add(this.CustomerCity);
            this.groupBox2.Controls.Add(this.CustomerName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(347, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 398);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer  Data";
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.Location = new System.Drawing.Point(95, 335);
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.Size = new System.Drawing.Size(98, 34);
            this.CustomerDelete.TabIndex = 16;
            this.CustomerDelete.Text = "Delete data";
            this.CustomerDelete.UseVisualStyleBackColor = true;
            this.CustomerDelete.Click += new System.EventHandler(this.CustomerDelete_Click);
            // 
            // CustomerAdd
            // 
            this.CustomerAdd.Location = new System.Drawing.Point(23, 272);
            this.CustomerAdd.Name = "CustomerAdd";
            this.CustomerAdd.Size = new System.Drawing.Size(98, 34);
            this.CustomerAdd.TabIndex = 16;
            this.CustomerAdd.Text = "Add data";
            this.CustomerAdd.UseVisualStyleBackColor = true;
            this.CustomerAdd.Click += new System.EventHandler(this.CustomerAdd_Click);
            // 
            // CustomerUpdate
            // 
            this.CustomerUpdate.Location = new System.Drawing.Point(174, 272);
            this.CustomerUpdate.Name = "CustomerUpdate";
            this.CustomerUpdate.Size = new System.Drawing.Size(98, 34);
            this.CustomerUpdate.TabIndex = 16;
            this.CustomerUpdate.Text = "Update data";
            this.CustomerUpdate.UseVisualStyleBackColor = true;
            this.CustomerUpdate.Click += new System.EventHandler(this.CustomerUpdate_Click);
            // 
            // CustomerCountry
            // 
            this.CustomerCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCountry.Location = new System.Drawing.Point(108, 200);
            this.CustomerCountry.Name = "CustomerCountry";
            this.CustomerCountry.Size = new System.Drawing.Size(148, 29);
            this.CustomerCountry.TabIndex = 19;
            // 
            // CustomerContact
            // 
            this.CustomerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerContact.Location = new System.Drawing.Point(108, 142);
            this.CustomerContact.Name = "CustomerContact";
            this.CustomerContact.Size = new System.Drawing.Size(148, 29);
            this.CustomerContact.TabIndex = 18;
            // 
            // CustomerCity
            // 
            this.CustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCity.Location = new System.Drawing.Point(108, 93);
            this.CustomerCity.Name = "CustomerCity";
            this.CustomerCity.Size = new System.Drawing.Size(148, 29);
            this.CustomerCity.TabIndex = 17;
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(108, 34);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(148, 29);
            this.CustomerName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name: CM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "City: CM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone :CM";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox3.Controls.Add(this.PopularCustomer);
            this.groupBox3.Controls.Add(this.RetnalVideoDelete);
            this.groupBox3.Controls.Add(this.PopularVideo);
            this.groupBox3.Controls.Add(this.VideoReturn);
            this.groupBox3.Controls.Add(this.VideoIssue);
            this.groupBox3.Controls.Add(this.RentalReturnDate);
            this.groupBox3.Controls.Add(this.RentalIssueDate);
            this.groupBox3.Controls.Add(this.CustomerPkID);
            this.groupBox3.Controls.Add(this.VideoPkID);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(668, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 398);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental  Data";
            // 
            // PopularCustomer
            // 
            this.PopularCustomer.Location = new System.Drawing.Point(203, 352);
            this.PopularCustomer.Name = "PopularCustomer";
            this.PopularCustomer.Size = new System.Drawing.Size(113, 36);
            this.PopularCustomer.TabIndex = 25;
            this.PopularCustomer.Text = "Customr";
            this.PopularCustomer.UseVisualStyleBackColor = true;
            this.PopularCustomer.Click += new System.EventHandler(this.PopularCustomer_Click);
            // 
            // RetnalVideoDelete
            // 
            this.RetnalVideoDelete.Location = new System.Drawing.Point(79, 295);
            this.RetnalVideoDelete.Name = "RetnalVideoDelete";
            this.RetnalVideoDelete.Size = new System.Drawing.Size(98, 34);
            this.RetnalVideoDelete.TabIndex = 20;
            this.RetnalVideoDelete.Text = "Delete data";
            this.RetnalVideoDelete.UseVisualStyleBackColor = true;
            this.RetnalVideoDelete.Click += new System.EventHandler(this.RetnalVideoDelete_Click);
            // 
            // PopularVideo
            // 
            this.PopularVideo.Location = new System.Drawing.Point(203, 310);
            this.PopularVideo.Name = "PopularVideo";
            this.PopularVideo.Size = new System.Drawing.Size(113, 36);
            this.PopularVideo.TabIndex = 24;
            this.PopularVideo.Text = "Popular MV";
            this.PopularVideo.UseVisualStyleBackColor = true;
            this.PopularVideo.Click += new System.EventHandler(this.PopularVideo_Click);
            // 
            // VideoReturn
            // 
            this.VideoReturn.Location = new System.Drawing.Point(151, 235);
            this.VideoReturn.Name = "VideoReturn";
            this.VideoReturn.Size = new System.Drawing.Size(98, 34);
            this.VideoReturn.TabIndex = 20;
            this.VideoReturn.Text = "Return";
            this.VideoReturn.UseVisualStyleBackColor = true;
            this.VideoReturn.Click += new System.EventHandler(this.VideoReturn_Click);
            // 
            // VideoIssue
            // 
            this.VideoIssue.Location = new System.Drawing.Point(22, 235);
            this.VideoIssue.Name = "VideoIssue";
            this.VideoIssue.Size = new System.Drawing.Size(98, 34);
            this.VideoIssue.TabIndex = 20;
            this.VideoIssue.Text = "Issue";
            this.VideoIssue.UseVisualStyleBackColor = true;
            this.VideoIssue.Click += new System.EventHandler(this.VideoIssue_Click);
            // 
            // RentalReturnDate
            // 
            this.RentalReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RentalReturnDate.Location = new System.Drawing.Point(164, 176);
            this.RentalReturnDate.Name = "RentalReturnDate";
            this.RentalReturnDate.Size = new System.Drawing.Size(137, 20);
            this.RentalReturnDate.TabIndex = 23;
            // 
            // RentalIssueDate
            // 
            this.RentalIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RentalIssueDate.Location = new System.Drawing.Point(164, 133);
            this.RentalIssueDate.Name = "RentalIssueDate";
            this.RentalIssueDate.Size = new System.Drawing.Size(137, 20);
            this.RentalIssueDate.TabIndex = 22;
            // 
            // CustomerPkID
            // 
            this.CustomerPkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPkID.Location = new System.Drawing.Point(164, 84);
            this.CustomerPkID.Name = "CustomerPkID";
            this.CustomerPkID.Size = new System.Drawing.Size(137, 29);
            this.CustomerPkID.TabIndex = 21;
            // 
            // VideoPkID
            // 
            this.VideoPkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoPkID.Location = new System.Drawing.Point(164, 34);
            this.VideoPkID.Name = "VideoPkID";
            this.VideoPkID.Size = new System.Drawing.Size(137, 29);
            this.VideoPkID.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Return Issued Movie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Issue on Rent:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Customer UNQ ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Movie UNQ ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 460);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(821, 218);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // VideoData
            // 
            this.VideoData.Location = new System.Drawing.Point(848, 460);
            this.VideoData.Name = "VideoData";
            this.VideoData.Size = new System.Drawing.Size(113, 36);
            this.VideoData.TabIndex = 26;
            this.VideoData.Text = "Video Data";
            this.VideoData.UseVisualStyleBackColor = true;
            this.VideoData.Click += new System.EventHandler(this.VideoData_Click);
            // 
            // CustomerData
            // 
            this.CustomerData.Location = new System.Drawing.Point(848, 550);
            this.CustomerData.Name = "CustomerData";
            this.CustomerData.Size = new System.Drawing.Size(113, 36);
            this.CustomerData.TabIndex = 27;
            this.CustomerData.Text = "Customr Data";
            this.CustomerData.UseVisualStyleBackColor = true;
            this.CustomerData.Click += new System.EventHandler(this.CustomerData_Click);
            // 
            // RentalData
            // 
            this.RentalData.Location = new System.Drawing.Point(848, 642);
            this.RentalData.Name = "RentalData";
            this.RentalData.Size = new System.Drawing.Size(113, 36);
            this.RentalData.TabIndex = 28;
            this.RentalData.Text = "Rental Data";
            this.RentalData.UseVisualStyleBackColor = true;
            this.RentalData.Click += new System.EventHandler(this.RentalData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 677);
            this.Controls.Add(this.VideoData);
            this.Controls.Add(this.CustomerData);
            this.Controls.Add(this.RentalData);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VideoDelete;
        private System.Windows.Forms.Button VideoUpdate;
        private System.Windows.Forms.Button VideoAdd;
        private System.Windows.Forms.TextBox VideoCopies;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox VideoCost;
        private System.Windows.Forms.TextBox VideoDate;
        private System.Windows.Forms.TextBox VideoRatting;
        private System.Windows.Forms.TextBox VideoName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CustomerDelete;
        private System.Windows.Forms.Button CustomerAdd;
        private System.Windows.Forms.Button CustomerUpdate;
        private System.Windows.Forms.TextBox CustomerCountry;
        private System.Windows.Forms.TextBox CustomerContact;
        private System.Windows.Forms.TextBox CustomerCity;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PopularCustomer;
        private System.Windows.Forms.Button RetnalVideoDelete;
        private System.Windows.Forms.Button PopularVideo;
        private System.Windows.Forms.Button VideoReturn;
        private System.Windows.Forms.Button VideoIssue;
        private System.Windows.Forms.DateTimePicker RentalReturnDate;
        private System.Windows.Forms.DateTimePicker RentalIssueDate;
        private System.Windows.Forms.TextBox CustomerPkID;
        private System.Windows.Forms.TextBox VideoPkID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button VideoData;
        private System.Windows.Forms.Button CustomerData;
        private System.Windows.Forms.Button RentalData;
    }
}

