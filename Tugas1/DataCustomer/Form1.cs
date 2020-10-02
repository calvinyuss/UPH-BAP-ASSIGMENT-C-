using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DataCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * this method is for texbox event when textbox focus enter 
         * @param textBox - textBox that trigger the event
         * @param placeholder - placeholder of the textBox that trigger the event
         */
        private void textBox_Enter(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.ForeColor = Color.FromName("black");
                textBox.Text = "";
            }
        }

        /**
         * this method is for texbox event when textbox lost focus
         * @param textBox - textBox that trigger the event
         * @param placeholder - placeholder of the textBox that trigger the event
         */
        private void textBox_Leave(TextBox textBox, string placeholder)
        {
            if (textBox.Text == "")
            {
                textBox.ForeColor = Color.FromName("silver");
                textBox.Text = placeholder;
            }
        }

        private void kodeTextBox_Enter(object sender, EventArgs e)
        {
            textBox_Enter(kodeTextBox, "Kode");
        }

        private void kodeTextBox_Leave(object sender, EventArgs e)
        {
            textBox_Leave(kodeTextBox, "Kode");
        }

        private void namaTextBox_Enter(object sender, EventArgs e)
        {
            textBox_Enter(namaTextBox, "Nama");
        }

        private void namaTextBox_Leave(object sender, EventArgs e)
        {
            textBox_Leave(namaTextBox, "Nama");
        }

        private void alamatTextBox_Enter(object sender, EventArgs e)
        {
            textBox_Enter(alamatTextBox, "Alamat");
        }

        private void alamatTextBox_Leave(object sender, EventArgs e)
        {
            textBox_Leave(alamatTextBox, "Alamat");
        }

        private void telpTextBox_Enter(object sender, EventArgs e)
        {
            textBox_Enter(telpTextBox, "Telepon");
        }

        private void telpTextBox_Leave(object sender, EventArgs e)
        {
            textBox_Leave(telpTextBox, "Telepon");
        }

        private void telpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validate key pressed
            // only allow digit
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tglGabungTextBox_Enter(object sender, EventArgs e)
        {
            textBox_Enter(tglGabungTextBox, "dd/mm/yyyy");
        }

        private void tglGabungTextBox_Leave(object sender, EventArgs e)
        {
            if (tglGabungTextBox.Text != "") {

                if(tglGabungTextBox.Text == "0")
                {
                    tglGabungTextBox.Text = DateTime.Now.ToString("dd/mm/yyyy");
                }
                else
                {
                    // validate date 
                    DateTime dDate;
                    if (!DateTime.TryParse(tglGabungTextBox.Text, out dDate))
                    {
                        MessageBox.Show("Invalid date format", "DataCustomer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                textBox_Leave(tglGabungTextBox, "dd/mm/yyyy");
            }


        }

        private void tglGabungTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validate key pressed
            // only allow digit and /
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '/');
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            kodeTextBox.Text = "Kode";
            kodeTextBox.ForeColor = Color.Silver;
            namaTextBox.Text = "Nama";
            namaTextBox.ForeColor = Color.Silver;
            alamatTextBox.Text = "Alamat";
            alamatTextBox.ForeColor = Color.Silver;
            kotaComboBox.SelectedIndex = -1;
            telpTextBox.Text = "Telepon";
            telpTextBox.ForeColor = Color.Silver;
            tglGabungTextBox.Text = "dd/mm/yyyy";
            tglGabungTextBox.ForeColor = Color.Silver;
        }

        private void batalBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'b')
            {
                batalBtn_Click(sender, e);
            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            // validate input 
            string kode = kodeTextBox.Text;
            string nama = namaTextBox.Text;
            string alamat = alamatTextBox.Text;
            int kota = kotaComboBox.SelectedIndex;
            string telp = telpTextBox.Text;
            string tglGabung = tglGabungTextBox.Text;

            // validate missing field 
            if (
                kode == "" || nama == "" || alamat == "" || kota == -1 || telp == "" || tglGabung == "" ||
                kode == "Kode" || nama == "Nama" || alamat == "Alamat" || telp == "Telepon" || tglGabung == "dd/mm/yyyy"
                )
            {
                MessageBox.Show("Some field is missing", "DataCustomer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // validate number
            if(!Regex.IsMatch(telp, @"^[0-9]*$"))
            {
                MessageBox.Show("Phone number is must a digit ", "DataCustomer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // validate date 
            string[] formats = { "dd/mm/yyyy" };
            if (!DateTime.TryParseExact(tglGabung, formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out _))
            {
                MessageBox.Show("Invalid date format, use dd/mm/yyyy.", "DataCustomer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Add(kode, nama, alamat, kotaComboBox.SelectedItem, telp, tglGabung);

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int record = dataGridView1.Rows.Count;
            lblTableRecordCount.Text = record + " Record";
        }
    }
}
