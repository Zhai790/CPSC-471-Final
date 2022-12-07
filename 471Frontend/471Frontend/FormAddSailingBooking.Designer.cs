namespace _471Frontend
{
    partial class FormAddSailingBooking
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.addsailtitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sailclientIDtxt = new System.Windows.Forms.ComboBox();
            this.saillocationtxt = new System.Windows.Forms.ComboBox();
            this.sailboatIDtxt = new System.Windows.Forms.ComboBox();
            this.sailstarttime = new System.Windows.Forms.DateTimePicker();
            this.sailtimepicker = new System.Windows.Forms.DateTimePicker();
            this.submitbtnsail = new System.Windows.Forms.Button();
            this.sailboatIDtitle = new System.Windows.Forms.Label();
            this.saillocationtitle = new System.Windows.Forms.Label();
            this.sailtimetitle = new System.Windows.Forms.Label();
            this.saildatetxt = new System.Windows.Forms.Label();
            this.sailclientIDtitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.addsailtitle);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 81);
            this.panel2.TabIndex = 1;
            // 
            // addsailtitle
            // 
            this.addsailtitle.AutoSize = true;
            this.addsailtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addsailtitle.Location = new System.Drawing.Point(139, 28);
            this.addsailtitle.Name = "addsailtitle";
            this.addsailtitle.Size = new System.Drawing.Size(264, 37);
            this.addsailtitle.TabIndex = 0;
            this.addsailtitle.Text = "Add Sailing Booking";
            this.addsailtitle.Click += new System.EventHandler(this.addclienttitle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.sailclientIDtxt);
            this.panel1.Controls.Add(this.saillocationtxt);
            this.panel1.Controls.Add(this.sailboatIDtxt);
            this.panel1.Controls.Add(this.sailstarttime);
            this.panel1.Controls.Add(this.sailtimepicker);
            this.panel1.Controls.Add(this.submitbtnsail);
            this.panel1.Controls.Add(this.sailboatIDtitle);
            this.panel1.Controls.Add(this.saillocationtitle);
            this.panel1.Controls.Add(this.sailtimetitle);
            this.panel1.Controls.Add(this.saildatetxt);
            this.panel1.Controls.Add(this.sailclientIDtitle);
            this.panel1.Location = new System.Drawing.Point(27, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 437);
            this.panel1.TabIndex = 2;
            // 
            // sailclientIDtxt
            // 
            this.sailclientIDtxt.FormattingEnabled = true;
            this.sailclientIDtxt.Location = new System.Drawing.Point(63, 51);
            this.sailclientIDtxt.Name = "sailclientIDtxt";
            this.sailclientIDtxt.Size = new System.Drawing.Size(121, 23);
            this.sailclientIDtxt.TabIndex = 16;
            this.sailclientIDtxt.SelectedIndexChanged += new System.EventHandler(this.sailclientIDtxt_SelectedIndexChanged);
            // 
            // saillocationtxt
            // 
            this.saillocationtxt.FormattingEnabled = true;
            this.saillocationtxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.saillocationtxt.Location = new System.Drawing.Point(63, 247);
            this.saillocationtxt.Name = "saillocationtxt";
            this.saillocationtxt.Size = new System.Drawing.Size(326, 23);
            this.saillocationtxt.TabIndex = 15;
            this.saillocationtxt.SelectedIndexChanged += new System.EventHandler(this.saillocationtxt_SelectedIndexChanged);
            // 
            // sailboatIDtxt
            // 
            this.sailboatIDtxt.FormattingEnabled = true;
            this.sailboatIDtxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.sailboatIDtxt.Location = new System.Drawing.Point(63, 314);
            this.sailboatIDtxt.Name = "sailboatIDtxt";
            this.sailboatIDtxt.Size = new System.Drawing.Size(133, 23);
            this.sailboatIDtxt.TabIndex = 14;
            this.sailboatIDtxt.SelectedIndexChanged += new System.EventHandler(this.sailboatIDtxt_SelectedIndexChanged);
            // 
            // sailstarttime
            // 
            this.sailstarttime.CustomFormat = "HH:mm:ss tt";
            this.sailstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sailstarttime.Location = new System.Drawing.Point(63, 184);
            this.sailstarttime.Name = "sailstarttime";
            this.sailstarttime.ShowUpDown = true;
            this.sailstarttime.Size = new System.Drawing.Size(326, 23);
            this.sailstarttime.TabIndex = 13;
            this.sailstarttime.ValueChanged += new System.EventHandler(this.sailstarttime_ValueChanged);
            // 
            // sailtimepicker
            // 
            this.sailtimepicker.CustomFormat = "yyyy-mm-dd";
            this.sailtimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sailtimepicker.Location = new System.Drawing.Point(63, 117);
            this.sailtimepicker.Name = "sailtimepicker";
            this.sailtimepicker.Size = new System.Drawing.Size(326, 23);
            this.sailtimepicker.TabIndex = 3;
            // 
            // submitbtnsail
            // 
            this.submitbtnsail.BackColor = System.Drawing.Color.LightSlateGray;
            this.submitbtnsail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitbtnsail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitbtnsail.Location = new System.Drawing.Point(192, 374);
            this.submitbtnsail.Name = "submitbtnsail";
            this.submitbtnsail.Size = new System.Drawing.Size(80, 33);
            this.submitbtnsail.TabIndex = 12;
            this.submitbtnsail.Text = "Submit";
            this.submitbtnsail.UseVisualStyleBackColor = false;
            // 
            // sailboatIDtitle
            // 
            this.sailboatIDtitle.AutoSize = true;
            this.sailboatIDtitle.Location = new System.Drawing.Point(63, 296);
            this.sailboatIDtitle.Name = "sailboatIDtitle";
            this.sailboatIDtitle.Size = new System.Drawing.Size(48, 15);
            this.sailboatIDtitle.TabIndex = 8;
            this.sailboatIDtitle.Text = "Boat ID:";
            this.sailboatIDtitle.Click += new System.EventHandler(this.sailboatIDtitle_Click);
            // 
            // saillocationtitle
            // 
            this.saillocationtitle.AutoSize = true;
            this.saillocationtitle.Location = new System.Drawing.Point(63, 229);
            this.saillocationtitle.Name = "saillocationtitle";
            this.saillocationtitle.Size = new System.Drawing.Size(56, 15);
            this.saillocationtitle.TabIndex = 5;
            this.saillocationtitle.Text = "Location:";
            // 
            // sailtimetitle
            // 
            this.sailtimetitle.AutoSize = true;
            this.sailtimetitle.Location = new System.Drawing.Point(63, 166);
            this.sailtimetitle.Name = "sailtimetitle";
            this.sailtimetitle.Size = new System.Drawing.Size(63, 15);
            this.sailtimetitle.TabIndex = 4;
            this.sailtimetitle.Text = "Start Time:";
            // 
            // saildatetxt
            // 
            this.saildatetxt.AutoSize = true;
            this.saildatetxt.Location = new System.Drawing.Point(63, 99);
            this.saildatetxt.Name = "saildatetxt";
            this.saildatetxt.Size = new System.Drawing.Size(34, 15);
            this.saildatetxt.TabIndex = 3;
            this.saildatetxt.Text = "Date:";
            // 
            // sailclientIDtitle
            // 
            this.sailclientIDtitle.AutoSize = true;
            this.sailclientIDtitle.Location = new System.Drawing.Point(63, 33);
            this.sailclientIDtitle.Name = "sailclientIDtitle";
            this.sailclientIDtitle.Size = new System.Drawing.Size(55, 15);
            this.sailclientIDtitle.TabIndex = 1;
            this.sailclientIDtitle.Text = "Client ID:";
            // 
            // FormAddSailingBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddSailingBooking";
            this.Text = "Add Sailing Booking";
            this.Load += new System.EventHandler(this.FormAddSailingBooking_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label addsailtitle;
        private Panel panel1;
        private DateTimePicker sailtimepicker;
        private Button submitbtnsail;
        private Label sailboatIDtitle;
        private Label saillocationtitle;
        private Label sailtimetitle;
        private Label saildatetxt;
        private Label sailclientIDtitle;
        private DateTimePicker sailstarttime;
        private ComboBox sailclientIDtxt;
        private ComboBox saillocationtxt;
        private ComboBox sailboatIDtxt;
    }
}