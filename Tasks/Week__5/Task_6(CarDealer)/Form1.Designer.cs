
namespace Task_6_CarDealer_
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
            this.cb_brand = new System.Windows.Forms.ComboBox();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.cb_fuelType = new System.Windows.Forms.ComboBox();
            this.cb_kuza = new System.Windows.Forms.ComboBox();
            this.cb_motorType = new System.Windows.Forms.ComboBox();
            this.cb_gearType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add_order = new System.Windows.Forms.Button();
            this.lv_orders = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // cb_brand
            // 
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Items.AddRange(new object[] {
            "BMW",
            "Mercedes",
            "Lada"});
            this.cb_brand.Location = new System.Drawing.Point(16, 42);
            this.cb_brand.Name = "cb_brand";
            this.cb_brand.Size = new System.Drawing.Size(121, 23);
            this.cb_brand.TabIndex = 0;
            this.cb_brand.SelectedIndexChanged += new System.EventHandler(this.cb_brand_SelectedIndexChanged);
            // 
            // cb_model
            // 
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(143, 42);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(121, 23);
            this.cb_model.TabIndex = 1;
            // 
            // cb_fuelType
            // 
            this.cb_fuelType.FormattingEnabled = true;
            this.cb_fuelType.Items.AddRange(new object[] {
            "Benzin",
            "Dizel"});
            this.cb_fuelType.Location = new System.Drawing.Point(16, 90);
            this.cb_fuelType.Name = "cb_fuelType";
            this.cb_fuelType.Size = new System.Drawing.Size(121, 23);
            this.cb_fuelType.TabIndex = 2;
            // 
            // cb_kuza
            // 
            this.cb_kuza.FormattingEnabled = true;
            this.cb_kuza.Items.AddRange(new object[] {
            "Kuza1\t",
            "Kuza2"});
            this.cb_kuza.Location = new System.Drawing.Point(143, 90);
            this.cb_kuza.Name = "cb_kuza";
            this.cb_kuza.Size = new System.Drawing.Size(121, 23);
            this.cb_kuza.TabIndex = 3;
            // 
            // cb_motorType
            // 
            this.cb_motorType.FormattingEnabled = true;
            this.cb_motorType.Items.AddRange(new object[] {
            "5",
            "3",
            "2"});
            this.cb_motorType.Location = new System.Drawing.Point(143, 131);
            this.cb_motorType.Name = "cb_motorType";
            this.cb_motorType.Size = new System.Drawing.Size(121, 23);
            this.cb_motorType.TabIndex = 5;
            // 
            // cb_gearType
            // 
            this.cb_gearType.FormattingEnabled = true;
            this.cb_gearType.Items.AddRange(new object[] {
            "Avtomat\t",
            "Mexanika"});
            this.cb_gearType.Location = new System.Drawing.Point(16, 131);
            this.cb_gearType.Name = "cb_gearType";
            this.cb_gearType.Size = new System.Drawing.Size(121, 23);
            this.cb_gearType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yanacaq tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kuza tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Motor tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Skorost tipi";
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // colorDialog2
            // 
            this.colorDialog2.FullOpen = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM";
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "İl";
            // 
            // btn_add_order
            // 
            this.btn_add_order.Location = new System.Drawing.Point(424, 140);
            this.btn_add_order.Name = "btn_add_order";
            this.btn_add_order.Size = new System.Drawing.Size(75, 23);
            this.btn_add_order.TabIndex = 14;
            this.btn_add_order.Text = "Əlavə et";
            this.btn_add_order.UseVisualStyleBackColor = true;
            this.btn_add_order.Click += new System.EventHandler(this.btn_add_order_Click);
            // 
            // lv_orders
            // 
            this.lv_orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lv_orders.HideSelection = false;
            this.lv_orders.Location = new System.Drawing.Point(28, 187);
            this.lv_orders.Name = "lv_orders";
            this.lv_orders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lv_orders.Size = new System.Drawing.Size(694, 124);
            this.lv_orders.TabIndex = 15;
            this.lv_orders.UseCompatibleStateImageBehavior = false;
            this.lv_orders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yanacaq tipi";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Benzin tipi";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kuza tipi";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Skorost tipi";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Motor tipi";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Rəng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "İl";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Rəng";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv_orders);
            this.Controls.Add(this.btn_add_order);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_motorType);
            this.Controls.Add(this.cb_gearType);
            this.Controls.Add(this.cb_kuza);
            this.Controls.Add(this.cb_fuelType);
            this.Controls.Add(this.cb_model);
            this.Controls.Add(this.cb_brand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_brand;
        private System.Windows.Forms.ComboBox cb_model;
        private System.Windows.Forms.ComboBox cb_fuelType;
        private System.Windows.Forms.ComboBox cb_kuza;
        private System.Windows.Forms.ComboBox cb_motorType;
        private System.Windows.Forms.ComboBox cb_gearType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add_order;
        private System.Windows.Forms.ListView lv_orders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

