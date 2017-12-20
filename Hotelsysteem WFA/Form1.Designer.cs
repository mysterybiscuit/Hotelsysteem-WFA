namespace Hotelsysteem_WFA
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
            this.btn_nr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_reservations = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_enddate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_begindate = new System.Windows.Forms.TextBox();
            this.lb_names = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_roomnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_addname = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_nr
            // 
            this.btn_nr.Location = new System.Drawing.Point(12, 11);
            this.btn_nr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nr.Name = "btn_nr";
            this.btn_nr.Size = new System.Drawing.Size(92, 26);
            this.btn_nr.TabIndex = 1;
            this.btn_nr.Text = "New reservation";
            this.btn_nr.UseVisualStyleBackColor = true;
            this.btn_nr.Click += new System.EventHandler(this.btn_nr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservations:";
            // 
            // lb_reservations
            // 
            this.lb_reservations.FormattingEnabled = true;
            this.lb_reservations.Location = new System.Drawing.Point(6, 33);
            this.lb_reservations.Name = "lb_reservations";
            this.lb_reservations.Size = new System.Drawing.Size(120, 290);
            this.lb_reservations.TabIndex = 3;
            this.lb_reservations.SelectedIndexChanged += new System.EventHandler(this.lb_reservations_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_remove);
            this.groupBox1.Controls.Add(this.btn_addname);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lb_reservations);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 332);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_enddate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_begindate);
            this.groupBox2.Controls.Add(this.lb_names);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_roomnumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(136, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 218);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Date:";
            // 
            // tb_enddate
            // 
            this.tb_enddate.Location = new System.Drawing.Point(7, 186);
            this.tb_enddate.Name = "tb_enddate";
            this.tb_enddate.Size = new System.Drawing.Size(198, 20);
            this.tb_enddate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Begin Date:";
            // 
            // tb_begindate
            // 
            this.tb_begindate.Location = new System.Drawing.Point(7, 147);
            this.tb_begindate.Name = "tb_begindate";
            this.tb_begindate.Size = new System.Drawing.Size(198, 20);
            this.tb_begindate.TabIndex = 8;
            // 
            // lb_names
            // 
            this.lb_names.FormattingEnabled = true;
            this.lb_names.Location = new System.Drawing.Point(7, 72);
            this.lb_names.Name = "lb_names";
            this.lb_names.Size = new System.Drawing.Size(200, 56);
            this.lb_names.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room:";
            // 
            // tb_roomnumber
            // 
            this.tb_roomnumber.Location = new System.Drawing.Point(9, 32);
            this.tb_roomnumber.Name = "tb_roomnumber";
            this.tb_roomnumber.Size = new System.Drawing.Size(198, 20);
            this.tb_roomnumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Names:";
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(110, 11);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(92, 26);
            this.btn_reload.TabIndex = 5;
            this.btn_reload.Text = "Reload";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_addname
            // 
            this.btn_addname.Location = new System.Drawing.Point(136, 244);
            this.btn_addname.Name = "btn_addname";
            this.btn_addname.Size = new System.Drawing.Size(115, 26);
            this.btn_addname.TabIndex = 6;
            this.btn_addname.Text = "Add name";
            this.btn_addname.UseVisualStyleBackColor = true;
            this.btn_addname.Click += new System.EventHandler(this.btn_addname_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(136, 297);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(115, 26);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "Remove reservation";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add to Food";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(401, 390);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_nr);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hotelsysteem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_nr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_reservations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_names;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_roomnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_enddate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_begindate;
        private System.Windows.Forms.Button btn_addname;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button button1;
    }
}

