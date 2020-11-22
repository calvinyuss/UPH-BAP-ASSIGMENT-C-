using System;
using System.Linq;
using System.Windows.Forms;

namespace Tugas_Pertemuan_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.IEnumerable<Mahasiswa> mahasiswas = new DALMahasiswa().filterMahasiswa(
                            txtNim.Text.Trim(),
                            txtNama.Text.Trim(),
                            (string)cboJenisKelamin.SelectedItem ?? "",
                            (string)cboProgramStudi.SelectedItem ?? "",
                            (string)cboWaktuKuliah.SelectedItem ?? "",
                            (string)cboKelas.SelectedItem ?? ""
                         );

            if (mahasiswas.Count() == 0)
            {
                MessageBox.Show("Tidak ada data yang dimunculkan", "Opps..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ReportDataSet ds = new ReportDataSet(); 

            foreach (Mahasiswa mahasiswa in mahasiswas)
            {
                var row = ds.MahasiswaTable.NewMahasiswaTableRow();
                row.Nim = mahasiswa.Nim.ToString();
                row.Nama = mahasiswa.Nama;
                row.JenisKelamin = mahasiswa.JenisKelamin;
                row.ProgramStudi = mahasiswa.ProgramStudi;
                row.WaktuKuliah = mahasiswa.WaktuKuliah;
                row.Kelas = mahasiswa.Kelas;
                ds.MahasiswaTable.AddMahasiswaTableRow(row);
            }

            MahasiswaReport mhsReport = new MahasiswaReport();
            mhsReport.SetDataSource(ds);
            this.CRV.ReportSource = mhsReport;
            
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
    }
}