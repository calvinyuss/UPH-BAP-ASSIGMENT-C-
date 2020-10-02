using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        ArrayList colors = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = e.NewValue.ToString();
            colorBox.BackColor = Color.FromArgb(e.NewValue, colorBox.BackColor.G, colorBox.BackColor.B);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = e.NewValue.ToString();
            colorBox.BackColor = Color.FromArgb(colorBox.BackColor.R, e.NewValue, colorBox.BackColor.B);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = e.NewValue.ToString();
            colorBox.BackColor = Color.FromArgb(colorBox.BackColor.R, colorBox.BackColor.G, e.NewValue);
        }

        private void nama_Enter(object sender, EventArgs e)
        {
            if (nama.Text == "Nama Warna")
            {
                nama.ForeColor = Color.FromName("black");
                nama.Text = "";
            }
        }

        private void nama_Leave(object sender, EventArgs e)
        {
            if (nama.Text == "")
            {
                nama.ForeColor = Color.FromName("DarkGray");
                nama.Text = "Nama Warna";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(nama.Text != "Nama Warna");
            if(nama.Text == "" || nama.Text == "Nama Warna")
            {
                MessageBox.Show("Masukan nama warna");
            }
            else
            {
                colors.Add(colorBox.BackColor);
                comboBoxNama.Items.Add(nama.Text);

                comboBoxNama.SelectedIndex = comboBoxNama.Items.Count-1;

                nama.ForeColor = Color.FromName("DarkGray");
                nama.Text = "Nama Warna";
                
            }
        }

        private void comboBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = (Color)colors[comboBoxNama.SelectedIndex];

            colorBox.BackColor = color;

            lblRed.Text = color.R.ToString();
            lblGreen.Text = color.G.ToString();
            lblBlue.Text = color.B.ToString();

            hScrollBar1.Value = color.R;
            hScrollBar2.Value = color.G;
            hScrollBar3.Value = color.B;

        }
    }
}
