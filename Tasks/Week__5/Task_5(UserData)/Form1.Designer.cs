
namespace Task_5_UserData_
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
            this.lv_users = new System.Windows.Forms.ListView();
            this.Ad = new System.Windows.Forms.ColumnHeader();
            this.Soyad = new System.Windows.Forms.ColumnHeader();
            this.Telefon = new System.Windows.Forms.ColumnHeader();
            this.Doğum = new System.Windows.Forms.ColumnHeader();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.mtb_phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_phone_number = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.btn_add_user_data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_users
            // 
            this.lv_users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ad,
            this.Soyad,
            this.Telefon,
            this.Doğum});
            this.lv_users.HideSelection = false;
            this.lv_users.Location = new System.Drawing.Point(180, 136);
            this.lv_users.Name = "lv_users";
            this.lv_users.Size = new System.Drawing.Size(389, 139);
            this.lv_users.TabIndex = 0;
            this.lv_users.UseCompatibleStateImageBehavior = false;
            this.lv_users.View = System.Windows.Forms.View.Details;
            this.lv_users.SelectedIndexChanged += new System.EventHandler(this.lv_users_SelectedIndexChanged);
            // 
            // Ad
            // 
            this.Ad.Tag = "name";
            this.Ad.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.Tag = "surname";
            this.Soyad.Text = "Soyad";
            // 
            // Telefon
            // 
            this.Telefon.Tag = "phoneNumber";
            this.Telefon.Text = "Telefon";
            // 
            // Doğum
            // 
            this.Doğum.Tag = "birthday";
            this.Doğum.Text = "Doğum";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(79, 49);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 23);
            this.tb_name.TabIndex = 1;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(260, 49);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 23);
            this.tb_surname.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(79, 31);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(22, 15);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Ad";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(260, 31);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(39, 15);
            this.lbl_surname.TabIndex = 4;
            this.lbl_surname.Text = "Soyad";
            // 
            // mtb_phoneNumber
            // 
            this.mtb_phoneNumber.Location = new System.Drawing.Point(391, 52);
            this.mtb_phoneNumber.Mask = "(+999)00-000-00-00";
            this.mtb_phoneNumber.Name = "mtb_phoneNumber";
            this.mtb_phoneNumber.Size = new System.Drawing.Size(100, 23);
            this.mtb_phoneNumber.TabIndex = 5;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_birthday.Location = new System.Drawing.Point(529, 52);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(200, 23);
            this.dtp_birthday.TabIndex = 6;
            // 
            // lbl_phone_number
            // 
            this.lbl_phone_number.AutoSize = true;
            this.lbl_phone_number.Location = new System.Drawing.Point(391, 31);
            this.lbl_phone_number.Name = "lbl_phone_number";
            this.lbl_phone_number.Size = new System.Drawing.Size(91, 15);
            this.lbl_phone_number.TabIndex = 7;
            this.lbl_phone_number.Text = "Telefon nömrəsi";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Location = new System.Drawing.Point(529, 31);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(76, 15);
            this.lbl_birthday.TabIndex = 8;
            this.lbl_birthday.Text = "Doğum tarixi";
            // 
            // btn_add_user_data
            // 
            this.btn_add_user_data.Location = new System.Drawing.Point(313, 107);
            this.btn_add_user_data.Name = "btn_add_user_data";
            this.btn_add_user_data.Size = new System.Drawing.Size(75, 23);
            this.btn_add_user_data.TabIndex = 9;
            this.btn_add_user_data.Text = "Əlavə et";
            this.btn_add_user_data.UseVisualStyleBackColor = true;
            this.btn_add_user_data.Click += new System.EventHandler(this.btn_add_user_data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add_user_data);
            this.Controls.Add(this.lbl_birthday);
            this.Controls.Add(this.lbl_phone_number);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.mtb_phoneNumber);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lv_users);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_users;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.MaskedTextBox mtb_phoneNumber;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Label lbl_phone_number;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.Button btn_add_user_data;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Doğum;
    }
}

