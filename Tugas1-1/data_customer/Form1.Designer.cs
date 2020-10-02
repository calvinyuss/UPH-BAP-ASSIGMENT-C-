namespace data_customer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.kodeTextBox = new System.Windows.Forms.TextBox();
            this.kotaComboBox = new System.Windows.Forms.ComboBox();
            this.telpTextBox = new System.Windows.Forms.TextBox();
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.tglGabungTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.batalBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.recordCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglGabung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.batalBtn);
            this.groupBox1.Controls.Add(this.simpanBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.namaTextBox);
            this.groupBox1.Controls.Add(this.kodeTextBox);
            this.groupBox1.Controls.Add(this.kotaComboBox);
            this.groupBox1.Controls.Add(this.telpTextBox);
            this.groupBox1.Controls.Add(this.alamatTextBox);
            this.groupBox1.Controls.Add(this.tglGabungTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tanggal Gabung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "No. Telp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Kota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kode";
            // 
            // namaTextBox
            // 
            this.namaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTextBox.ForeColor = System.Drawing.Color.Silver;
            this.namaTextBox.Location = new System.Drawing.Point(209, 74);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(561, 28);
            this.namaTextBox.TabIndex = 17;
            this.namaTextBox.Text = "Nama";
            this.namaTextBox.Enter += new System.EventHandler(this.namaTextBox_Enter);
            this.namaTextBox.Leave += new System.EventHandler(this.namaTextBox_Leave);
            // 
            // kodeTextBox
            // 
            this.kodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodeTextBox.ForeColor = System.Drawing.Color.Silver;
            this.kodeTextBox.Location = new System.Drawing.Point(209, 40);
            this.kodeTextBox.Name = "kodeTextBox";
            this.kodeTextBox.Size = new System.Drawing.Size(100, 28);
            this.kodeTextBox.TabIndex = 16;
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
            this.kotaComboBox.Location = new System.Drawing.Point(209, 142);
            this.kotaComboBox.Name = "kotaComboBox";
            this.kotaComboBox.Size = new System.Drawing.Size(243, 24);
            this.kotaComboBox.TabIndex = 20;
            // 
            // telpTextBox
            // 
            this.telpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telpTextBox.ForeColor = System.Drawing.Color.Silver;
            this.telpTextBox.Location = new System.Drawing.Point(209, 172);
            this.telpTextBox.MaxLength = 12;
            this.telpTextBox.Name = "telpTextBox";
            this.telpTextBox.Size = new System.Drawing.Size(243, 28);
            this.telpTextBox.TabIndex = 19;
            this.telpTextBox.Text = "Telepon";
            this.telpTextBox.Enter += new System.EventHandler(this.noTelpTextBox_Enter);
            this.telpTextBox.Leave += new System.EventHandler(this.noTelpTextBox_Leave);
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatTextBox.ForeColor = System.Drawing.Color.Silver;
            this.alamatTextBox.Location = new System.Drawing.Point(209, 108);
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(561, 28);
            this.alamatTextBox.TabIndex = 18;
            this.alamatTextBox.Text = "Alamat";
            this.alamatTextBox.Enter += new System.EventHandler(this.alamatTextBox_Enter);
            this.alamatTextBox.Leave += new System.EventHandler(this.alamatTextBox_Leave);
            // 
            // tglGabungTextBox
            // 
            this.tglGabungTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglGabungTextBox.ForeColor = System.Drawing.Color.Silver;
            this.tglGabungTextBox.Location = new System.Drawing.Point(209, 217);
            this.tglGabungTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.tglGabungTextBox.MaxLength = 10;
            this.tglGabungTextBox.Name = "tglGabungTextBox";
            this.tglGabungTextBox.Size = new System.Drawing.Size(119, 28);
            this.tglGabungTextBox.TabIndex = 21;
            this.tglGabungTextBox.Text = "dd/mm/yyyy";
            this.tglGabungTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tglGabungTextBox.Enter += new System.EventHandler(this.tglGabungTextBox_Enter);
            this.tglGabungTextBox.Leave += new System.EventHandler(this.tglGabungTextBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "0 = Today";
            // 
            // batalBtn
            // 
            this.batalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batalBtn.Location = new System.Drawing.Point(180, 269);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(114, 29);
            this.batalBtn.TabIndex = 30;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = true;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.Location = new System.Drawing.Point(49, 269);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(114, 29);
            this.simpanBtn.TabIndex = 29;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // recordCount
            // 
            this.recordCount.AutoSize = true;
            this.recordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordCount.Location = new System.Drawing.Point(8, 362);
            this.recordCount.Name = "recordCount";
            this.recordCount.Size = new System.Drawing.Size(77, 20);
            this.recordCount.TabIndex = 31;
            this.recordCount.Text = "0 Record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode,
            this.nama,
            this.alamat,
            this.kota,
            this.telp,
            this.tglGabung});
            this.dataGridView1.Location = new System.Drawing.Point(12, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 197);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // kode
            // 
            this.kode.HeaderText = "Kode";
            this.kode.MinimumWidth = 6;
            this.kode.Name = "kode";
            this.kode.ReadOnly = true;
            this.kode.Width = 125;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 150;
            // 
            // alamat
            // 
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 6;
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            this.alamat.Width = 250;
            // 
            // kota
            // 
            this.kota.HeaderText = "Kota";
            this.kota.MinimumWidth = 6;
            this.kota.Name = "kota";
            this.kota.ReadOnly = true;
            this.kota.Width = 150;
            // 
            // telp
            // 
            this.telp.HeaderText = "No. Telp";
            this.telp.MinimumWidth = 6;
            this.telp.Name = "telp";
            this.telp.ReadOnly = true;
            this.telp.Width = 150;
            // 
            // tglGabung
            // 
            this.tglGabung.HeaderText = "Bergabung Sejak";
            this.tglGabung.MinimumWidth = 6;
            this.tglGabung.Name = "tglGabung";
            this.tglGabung.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.recordCount);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Customer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.TextBox kodeTextBox;
        private System.Windows.Forms.ComboBox kotaComboBox;
        private System.Windows.Forms.TextBox telpTextBox;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.TextBox tglGabungTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Label recordCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn telp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglGabung;
    }
}

