namespace _471Frontend
{
    partial class FormAddAmmenitiesBooking
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
            this.addammenitiestitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saillocationtxt = new System.Windows.Forms.ComboBox();
            this.sailclientIDtxt = new System.Windows.Forms.ComboBox();
            this.bookingIDtxt = new System.Windows.Forms.ComboBox();
            this.submitbtnammenities = new System.Windows.Forms.Button();
            this.ammenitiesIDtitle = new System.Windows.Forms.Label();
            this.saillocationtitle = new System.Windows.Forms.Label();
            this.ammenitiesclientIDtitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.addammenitiestitle);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 81);
            this.panel2.TabIndex = 2;
            // 
            // addammenitiestitle
            // 
            this.addammenitiestitle.AutoSize = true;
            this.addammenitiestitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addammenitiestitle.Location = new System.Drawing.Point(98, 26);
            this.addammenitiestitle.Name = "addammenitiestitle";
            this.addammenitiestitle.Size = new System.Drawing.Size(328, 37);
            this.addammenitiestitle.TabIndex = 0;
            this.addammenitiestitle.Text = "Add Ammenities Booking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.saillocationtxt);
            this.panel1.Controls.Add(this.sailclientIDtxt);
            this.panel1.Controls.Add(this.bookingIDtxt);
            this.panel1.Controls.Add(this.submitbtnammenities);
            this.panel1.Controls.Add(this.ammenitiesIDtitle);
            this.panel1.Controls.Add(this.saillocationtitle);
            this.panel1.Controls.Add(this.ammenitiesclientIDtitle);
            this.panel1.Location = new System.Drawing.Point(22, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 390);
            this.panel1.TabIndex = 3;
            // 
            // saillocationtxt
            // 
            this.saillocationtxt.FormattingEnabled = true;
            this.saillocationtxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.saillocationtxt.Location = new System.Drawing.Point(63, 119);
            this.saillocationtxt.Name = "saillocationtxt";
            this.saillocationtxt.Size = new System.Drawing.Size(326, 23);
            this.saillocationtxt.TabIndex = 23;
            // 
            // sailclientIDtxt
            // 
            this.sailclientIDtxt.FormattingEnabled = true;
            this.sailclientIDtxt.Location = new System.Drawing.Point(63, 51);
            this.sailclientIDtxt.Name = "sailclientIDtxt";
            this.sailclientIDtxt.Size = new System.Drawing.Size(121, 23);
            this.sailclientIDtxt.TabIndex = 17;
            // 
            // bookingIDtxt
            // 
            this.bookingIDtxt.FormattingEnabled = true;
            this.bookingIDtxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.bookingIDtxt.Location = new System.Drawing.Point(63, 191);
            this.bookingIDtxt.Name = "bookingIDtxt";
            this.bookingIDtxt.Size = new System.Drawing.Size(133, 23);
            this.bookingIDtxt.TabIndex = 22;
            // 
            // submitbtnammenities
            // 
            this.submitbtnammenities.BackColor = System.Drawing.Color.LightSlateGray;
            this.submitbtnammenities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitbtnammenities.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitbtnammenities.Location = new System.Drawing.Point(147, 279);
            this.submitbtnammenities.Name = "submitbtnammenities";
            this.submitbtnammenities.Size = new System.Drawing.Size(146, 45);
            this.submitbtnammenities.TabIndex = 12;
            this.submitbtnammenities.Text = "Submit";
            this.submitbtnammenities.UseVisualStyleBackColor = false;
            this.submitbtnammenities.Click += new System.EventHandler(this.submitbtnammenities_Click);
            // 
            // ammenitiesIDtitle
            // 
            this.ammenitiesIDtitle.AutoSize = true;
            this.ammenitiesIDtitle.Location = new System.Drawing.Point(63, 173);
            this.ammenitiesIDtitle.Name = "ammenitiesIDtitle";
            this.ammenitiesIDtitle.Size = new System.Drawing.Size(68, 15);
            this.ammenitiesIDtitle.TabIndex = 8;
            this.ammenitiesIDtitle.Text = "Booking ID:";
            this.ammenitiesIDtitle.Click += new System.EventHandler(this.ammenitiesIDtitle_Click);
            // 
            // saillocationtitle
            // 
            this.saillocationtitle.AutoSize = true;
            this.saillocationtitle.Location = new System.Drawing.Point(63, 101);
            this.saillocationtitle.Name = "saillocationtitle";
            this.saillocationtitle.Size = new System.Drawing.Size(56, 15);
            this.saillocationtitle.TabIndex = 19;
            this.saillocationtitle.Text = "Location:";
            // 
            // ammenitiesclientIDtitle
            // 
            this.ammenitiesclientIDtitle.AutoSize = true;
            this.ammenitiesclientIDtitle.Location = new System.Drawing.Point(63, 33);
            this.ammenitiesclientIDtitle.Name = "ammenitiesclientIDtitle";
            this.ammenitiesclientIDtitle.Size = new System.Drawing.Size(55, 15);
            this.ammenitiesclientIDtitle.TabIndex = 1;
            this.ammenitiesclientIDtitle.Text = "Client ID:";
            // 
            // FormAddAmmenitiesBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormAddAmmenitiesBooking";
            this.Text = "Add Ammenities Booking";
            this.Load += new System.EventHandler(this.FormAddAmmenitiesBooking_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label addammenitiestitle;
        private Panel panel1;
        private Button submitbtnammenities;
        private Label ammenitiesIDtitle;
        private Label ammenitiesclientIDtitle;
        private ComboBox sailclientIDtxt;
        private ComboBox saillocationtxt;
        private ComboBox bookingIDtxt;
        private Label saillocationtitle;
    }
}