namespace Pertemuan15
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomor,
            this.Tanggal,
            this.Supplier,
            this.Quantity,
            this.Keterangan});
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nomor
            // 
            this.Nomor.HeaderText = "Nomor Order";
            this.Nomor.MinimumWidth = 6;
            this.Nomor.Name = "Nomor";
            this.Nomor.Width = 125;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "tanggal order";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 125;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "supplier";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            this.Supplier.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "banyak item order";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Keterangan
            // 
            this.Keterangan.HeaderText = "keterangan";
            this.Keterangan.MinimumWidth = 6;
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export to excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keterangan;
        private System.Windows.Forms.Button button1;
    }
}

