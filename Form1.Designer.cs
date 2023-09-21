namespace AplicacionVentaDeRopa
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
            label1 = new Label();
            txtItem = new TextBox();
            txtDayMonday = new TextBox();
            label2 = new Label();
            txtDayTuesday = new TextBox();
            label3 = new Label();
            txtDayWednesday = new TextBox();
            label4 = new Label();
            txtDayThursday = new TextBox();
            label5 = new Label();
            txtDayFriday = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblGrossSalesOutput = new Label();
            lbDisplaySales = new ListBox();
            btnSubmitItem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(117, 53);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(150, 31);
            txtItem.TabIndex = 1;
            txtItem.TextChanged += txtItem_TextChanged;
            txtItem.KeyPress += txtItem_KeyPress;
            // 
            // txtDayMonday
            // 
            txtDayMonday.Location = new Point(117, 115);
            txtDayMonday.Name = "txtDayMonday";
            txtDayMonday.Size = new Size(150, 31);
            txtDayMonday.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Monday";
            // 
            // txtDayTuesday
            // 
            txtDayTuesday.Location = new Point(117, 184);
            txtDayTuesday.Name = "txtDayTuesday";
            txtDayTuesday.Size = new Size(150, 31);
            txtDayTuesday.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Tuesday";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDayWednesday
            // 
            txtDayWednesday.Location = new Point(117, 251);
            txtDayWednesday.Name = "txtDayWednesday";
            txtDayWednesday.Size = new Size(150, 31);
            txtDayWednesday.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 254);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 6;
            label4.Text = "Wednesday";
            // 
            // txtDayThursday
            // 
            txtDayThursday.Location = new Point(117, 325);
            txtDayThursday.Name = "txtDayThursday";
            txtDayThursday.Size = new Size(150, 31);
            txtDayThursday.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 328);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 8;
            label5.Text = "Thursday";
            // 
            // txtDayFriday
            // 
            txtDayFriday.Location = new Point(117, 391);
            txtDayFriday.Name = "txtDayFriday";
            txtDayFriday.Size = new Size(150, 31);
            txtDayFriday.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 394);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 10;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 59);
            label7.Name = "label7";
            label7.Size = new Size(135, 25);
            label7.TabIndex = 12;
            label7.Text = "Estimated Sales";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(756, 397);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 13;
            label8.Text = "Gross sales:";
            // 
            // lblGrossSalesOutput
            // 
            lblGrossSalesOutput.AutoSize = true;
            lblGrossSalesOutput.Location = new Point(879, 397);
            lblGrossSalesOutput.Name = "lblGrossSalesOutput";
            lblGrossSalesOutput.Size = new Size(56, 25);
            lblGrossSalesOutput.TabIndex = 14;
            lblGrossSalesOutput.Text = "$0.00";
            // 
            // lbDisplaySales
            // 
            lbDisplaySales.FormattingEnabled = true;
            lbDisplaySales.HorizontalScrollbar = true;
            lbDisplaySales.ItemHeight = 25;
            lbDisplaySales.Location = new Point(340, 105);
            lbDisplaySales.Name = "lbDisplaySales";
            lbDisplaySales.Size = new Size(595, 279);
            lbDisplaySales.TabIndex = 15;
            // 
            // btnSubmitItem
            // 
            btnSubmitItem.Location = new Point(117, 439);
            btnSubmitItem.Name = "btnSubmitItem";
            btnSubmitItem.Size = new Size(150, 34);
            btnSubmitItem.TabIndex = 16;
            btnSubmitItem.Text = "Submit Item";
            btnSubmitItem.UseVisualStyleBackColor = true;
            btnSubmitItem.Click += btnSubmitItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 485);
            Controls.Add(btnSubmitItem);
            Controls.Add(lbDisplaySales);
            Controls.Add(lblGrossSalesOutput);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtDayFriday);
            Controls.Add(label6);
            Controls.Add(txtDayThursday);
            Controls.Add(label5);
            Controls.Add(txtDayWednesday);
            Controls.Add(label4);
            Controls.Add(txtDayTuesday);
            Controls.Add(label3);
            Controls.Add(txtDayMonday);
            Controls.Add(label2);
            Controls.Add(txtItem);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sales Report";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtItem;
        private TextBox txtDayMonday;
        private Label label2;
        private TextBox txtDayTuesday;
        private Label label3;
        private TextBox txtDayWednesday;
        private Label label4;
        private TextBox txtDayThursday;
        private Label label5;
        private TextBox txtDayFriday;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblGrossSalesOutput;
        private ListBox lbDisplaySales;
        private Button btnSubmitItem;
    }
}