
namespace Task_1_Calculator_
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
            this.nup_firstNumber = new System.Windows.Forms.NumericUpDown();
            this.nup_secondNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_first_number = new System.Windows.Forms.Label();
            this.lbl_second_number = new System.Windows.Forms.Label();
            this.cb_operation = new System.Windows.Forms.ComboBox();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.lbl_preResult = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_firstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_secondNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nup_firstNumber
            // 
            this.nup_firstNumber.Location = new System.Drawing.Point(247, 51);
            this.nup_firstNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nup_firstNumber.Name = "nup_firstNumber";
            this.nup_firstNumber.Size = new System.Drawing.Size(120, 20);
            this.nup_firstNumber.TabIndex = 0;
            this.nup_firstNumber.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.nup_firstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nup_firstNumber_KeyPress);
            this.nup_firstNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nup_firstNumber_KeyUp);
            // 
            // nup_secondNumber
            // 
            this.nup_secondNumber.Location = new System.Drawing.Point(440, 51);
            this.nup_secondNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nup_secondNumber.Name = "nup_secondNumber";
            this.nup_secondNumber.Size = new System.Drawing.Size(120, 20);
            this.nup_secondNumber.TabIndex = 1;
            this.nup_secondNumber.ValueChanged += new System.EventHandler(this.nup_secondNumber_ValueChanged);
            this.nup_secondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nup_secondNumber_KeyPress);
            // 
            // lbl_first_number
            // 
            this.lbl_first_number.AutoSize = true;
            this.lbl_first_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_first_number.Location = new System.Drawing.Point(242, 8);
            this.lbl_first_number.Name = "lbl_first_number";
            this.lbl_first_number.Size = new System.Drawing.Size(99, 25);
            this.lbl_first_number.TabIndex = 2;
            this.lbl_first_number.Text = "İlk rəqəm";
            // 
            // lbl_second_number
            // 
            this.lbl_second_number.AutoSize = true;
            this.lbl_second_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_second_number.Location = new System.Drawing.Point(435, 9);
            this.lbl_second_number.Name = "lbl_second_number";
            this.lbl_second_number.Size = new System.Drawing.Size(127, 25);
            this.lbl_second_number.TabIndex = 3;
            this.lbl_second_number.Text = "İkinci rəqəm";
            // 
            // cb_operation
            // 
            this.cb_operation.FormattingEnabled = true;
            this.cb_operation.Items.AddRange(new object[] {
            "-",
            "%",
            "*",
            "/",
            "+"});
            this.cb_operation.Location = new System.Drawing.Point(595, 50);
            this.cb_operation.Name = "cb_operation";
            this.cb_operation.Size = new System.Drawing.Size(121, 21);
            this.cb_operation.Sorted = true;
            this.cb_operation.TabIndex = 4;
            this.cb_operation.Text = "+";
            this.cb_operation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_operation
            // 
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_operation.Location = new System.Drawing.Point(590, 8);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(107, 25);
            this.lbl_operation.TabIndex = 5;
            this.lbl_operation.Text = "Əməliyyat";
            // 
            // lbl_preResult
            // 
            this.lbl_preResult.AutoSize = true;
            this.lbl_preResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_preResult.Location = new System.Drawing.Point(314, 83);
            this.lbl_preResult.Name = "lbl_preResult";
            this.lbl_preResult.Size = new System.Drawing.Size(91, 25);
            this.lbl_preResult.TabIndex = 6;
            this.lbl_preResult.Text = "Nəticə : ";
            this.lbl_preResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_result.Location = new System.Drawing.Point(411, 83);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(24, 25);
            this.lbl_result.TabIndex = 7;
            this.lbl_result.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_preResult);
            this.Controls.Add(this.lbl_operation);
            this.Controls.Add(this.cb_operation);
            this.Controls.Add(this.lbl_second_number);
            this.Controls.Add(this.lbl_first_number);
            this.Controls.Add(this.nup_secondNumber);
            this.Controls.Add(this.nup_firstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nup_firstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_secondNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nup_firstNumber;
        private System.Windows.Forms.NumericUpDown nup_secondNumber;
        private System.Windows.Forms.Label lbl_first_number;
        private System.Windows.Forms.Label lbl_second_number;
        private System.Windows.Forms.ComboBox cb_operation;
        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.Label lbl_preResult;
        private System.Windows.Forms.Label lbl_result;
    }
}

