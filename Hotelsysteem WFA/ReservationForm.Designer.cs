namespace Hotelsysteem_WFA
{
    partial class ReservationForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_residence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.mcal_selector = new System.Windows.Forms.MonthCalendar();
            this.btn_beginDate = new System.Windows.Forms.Button();
            this.btn_endDate = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_rooms = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(149, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_residence);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tb_address);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_fullname);
            this.groupBox3.Location = new System.Drawing.Point(10, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(135, 154);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Residence:";
            // 
            // tb_residence
            // 
            this.tb_residence.Location = new System.Drawing.Point(4, 124);
            this.tb_residence.Margin = new System.Windows.Forms.Padding(2);
            this.tb_residence.Name = "tb_residence";
            this.tb_residence.Size = new System.Drawing.Size(126, 20);
            this.tb_residence.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(4, 79);
            this.tb_address.Margin = new System.Windows.Forms.Padding(2);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(126, 20);
            this.tb_address.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name:";
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(4, 34);
            this.tb_fullname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(126, 20);
            this.tb_fullname.TabIndex = 0;
            // 
            // mcal_selector
            // 
            this.mcal_selector.Location = new System.Drawing.Point(167, 15);
            this.mcal_selector.Margin = new System.Windows.Forms.Padding(7);
            this.mcal_selector.Name = "mcal_selector";
            this.mcal_selector.ShowWeekNumbers = true;
            this.mcal_selector.TabIndex = 2;
            // 
            // btn_beginDate
            // 
            this.btn_beginDate.Location = new System.Drawing.Point(167, 186);
            this.btn_beginDate.Name = "btn_beginDate";
            this.btn_beginDate.Size = new System.Drawing.Size(168, 40);
            this.btn_beginDate.TabIndex = 3;
            this.btn_beginDate.Text = "Set begin date";
            this.btn_beginDate.UseVisualStyleBackColor = true;
            this.btn_beginDate.Click += new System.EventHandler(this.btn_beginDate_Click);
            // 
            // btn_endDate
            // 
            this.btn_endDate.Location = new System.Drawing.Point(167, 236);
            this.btn_endDate.Name = "btn_endDate";
            this.btn_endDate.Size = new System.Drawing.Size(168, 40);
            this.btn_endDate.TabIndex = 4;
            this.btn_endDate.Text = "Set end date";
            this.btn_endDate.UseVisualStyleBackColor = true;
            this.btn_endDate.Click += new System.EventHandler(this.btn_endDate_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(341, 187);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 89);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_rooms
            // 
            this.lb_rooms.FormattingEnabled = true;
            this.lb_rooms.Location = new System.Drawing.Point(426, 48);
            this.lb_rooms.Name = "lb_rooms";
            this.lb_rooms.Size = new System.Drawing.Size(120, 225);
            this.lb_rooms.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Available rooms:";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(557, 288);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_rooms);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_endDate);
            this.Controls.Add(this.btn_beginDate);
            this.Controls.Add(this.mcal_selector);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReservationForm";
            this.Text = "Reservering";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_residence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.MonthCalendar mcal_selector;
        private System.Windows.Forms.Button btn_beginDate;
        private System.Windows.Forms.Button btn_endDate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ListBox lb_rooms;
        private System.Windows.Forms.Label label4;
    }
}