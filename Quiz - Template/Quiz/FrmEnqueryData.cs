using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Quiz
{

    public partial class FrmEnqueryData : Form
    {

        private (
            string nim, 
            string nama, 
            string jenisKelamin, 
            string programStudi, 
            string waktuKuliah, 
            string kelas
            ) filterMahasiswa;

        public FrmEnqueryData()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FrmFilter filterDialog = new FrmFilter(filterMahasiswa);
            filterDialog.ShowDialog();

            filterMahasiswa = filterDialog.getFilterData();

            getFilterMahasiswa();

            string text = "";

            if (!String.IsNullOrEmpty(filterMahasiswa.nim))
            {
                text += String.Format("Nim: {0}, ", filterMahasiswa.nim);
            }

            if (!String.IsNullOrEmpty(filterMahasiswa.nama))
            {
                text += String.Format("Nama: {0}, ", filterMahasiswa.nama);
            }

            if (!String.IsNullOrEmpty(filterMahasiswa.jenisKelamin))
            {
                text += String.Format("Jenis Kelamin: {0}, ", filterMahasiswa.jenisKelamin);
            }

            if (!String.IsNullOrEmpty(filterMahasiswa.programStudi))
            {
                text += String.Format("Program Studi: {0}, ", filterMahasiswa.programStudi);
            }

            if (!String.IsNullOrEmpty(filterMahasiswa.waktuKuliah))
            {
                text += String.Format("Waktu Kuliah: {0}, ", filterMahasiswa.waktuKuliah);
            }

            if (!String.IsNullOrEmpty(filterMahasiswa.kelas))
            {
                text += String.Format("Kelas: {0}, ", filterMahasiswa.kelas);
            }

            lblFilter.Text = text;
        }

        private void getFilterMahasiswa()
        {
            dgvData.Rows.Clear();
            addToTable(new DALMahasiswa().filterMahasiswa(filterMahasiswa));
        }

        private void FrmEnqueryData_Load(object sender, EventArgs e)
        {
            addToTable(new DALMahasiswa().getAllMahasiswas());
        }

        private void addToTable(IEnumerable<Mahasiswa> mahasiswas)
        {
            foreach (Mahasiswa mahasiswa in mahasiswas)
            {
                addToTable(mahasiswa);
            }
            
            lblBanyakRecordData.Text = "Banyak Mahasiwa : "+ mahasiswas.Count();
        }

        private void addToTable(Mahasiswa mahasiswa)
        {
            dgvData.Rows.Add(
                mahasiswa.Nim,
                mahasiswa.Nama,
                mahasiswa.JenisKelamin,
                mahasiswa.ProgramStudi,
                mahasiswa.WaktuKuliah,
                mahasiswa.Kelas
                );
        }
    }
}