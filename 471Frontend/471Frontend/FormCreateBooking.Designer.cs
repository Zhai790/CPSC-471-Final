namespace _471Frontend
{
    partial class FormCreateBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newbookingtitle = new System.Windows.Forms.Label();
            this.locationoptions = new System.Windows.Forms.ComboBox();
            this.fname = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.sailstarttime = new System.Windows.Forms.DateTimePicker();
            this.sailDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sailingbookingtitle = new System.Windows.Forms.Label();
            this.submitbtnnewbookingSailing = new System.Windows.Forms.Button();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.sustomerinfotitle = new System.Windows.Forms.Label();
            this.selectboattype = new System.Windows.Forms.Label();
            this.boatOptions = new System.Windows.Forms.ComboBox();
            this.selecttime = new System.Windows.Forms.Label();
            this.selectdate = new System.Windows.Forms.Label();
            this.locationtitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.ammenitesbookingtitle = new System.Windows.Forms.Label();
            this.newAmmenitiesSbmt = new System.Windows.Forms.Button();
            this.memberinputtxt = new System.Windows.Forms.TextBox();
            this.membernumtitle = new System.Windows.Forms.Label();
            this.selectammenitiestitle = new System.Windows.Forms.Label();
            this.amenBookingbox = new System.Windows.Forms.ComboBox();
            this.loactiontitleammenities = new System.Windows.Forms.Label();
            this.amenLocationBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.newbookingtitle);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 99);
            this.panel1.TabIndex = 1;
            // 
            // newbookingtitle
            // 
            this.newbookingtitle.AutoSize = true;
            this.newbookingtitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newbookingtitle.Location = new System.Drawing.Point(403, 29);
            this.newbookingtitle.Name = "newbookingtitle";
            this.newbookingtitle.Size = new System.Drawing.Size(384, 47);
            this.newbookingtitle.TabIndex = 0;
            this.newbookingtitle.Text = "New Booking Request";
            // 
            // locationoptions
            // 
            this.locationoptions.FormattingEnabled = true;
            this.locationoptions.Items.AddRange(new object[] {
            "Location 1",
            "Location 2",
            "Location 3"});
            this.locationoptions.Location = new System.Drawing.Point(179, 96);
            this.locationoptions.Name = "locationoptions";
            this.locationoptions.Size = new System.Drawing.Size(218, 23);
            this.locationoptions.TabIndex = 2;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(530, 192);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(67, 15);
            this.fname.TabIndex = 5;
            this.fname.Text = "First Name:";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel2.Controls.Add(this.sailstarttime);
            this.Panel2.Controls.Add(this.sailDatePicker);
            this.Panel2.Controls.Add(this.sailingbookingtitle);
            this.Panel2.Controls.Add(this.submitbtnnewbookingSailing);
            this.Panel2.Controls.Add(this.lnametxt);
            this.Panel2.Controls.Add(this.fnametxt);
            this.Panel2.Controls.Add(this.lname);
            this.Panel2.Controls.Add(this.sustomerinfotitle);
            this.Panel2.Controls.Add(this.selectboattype);
            this.Panel2.Controls.Add(this.fname);
            this.Panel2.Controls.Add(this.boatOptions);
            this.Panel2.Controls.Add(this.selecttime);
            this.Panel2.Controls.Add(this.selectdate);
            this.Panel2.Controls.Add(this.locationtitle);
            this.Panel2.Controls.Add(this.locationoptions);
            this.Panel2.Location = new System.Drawing.Point(58, 128);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1104, 420);
            this.Panel2.TabIndex = 7;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // sailstarttime
            // 
            this.sailstarttime.CustomFormat = "HH:mm:ss ";
            this.sailstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sailstarttime.Location = new System.Drawing.Point(179, 184);
            this.sailstarttime.Name = "sailstarttime";
            this.sailstarttime.ShowUpDown = true;
            this.sailstarttime.Size = new System.Drawing.Size(218, 23);
            this.sailstarttime.TabIndex = 34;
            this.sailstarttime.Value = new System.DateTime(2022, 12, 7, 12, 17, 10, 0);
            // 
            // sailDatePicker
            // 
            this.sailDatePicker.CustomFormat = "yyyy-mm-dd";
            this.sailDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sailDatePicker.Location = new System.Drawing.Point(179, 272);
            this.sailDatePicker.Name = "sailDatePicker";
            this.sailDatePicker.Size = new System.Drawing.Size(218, 23);
            this.sailDatePicker.TabIndex = 33;
            // 
            // sailingbookingtitle
            // 
            this.sailingbookingtitle.AutoSize = true;
            this.sailingbookingtitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sailingbookingtitle.Location = new System.Drawing.Point(386, 20);
            this.sailingbookingtitle.Name = "sailingbookingtitle";
            this.sailingbookingtitle.Size = new System.Drawing.Size(291, 32);
            this.sailingbookingtitle.TabIndex = 19;
            this.sailingbookingtitle.Text = "Sailing Booking Request";
            // 
            // submitbtnnewbookingSailing
            // 
            this.submitbtnnewbookingSailing.BackColor = System.Drawing.Color.LightSlateGray;
            this.submitbtnnewbookingSailing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitbtnnewbookingSailing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitbtnnewbookingSailing.Location = new System.Drawing.Point(530, 310);
            this.submitbtnnewbookingSailing.Name = "submitbtnnewbookingSailing";
            this.submitbtnnewbookingSailing.Size = new System.Drawing.Size(487, 51);
            this.submitbtnnewbookingSailing.TabIndex = 17;
            this.submitbtnnewbookingSailing.Text = "Submit";
            this.submitbtnnewbookingSailing.UseVisualStyleBackColor = false;
            this.submitbtnnewbookingSailing.Click += new System.EventHandler(this.submitbtnnewbookingSailing_Click);
            // 
            // lnametxt
            // 
            this.lnametxt.Location = new System.Drawing.Point(814, 211);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(190, 23);
            this.lnametxt.TabIndex = 12;
            // 
            // fnametxt
            // 
            this.fnametxt.Location = new System.Drawing.Point(530, 211);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(190, 23);
            this.fnametxt.TabIndex = 13;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(814, 193);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(66, 15);
            this.lname.TabIndex = 12;
            this.lname.Text = "Last Name:";
            // 
            // sustomerinfotitle
            // 
            this.sustomerinfotitle.AutoSize = true;
            this.sustomerinfotitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sustomerinfotitle.Location = new System.Drawing.Point(639, 131);
            this.sustomerinfotitle.Name = "sustomerinfotitle";
            this.sustomerinfotitle.Size = new System.Drawing.Size(238, 30);
            this.sustomerinfotitle.TabIndex = 11;
            this.sustomerinfotitle.Text = "Customer Information:";
            // 
            // selectboattype
            // 
            this.selectboattype.AutoSize = true;
            this.selectboattype.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectboattype.Location = new System.Drawing.Point(179, 336);
            this.selectboattype.Name = "selectboattype";
            this.selectboattype.Size = new System.Drawing.Size(115, 25);
            this.selectboattype.TabIndex = 10;
            this.selectboattype.Text = "Select Boat:";
            this.selectboattype.Click += new System.EventHandler(this.selectboattype_Click);
            // 
            // boatOptions
            // 
            this.boatOptions.FormattingEnabled = true;
            this.boatOptions.Items.AddRange(new object[] {
            "Sailboat",
            "Canoe"});
            this.boatOptions.Location = new System.Drawing.Point(179, 370);
            this.boatOptions.Name = "boatOptions";
            this.boatOptions.Size = new System.Drawing.Size(218, 23);
            this.boatOptions.TabIndex = 9;
            // 
            // selecttime
            // 
            this.selecttime.AutoSize = true;
            this.selecttime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selecttime.Location = new System.Drawing.Point(179, 150);
            this.selecttime.Name = "selecttime";
            this.selecttime.Size = new System.Drawing.Size(117, 25);
            this.selecttime.TabIndex = 7;
            this.selecttime.Text = "Select Time:";
            // 
            // selectdate
            // 
            this.selectdate.AutoSize = true;
            this.selectdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectdate.Location = new System.Drawing.Point(179, 244);
            this.selectdate.Name = "selectdate";
            this.selectdate.Size = new System.Drawing.Size(115, 25);
            this.selectdate.TabIndex = 6;
            this.selectdate.Text = "Select Date:";
            this.selectdate.Click += new System.EventHandler(this.label1_Click);
            // 
            // locationtitle
            // 
            this.locationtitle.AutoSize = true;
            this.locationtitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.locationtitle.Location = new System.Drawing.Point(179, 68);
            this.locationtitle.Name = "locationtitle";
            this.locationtitle.Size = new System.Drawing.Size(151, 25);
            this.locationtitle.TabIndex = 5;
            this.locationtitle.Text = "Select Location:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.ammenitesbookingtitle);
            this.panel3.Controls.Add(this.newAmmenitiesSbmt);
            this.panel3.Controls.Add(this.memberinputtxt);
            this.panel3.Controls.Add(this.membernumtitle);
            this.panel3.Controls.Add(this.selectammenitiestitle);
            this.panel3.Controls.Add(this.amenBookingbox);
            this.panel3.Controls.Add(this.loactiontitleammenities);
            this.panel3.Controls.Add(this.amenLocationBox);
            this.panel3.Location = new System.Drawing.Point(58, 567);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 319);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ammenitesbookingtitle
            // 
            this.ammenitesbookingtitle.AutoSize = true;
            this.ammenitesbookingtitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ammenitesbookingtitle.Location = new System.Drawing.Point(370, 20);
            this.ammenitesbookingtitle.Name = "ammenitesbookingtitle";
            this.ammenitesbookingtitle.Size = new System.Drawing.Size(350, 32);
            this.ammenitesbookingtitle.TabIndex = 18;
            this.ammenitesbookingtitle.Text = "Ammenities Booking Request";
            // 
            // newAmmenitiesSbmt
            // 
            this.newAmmenitiesSbmt.BackColor = System.Drawing.Color.LightSlateGray;
            this.newAmmenitiesSbmt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newAmmenitiesSbmt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newAmmenitiesSbmt.Location = new System.Drawing.Point(292, 215);
            this.newAmmenitiesSbmt.Name = "newAmmenitiesSbmt";
            this.newAmmenitiesSbmt.Size = new System.Drawing.Size(487, 51);
            this.newAmmenitiesSbmt.TabIndex = 17;
            this.newAmmenitiesSbmt.Text = "Submit";
            this.newAmmenitiesSbmt.UseVisualStyleBackColor = false;
            this.newAmmenitiesSbmt.Click += new System.EventHandler(this.newAmmenitiesSbmt_Click);
            // 
            // memberinputtxt
            // 
            this.memberinputtxt.Location = new System.Drawing.Point(706, 128);
            this.memberinputtxt.Name = "memberinputtxt";
            this.memberinputtxt.Size = new System.Drawing.Size(218, 23);
            this.memberinputtxt.TabIndex = 12;
            // 
            // membernumtitle
            // 
            this.membernumtitle.AutoSize = true;
            this.membernumtitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.membernumtitle.Location = new System.Drawing.Point(706, 100);
            this.membernumtitle.Name = "membernumtitle";
            this.membernumtitle.Size = new System.Drawing.Size(172, 25);
            this.membernumtitle.TabIndex = 11;
            this.membernumtitle.Text = "Member Number:";
            // 
            // selectammenitiestitle
            // 
            this.selectammenitiestitle.AutoSize = true;
            this.selectammenitiestitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectammenitiestitle.Location = new System.Drawing.Point(446, 100);
            this.selectammenitiestitle.Name = "selectammenitiestitle";
            this.selectammenitiestitle.Size = new System.Drawing.Size(150, 25);
            this.selectammenitiestitle.TabIndex = 10;
            this.selectammenitiestitle.Text = "Select Booking:";
            this.selectammenitiestitle.Click += new System.EventHandler(this.selectammenitiestitle_Click);
            // 
            // amenBookingbox
            // 
            this.amenBookingbox.FormattingEnabled = true;
            this.amenBookingbox.Items.AddRange(new object[] {
            "Swimming Pool",
            "Barbeque"});
            this.amenBookingbox.Location = new System.Drawing.Point(446, 128);
            this.amenBookingbox.Name = "amenBookingbox";
            this.amenBookingbox.Size = new System.Drawing.Size(218, 23);
            this.amenBookingbox.TabIndex = 9;
            // 
            // loactiontitleammenities
            // 
            this.loactiontitleammenities.AutoSize = true;
            this.loactiontitleammenities.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loactiontitleammenities.Location = new System.Drawing.Point(179, 100);
            this.loactiontitleammenities.Name = "loactiontitleammenities";
            this.loactiontitleammenities.Size = new System.Drawing.Size(151, 25);
            this.loactiontitleammenities.TabIndex = 5;
            this.loactiontitleammenities.Text = "Select Location:";
            // 
            // amenLocationBox
            // 
            this.amenLocationBox.FormattingEnabled = true;
            this.amenLocationBox.Items.AddRange(new object[] {
            "Location 1",
            "Location 2",
            "Location 3"});
            this.amenLocationBox.Location = new System.Drawing.Point(179, 128);
            this.amenLocationBox.Name = "amenLocationBox";
            this.amenLocationBox.Size = new System.Drawing.Size(218, 23);
            this.amenLocationBox.TabIndex = 2;
            // 
            // FormCreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1236, 913);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCreateBooking";
            this.Text = "Create New Booking";
            this.Load += new System.EventHandler(this.FormCreateBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label newbookingtitle;
        private ComboBox locationoptions;
        private Label fname;
        private Panel Panel2;
        private Label selectdate;
        private Label locationtitle;
        private ContextMenuStrip contextMenuStrip1;
        private Label selecttime;
        private Label sustomerinfotitle;
        private Label selectboattype;
        private ComboBox boatOptions;
        private TextBox lnametxt;
        private TextBox fnametxt;
        private Label lname;
        private Button submitbtnnewbookingSailing;
        private Panel panel3;
        private Button newAmmenitiesSbmt;
        private TextBox memberinputtxt;
        private Label membernumtitle;
        private Label selectammenitiestitle;
        private ComboBox amenBookingbox;
        private Label loactiontitleammenities;
        private ComboBox amenLocationBox;
        private Label sailingbookingtitle;
        private Label ammenitesbookingtitle;
        private DateTimePicker sailDatePicker;
        private DateTimePicker sailstarttime;
    }
}