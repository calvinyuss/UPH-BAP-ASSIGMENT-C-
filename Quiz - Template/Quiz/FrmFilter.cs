using System;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmFilter : Form
    {

        private (
            string nim,
            string nama,
            string jenisKelamin,
            string programStudi,
            string waktuKuliah,
            string kelas
            ) filterMahasiswa;

        public FrmFilter((string nim, string nama, string jenisKelamin, string programStudi, string waktuKuliah, string kelas) filterMahasiswa)
        {
            InitializeComponent();

            this.filterMahasiswa = filterMahasiswa;
            setFilterToTextBox();
        }

        private void setFilterToTextBox()
        {
            txtNim.Text = filterMahasiswa.nim;
            txtNama.Text = filterMahasiswa.nama;
            cboJenisKelamin.SelectedItem = filterMahasiswa.jenisKelamin;
            cboProgramStudi.SelectedItem = filterMahasiswa.programStudi;
            cboWaktuKuliah.SelectedItem = filterMahasiswa.waktuKuliah;
            cboKelas.SelectedItem = filterMahasiswa.kelas;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNim.Clear();
            txtNama.Clear();
            cboJenisKelamin.SelectedIndex = -1;
            cboProgramStudi.SelectedIndex = -1;
            cboWaktuKuliah.SelectedIndex = -1;
            cboKelas.SelectedIndex = -1;
        }

        public (string nim, string nama, string jenisKelamin, string programStudi, string waktuKuliah, string kelas) getDataFilterData()
        {
            return filterMahasiswa;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            filterMahasiswa.nim = txtNim.Text.Trim();
            filterMahasiswa.nama = txtNama.Text.Trim();
            filterMahasiswa.jenisKelamin = (string)cboJenisKelamin.SelectedItem ?? "";
            filterMahasiswa.programStudi = (string)cboProgramStudi.SelectedItem ?? "";
            filterMahasiswa.waktuKuliah = (string)cboWaktuKuliah.SelectedItem ?? "";
            filterMahasiswa.kelas = (string)cboKelas.SelectedItem ?? "";
            this.Dispose();
        }

        public (string nim, string nama, string jenisKelamin, string programStudi, string waktuKuliah, string kelas) getFilterData()
        {
            return filterMahasiswa;
        }
    }

}