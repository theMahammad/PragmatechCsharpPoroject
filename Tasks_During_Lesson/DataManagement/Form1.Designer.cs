
namespace DataManagement
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
            this.names_lb = new System.Windows.Forms.ListBox();
            this.tb_add_name = new System.Windows.Forms.TextBox();
            this.tb_search_names = new System.Windows.Forms.TextBox();
            this.btn_add_name = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // names_lb
            // 
            this.names_lb.FormattingEnabled = true;
            this.names_lb.ItemHeight = 15;
            this.names_lb.Location = new System.Drawing.Point(44, 141);
            this.names_lb.Name = "names_lb";
            this.names_lb.Size = new System.Drawing.Size(149, 154);
            this.names_lb.TabIndex = 0;
            // 
            // tb_add_name
            // 
            this.tb_add_name.Location = new System.Drawing.Point(44, 60);
            this.tb_add_name.Name = "tb_add_name";
            this.tb_add_name.Size = new System.Drawing.Size(174, 23);
            this.tb_add_name.TabIndex = 1;
            this.tb_add_name.TextChanged += new System.EventHandler(this.tb_add_name_TextChanged);
            // 
            // tb_search_names
            // 
            this.tb_search_names.Location = new System.Drawing.Point(44, 112);
            this.tb_search_names.Name = "tb_search_names";
            this.tb_search_names.Size = new System.Drawing.Size(172, 23);
            this.tb_search_names.TabIndex = 2;
            // 
            // btn_add_name
            // 
            this.btn_add_name.Location = new System.Drawing.Point(222, 60);
            this.btn_add_name.Name = "btn_add_name";
            this.btn_add_name.Size = new System.Drawing.Size(75, 23);
            this.btn_add_name.TabIndex = 3;
            this.btn_add_name.Text = "Əlavə et";
            this.btn_add_name.UseVisualStyleBackColor = true;
            this.btn_add_name.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(222, 111);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Axtar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Toplamı göstər";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add_name);
            this.Controls.Add(this.tb_search_names);
            this.Controls.Add(this.tb_add_name);
            this.Controls.Add(this.names_lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox names_lb;
        private System.Windows.Forms.TextBox tb_add_name;
        private System.Windows.Forms.TextBox tb_search_names;
        private System.Windows.Forms.Button btn_add_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button button3;
    }
}

