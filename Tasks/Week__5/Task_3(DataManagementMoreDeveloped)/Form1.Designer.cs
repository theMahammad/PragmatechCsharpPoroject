
namespace Task_3_DataManagementMoreDeveloped_
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
            this.lb_data = new System.Windows.Forms.ListBox();
            this.btn_add_data = new System.Windows.Forms.Button();
            this.btn_delete_data = new System.Windows.Forms.Button();
            this.btn_randomize_datas = new System.Windows.Forms.Button();
            this.tb_add_data = new System.Windows.Forms.TextBox();
            this.tb_delete_data = new System.Windows.Forms.TextBox();
            this.btn_delete_selected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_data
            // 
            this.lb_data.FormattingEnabled = true;
            this.lb_data.ItemHeight = 15;
            this.lb_data.Location = new System.Drawing.Point(281, 132);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(300, 184);
            this.lb_data.TabIndex = 0;
            this.lb_data.SelectedIndexChanged += new System.EventHandler(this.lb_data_SelectedIndexChanged);
            this.lb_data.Leave += new System.EventHandler(this.lb_data_Leave);
            // 
            // btn_add_data
            // 
            this.btn_add_data.Location = new System.Drawing.Point(506, 45);
            this.btn_add_data.Name = "btn_add_data";
            this.btn_add_data.Size = new System.Drawing.Size(75, 23);
            this.btn_add_data.TabIndex = 1;
            this.btn_add_data.Text = "Əlavə et";
            this.btn_add_data.UseVisualStyleBackColor = true;
            this.btn_add_data.Click += new System.EventHandler(this.btn_add_data_Click);
            // 
            // btn_delete_data
            // 
            this.btn_delete_data.Location = new System.Drawing.Point(506, 74);
            this.btn_delete_data.Name = "btn_delete_data";
            this.btn_delete_data.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_data.TabIndex = 2;
            this.btn_delete_data.Text = "Sil";
            this.btn_delete_data.UseVisualStyleBackColor = true;
            this.btn_delete_data.Click += new System.EventHandler(this.btn_delete_data_Click);
            // 
            // btn_randomize_datas
            // 
            this.btn_randomize_datas.Location = new System.Drawing.Point(391, 104);
            this.btn_randomize_datas.Name = "btn_randomize_datas";
            this.btn_randomize_datas.Size = new System.Drawing.Size(75, 23);
            this.btn_randomize_datas.TabIndex = 3;
            this.btn_randomize_datas.Text = "Qarışdır";
            this.btn_randomize_datas.UseVisualStyleBackColor = true;
            this.btn_randomize_datas.Click += new System.EventHandler(this.btn_randomize_datas_Click);
            // 
            // tb_add_data
            // 
            this.tb_add_data.Location = new System.Drawing.Point(281, 45);
            this.tb_add_data.Name = "tb_add_data";
            this.tb_add_data.PlaceholderText = "Data əlavə edin";
            this.tb_add_data.Size = new System.Drawing.Size(219, 23);
            this.tb_add_data.TabIndex = 4;
            // 
            // tb_delete_data
            // 
            this.tb_delete_data.Location = new System.Drawing.Point(281, 75);
            this.tb_delete_data.Name = "tb_delete_data";
            this.tb_delete_data.PlaceholderText = "Silinəcək datanı daxil edin";
            this.tb_delete_data.Size = new System.Drawing.Size(219, 23);
            this.tb_delete_data.TabIndex = 5;
            // 
            // btn_delete_selected
            // 
            this.btn_delete_selected.Location = new System.Drawing.Point(587, 132);
            this.btn_delete_selected.Name = "btn_delete_selected";
            this.btn_delete_selected.Size = new System.Drawing.Size(139, 23);
            this.btn_delete_selected.TabIndex = 6;
            this.btn_delete_selected.Text = "Seçilmiş datanı sil";
            this.btn_delete_selected.UseVisualStyleBackColor = true;
            this.btn_delete_selected.Click += new System.EventHandler(this.btn_delete_selected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete_selected);
            this.Controls.Add(this.tb_delete_data);
            this.Controls.Add(this.tb_add_data);
            this.Controls.Add(this.btn_randomize_datas);
            this.Controls.Add(this.btn_delete_data);
            this.Controls.Add(this.btn_add_data);
            this.Controls.Add(this.lb_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_data;
        private System.Windows.Forms.Button btn_add_data;
        private System.Windows.Forms.Button btn_delete_data;
        private System.Windows.Forms.Button btn_randomize_datas;
        private System.Windows.Forms.TextBox tb_add_data;
        private System.Windows.Forms.TextBox tb_delete_data;
        private System.Windows.Forms.Button btn_delete_selected;
    }
}

