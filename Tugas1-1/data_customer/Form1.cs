using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace data_customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            recordCount.Text = dataGridView1.Rows.Count + " Record";
        }

        private void kodeTextBox_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "Kode")
            {
                box.ForeColor = Color.FromName("black");
                box.Text = "";
            }
        }

        private void kodeTextBox_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "")
            {
                box.ForeColor = Color.FromName("DarkGray");
                box.Text = "Kode";
            }
        }

        private void namaTextBox_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "Nama")
            {
                box.ForeColor = Color.FromName("black");
                box.Text = "";
            }
        }

        private void namaTextBox_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "")
            {
                box.ForeColor = Color.FromName("DarkGray");
                box.Text = "Nama";
            }
        }

        private void alamatTextBox_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "Alamat")
            {
                box.ForeColor = Color.FromName("black");
                box.Text = "";
            }
        }

        private void alamatTextBox_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "")
            {
                box.ForeColor = Color.FromName("DarkGray");
                box.Text = "Alamat";
            }
        }

        private void noTelpTextBox_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "Telepon")
            {
                box.ForeColor = Color.FromName("black");
                box.Text = "";
            }
        }

        private void noTelpTextBox_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "")
            {
                box.ForeColor = Color.FromName("DarkGray");
                box.Text = "Telepon";
            }
        }

        private void tglGabungTextBox_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "dd/mm/yyyy")
            {
                box.ForeColor = Color.FromName("black");
                box.Text = "";
            }
        }

        private void tglGabungTextBox_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "")
            {
                box.ForeColor = Color.FromName("DarkGray");
                box.Text = "dd/mm/yyyy";
            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            string kode = kodeTextBox.Text;
            string nama = namaTextBox.Text;
            string alamat = alamatTextBox.Text;
            int kota = kotaComboBox.SelectedIndex;
            string noTelp = telpTextBox.Text;
            string tglGabung = tglGabungTextBox.Text;

            if (kode == "" || kode == "Kode")
            {
                MessageBox.Show("Data Kode kosong!!");
                return;
            }

            if (nama == "" || nama == "Nama")
            {
                MessageBox.Show("Data nama kosong!!");
                return;
            }

            if (alamat == "" || alamat == "Alamat")
            {
                MessageBox.Show("Data alamat kosong!!");
                return;
            }

            if (kotaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih kota terlebih dahulu!!");
                return;
            }

            if (noTelp == "" || noTelp == "Telepon" )
            {
                MessageBox.Show("Data No. Telp kosong!");
                return;
            }

            if (!Regex.IsMatch(noTelp, @"^[0-9]*$"))
            {
                MessageBox.Show("Nomor telepon hanya boleh angka !");
                return;
            }

            if (tglGabung == "" || tglGabung == "dd/mm/yyyy")
            {
                MessageBox.Show("Data tanggal gabung kosong!");
                return;
            }

            // validate date 
            string formats =  "dd/mm/yyyy" ;
            if (!DateTime.TryParseExact(tglGabung, formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out _) && (tglGabung != "0"))
            {
                MessageBox.Show("Format Tanggal gabung salah, gunakan dd/mm/yyyy (01/01/2000)");
                return;
            }

            if(tglGabung == "0") tglGabung = DateTime.Now.ToString("dd/mm/yyyy");

            dataGridView1.Rows.Add(kode, nama, alamat, kotaComboBox.SelectedItem, noTelp, tglGabung);

            batalBtn_Click(sender, e);

        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            kodeTextBox.Text = "Kode";
            kodeTextBox.ForeColor = Color.DarkGray;
            namaTextBox.Text = "Nama";
            namaTextBox.ForeColor = Color.DarkGray;
            alamatTextBox.Text = "Alamat";
            alamatTextBox.ForeColor = Color.DarkGray;
            kotaComboBox.SelectedIndex = -1;
            telpTextBox.Text = "Telepon";
            telpTextBox.ForeColor = Color.DarkGray;
            tglGabungTextBox.Text = "dd/mm/yyyy";
            tglGabungTextBox.ForeColor = Color.DarkGray;
        }
    }
}
