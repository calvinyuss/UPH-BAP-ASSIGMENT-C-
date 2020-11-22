using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace Tugas_Pertemuan_13
{
    class DALMahasiswa
    {

        SqlConnection conn;

        public DALMahasiswa()
        {
            string connString = @"data source=localhost\SQLEXPRESS01;initial catalog=DB_SAMPLE;integrated security=True;";

            conn = new SqlConnection(connString);
            IEnumerable<Mahasiswa> mahasiswas = conn.Query<Mahasiswa>("select * from TMahasiswa");
        }

        public IEnumerable<Mahasiswa> getAllMahasiswas()
        {
            conn.Open();
            IEnumerable<Mahasiswa> mahasiswas = conn.Query<Mahasiswa>("select * from TMahasiswa");
            conn.Close();
            return mahasiswas;
        }

        public IEnumerable<Mahasiswa> filterMahasiswa(string nim, string nama, string jenisKelamin, string programStudi, string waktuKuliah, string kelas)
        {
            IEnumerable<Mahasiswa> mahasiswas;

            string query = "select * from TMahasiswa WHERE ";

            query += String.Format("Nim LIKE'{0}%' ", nim ?? "");

            query += String.Format("AND Nama LIKE'{0}%' ", nama ?? "");

            if (!String.IsNullOrEmpty(jenisKelamin))
            {
                query += String.Format("AND JenisKelamin='{0}' ", jenisKelamin);
            }

            if (!String.IsNullOrEmpty(programStudi))
            {
                query += String.Format("AND ProgramStudi='{0}' ", programStudi);
            }

            if (!String.IsNullOrEmpty(waktuKuliah))
            {
                query += String.Format("AND WaktuKuliah='{0}' ", waktuKuliah);
            }

            if (!String.IsNullOrEmpty(kelas))
            {
                query += String.Format("AND Kelas='{0}' ", kelas);
            }

            Console.WriteLine(query);
            conn.Open();

            mahasiswas = conn.Query<Mahasiswa>(query);

            conn.Close();

            return mahasiswas;
        }
    }
}
