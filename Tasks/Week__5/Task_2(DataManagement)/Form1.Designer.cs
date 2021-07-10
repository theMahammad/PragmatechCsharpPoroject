
namespace Task_2_DataManagement_
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
            this.tb_add_data = new System.Windows.Forms.TextBox();
            this.btn_add_data = new System.Windows.Forms.Button();
            this.lb_data = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_add_data
            // 
            this.tb_add_data.Location = new System.Drawing.Point(310, 102);
            this.tb_add_data.Name = "tb_add_data";
            this.tb_add_data.PlaceholderText = "Data daxil edin";
            this.tb_add_data.Size = new System.Drawing.Size(164, 23);
            this.tb_add_data.TabIndex = 0;
            // 
            // btn_add_data
            // 
            this.btn_add_data.Location = new System.Drawing.Point(506, 102);
            this.btn_add_data.Name = "btn_add_data";
            this.btn_add_data.Size = new System.Drawing.Size(75, 23);
            this.btn_add_data.TabIndex = 1;
            this.btn_add_data.Text = "Əlavə et";
            this.btn_add_data.UseVisualStyleBackColor = true;
            this.btn_add_data.Click += new System.EventHandler(this.btn_add_data_Click);
            // 
            // lb_data
            // 
            this.lb_data.FormattingEnabled = true;
            this.lb_data.ItemHeight = 15;
            this.lb_data.Location = new System.Drawing.Point(310, 148);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(271, 94);
            this.lb_data.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.btn_add_data);
            this.Controls.Add(this.tb_add_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_add_data;
        private System.Windows.Forms.Button btn_add_data;
        private System.Windows.Forms.ListBox lb_data;
    }
}

