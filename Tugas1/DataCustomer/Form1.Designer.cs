namespace DataCustomer
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
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.batalBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kodeTextBox = new System.Windows.Forms.TextBox();
            this.kotaComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tglGabungTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telpTextBox = new System.Windows.Forms.TextBox();
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTableRecordCount = new System.Windows.Forms.Label();
            this.tglGabung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.batalBtn);
            this.customerGroupBox.Controls.Add(this.simpanBtn);
            this.customerGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.customerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.customerGroupBox.Size = new System.Drawing.Size(776, 320);
            this.customerGroupBox.TabIndex = 0;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer";
            // 
            // batalBtn
            // 
            this.batalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batalBtn.Location = new System.Drawing.Point(144, 275);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(114, 29);
            this.batalBtn.TabIndex = 2;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = true;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            this.batalBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.batalBtn_KeyPress);
            // 
            // simpanBtn
            // 
            this.simpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.Location = new System.Drawing.Point(13, 275);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(114, 29);
            this.simpanBtn.TabIndex = 1;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.56614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.43386F));
            this.tableLayoutPanel1.Controls.Add(this.namaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.kodeTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kotaComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.telpTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.alamatTextBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // namaTextBox
            // 
            this.namaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTextBox.ForeColor = System.Drawing.Color.Silver;
            this.namaTextBox.Location = new System.Drawing.Point(98, 37);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(655, 28);
            this.namaTextBox.TabIndex = 7;
            this.namaTextBox.Text = "Nama";
            this.namaTextBox.Enter += new System.EventHandler(this.namaTextBox_Enter);
            this.namaTextBox.Leave += new System.EventHandler(this.namaTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(5, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kota";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(5, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. Telp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(5, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bergabung Sejak";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kodeTextBox
            // 
            this.kodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodeTextBox.ForeColor = System.Drawing.Color.Silver;
            this.kodeTextBox.Location = new System.Drawing.Point(98, 3);
            this.kodeTextBox.Name = "kodeTextBox";
            this.kodeTextBox.Size = new System.Drawing.Size(100, 28);
            this.kodeTextBox.TabIndex = 6;
            this.kodeTextBox.Text = "Kode";
            this.kodeTextBox.Enter += new System.EventHandler(this.kodeTextBox_Enter);
            this.kodeTextBox.Leave += new System.EventHandler(this.kodeTextBox_Leave);
            // 
            // kotaComboBox
            // 
            this.kotaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kotaComboBox.FormattingEnabled = true;
            this.kotaComboBox.Items.AddRange(new object[] {
            "Medan",
            "Tebing Tinggi",
            "Binjai ",
            "Kisaran",
            "Ranto Perapat",
            "Tanjung Balai",
            "Perbaungan",
            "Pematang Siantar"});
            this.kotaComboBox.Location = new System.Drawing.Point(98, 105);
            this.kotaComboBox.Name = "kotaComboBox";
            this.kotaComboBox.Size = new System.Drawing.Size(243, 24);
            this.kotaComboBox.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tglGabungTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(98, 169);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(655, 52);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // tglGabungTextBox
            // 
            this.tglGabungTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglGabungTextBox.ForeColor = System.Drawing.Color.Silver;
            this.tglGabungTextBox.Location = new System.Drawing.Point(3, 10);
            this.tglGabungTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.tglGabungTextBox.MaxLength = 10;
            this.tglGabungTextBox.Name = "tglGabungTextBox";
            this.tglGabungTextBox.Size = new System.Drawing.Size(119, 28);
            this.tglGabungTextBox.TabIndex = 14;
            this.tglGabungTextBox.Text = "dd/mm/yyyy";
            this.tglGabungTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tglGabungTextBox.Enter += new System.EventHandler(this.tglGabungTextBox_Enter);
            this.tglGabungTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tglGabungTextBox_KeyPress);
            this.tglGabungTextBox.Leave += new System.EventHandler(this.tglGabungTextBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "0 = Today";
            // 
            // telpTextBox
            // 
            this.telpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telpTextBox.ForeColor = System.Drawing.Color.Silver;
            this.telpTextBox.Location = new System.Drawing.Point(98, 135);
            this.telpTextBox.MaxLength = 12;
            this.telpTextBox.Name = "telpTextBox";
            this.telpTextBox.Size = new System.Drawing.Size(243, 28);
            this.telpTextBox.TabIndex = 10;
            this.telpTextBox.Text = "Telepon";
            this.telpTextBox.Enter += new System.EventHandler(this.telpTextBox_Enter);
            this.telpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telpTextBox_KeyPress);
            this.telpTextBox.Leave += new System.EventHandler(this.telpTextBox_Leave);
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatTextBox.ForeColor = System.Drawing.Color.Silver;
            this.alamatTextBox.Location = new System.Drawing.Point(98, 71);
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(655, 28);
            this.alamatTextBox.TabIndex = 8;
            this.alamatTextBox.Text = "Alamat";
            this.alamatTextBox.Enter += new System.EventHandler(this.alamatTextBox_Enter);
            this.alamatTextBox.Leave += new System.EventHandler(this.alamatTextBox_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblTableRecordCount);
            this.panel1.Location = new System.Drawing.Point(12, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 275);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode,
            this.nama,
            this.alamat,
            this.kota,
            this.telp,
            this.tglGabung});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 241);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // lblTableRecordCount
            // 
            this.lblTableRecordCount.AutoSize = true;
            this.lblTableRecordCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTableRecordCount.Location = new System.Drawing.Point(0, 0);
            this.lblTableRecordCount.Name = "lblTableRecordCount";
            this.lblTableRecordCount.Size = new System.Drawing.Size(66, 17);
            this.lblTableRecordCount.TabIndex = 0;
            this.lblTableRecordCount.Text = "0 Record";
            // 
            // tglGabung
            // 
            this.tglGabung.HeaderText = "Bergabung Sejak";
            this.tglGabung.MinimumWidth = 6;
            this.tglGabung.Name = "tglGabung";
            this.tglGabung.ReadOnly = true;
            this.tglGabung.Width = 125;
            // 
            // telp
            // 
            this.telp.HeaderText = "No. Telp";
            this.telp.MinimumWidth = 6;
            this.telp.Name = "telp";
            this.telp.ReadOnly = true;
            this.telp.Width = 200;
            // 
            // kota
            // 
            this.kota.HeaderText = "Kota";
            this.kota.MinimumWidth = 6;
            this.kota.Name = "kota";
            this.kota.Width = 200;
            // 
            // alamat
            // 
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 6;
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            this.alamat.Width = 250;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 200;
            // 
            // kode
            // 
            this.kode.HeaderText = "Kode";
            this.kode.MinimumWidth = 6;
            this.kode.Name = "kode";
            this.kode.ReadOnly = true;
            this.kode.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.customerGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kodeTextBox;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.ComboBox kotaComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tglGabungTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telpTextBox;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTableRecordCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn telp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglGabung;
    }
}

