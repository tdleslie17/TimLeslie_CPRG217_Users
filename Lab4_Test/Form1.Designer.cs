namespace Lab4_Test
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
            this.components = new System.ComponentModel.Container();
            this.orderDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(356, 373);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(413, 59);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate UserIds and Passwords";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(935, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 40);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Location = new System.Drawing.Point(70, 9);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(187, 29);
            this.lblCustomerDetails.TabIndex = 18;
            this.lblCustomerDetails.Text = "Customer Details:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(75, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(438, 207);
            this.listBox1.TabIndex = 19;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Lab4_ClassLibrary.Customer);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(649, 77);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(484, 37);
            this.cmbCustomers.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 444);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblCustomerDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1275, 500);
            this.Name = "Form1";
            this.Text = "Generate UserIds and Passwords for Customers Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource1;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbCustomers;
    }
}

