
namespace Task_1_ShoppingManagement_
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
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.cb_products = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_products = new System.Windows.Forms.Label();
            this.cb_delivery_type = new System.Windows.Forms.ComboBox();
            this.lbl_delivery_type = new System.Windows.Forms.Label();
            this.nup_weight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nup_price = new System.Windows.Forms.NumericUpDown();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_give_order = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lv_orders = new System.Windows.Forms.ListView();
            this.category = new System.Windows.Forms.ColumnHeader();
            this.product_name = new System.Windows.Forms.ColumnHeader();
            this.delivery_type = new System.Windows.Forms.ColumnHeader();
            this.order_date = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.weight = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.nup_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_price)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "Nauşniklər",
            "Noutbuklar",
            "Ağıllı Saatlar"});
            this.cb_category.Location = new System.Drawing.Point(47, 34);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(121, 23);
            this.cb_category.TabIndex = 0;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // cb_products
            // 
            this.cb_products.FormattingEnabled = true;
            this.cb_products.Location = new System.Drawing.Point(187, 34);
            this.cb_products.Name = "cb_products";
            this.cb_products.Size = new System.Drawing.Size(121, 23);
            this.cb_products.TabIndex = 1;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(47, 16);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(63, 15);
            this.lbl_category.TabIndex = 2;
            this.lbl_category.Text = "Kateqoriya";
            // 
            // lbl_products
            // 
            this.lbl_products.AutoSize = true;
            this.lbl_products.Location = new System.Drawing.Point(187, 16);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(46, 15);
            this.lbl_products.TabIndex = 3;
            this.lbl_products.Text = "Məhsul";
            // 
            // cb_delivery_type
            // 
            this.cb_delivery_type.FormattingEnabled = true;
            this.cb_delivery_type.Items.AddRange(new object[] {
            "Standart\t",
            "Premium"});
            this.cb_delivery_type.Location = new System.Drawing.Point(331, 34);
            this.cb_delivery_type.Name = "cb_delivery_type";
            this.cb_delivery_type.Size = new System.Drawing.Size(121, 23);
            this.cb_delivery_type.TabIndex = 4;
            // 
            // lbl_delivery_type
            // 
            this.lbl_delivery_type.AutoSize = true;
            this.lbl_delivery_type.Location = new System.Drawing.Point(331, 16);
            this.lbl_delivery_type.Name = "lbl_delivery_type";
            this.lbl_delivery_type.Size = new System.Drawing.Size(94, 15);
            this.lbl_delivery_type.TabIndex = 5;
            this.lbl_delivery_type.Text = "Çatdırılma üsulu";
            // 
            // nup_weight
            // 
            this.nup_weight.DecimalPlaces = 2;
            this.nup_weight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nup_weight.Location = new System.Drawing.Point(481, 35);
            this.nup_weight.Name = "nup_weight";
            this.nup_weight.Size = new System.Drawing.Size(120, 23);
            this.nup_weight.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Çəki";
            // 
            // nup_price
            // 
            this.nup_price.Location = new System.Drawing.Point(616, 34);
            this.nup_price.Name = "nup_price";
            this.nup_price.Size = new System.Drawing.Size(120, 23);
            this.nup_price.TabIndex = 8;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(616, 17);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(46, 15);
            this.lbl_price.TabIndex = 9;
            this.lbl_price.Text = "Qiymət";
            // 
            // btn_give_order
            // 
            this.btn_give_order.Location = new System.Drawing.Point(350, 111);
            this.btn_give_order.Name = "btn_give_order";
            this.btn_give_order.Size = new System.Drawing.Size(75, 23);
            this.btn_give_order.TabIndex = 10;
            this.btn_give_order.Text = "Sifariş et";
            this.btn_give_order.UseVisualStyleBackColor = true;
            this.btn_give_order.Click += new System.EventHandler(this.btn_give_order_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // lv_orders
            // 
            this.lv_orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.product_name,
            this.delivery_type,
            this.order_date,
            this.price,
            this.weight});
            this.lv_orders.HideSelection = false;
            this.lv_orders.Location = new System.Drawing.Point(109, 185);
            this.lv_orders.Name = "lv_orders";
            this.lv_orders.Size = new System.Drawing.Size(520, 168);
            this.lv_orders.TabIndex = 12;
            this.lv_orders.UseCompatibleStateImageBehavior = false;
            this.lv_orders.View = System.Windows.Forms.View.Details;
            // 
            // category
            // 
            this.category.Text = "Kateqoriya";
            // 
            // product_name
            // 
            this.product_name.Text = "Məhsul adı";
            // 
            // delivery_type
            // 
            this.delivery_type.Text = "Çatdırılma üsulu";
            // 
            // order_date
            // 
            this.order_date.Text = "Sifariş Tarixi";
            // 
            // price
            // 
            this.price.Text = "Qiymət";
            // 
            // weight
            // 
            this.weight.Text = "Çəki";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_orders);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_give_order);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.nup_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nup_weight);
            this.Controls.Add(this.lbl_delivery_type);
            this.Controls.Add(this.cb_delivery_type);
            this.Controls.Add(this.lbl_products);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cb_products);
            this.Controls.Add(this.cb_category);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Online Sifariş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.ComboBox cb_products;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.ComboBox cb_delivery_type;
        private System.Windows.Forms.Label lbl_delivery_type;
        private System.Windows.Forms.NumericUpDown nup_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nup_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_give_order;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView lv_orders;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader product_name;
        private System.Windows.Forms.ColumnHeader delivery_type;
        private System.Windows.Forms.ColumnHeader order_date;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader weight;
    }
}

