using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace Quiz
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

        public IEnumerable<Mahasiswa> filterMahasiswa((string nim, string nama, string jenisKelamin, string programStudi, string waktuKuliah, string kelas) filterMahasiswa)
        {
            IEnumerable<Mahasiswa> mahasiswas;

            string query = "select * from TMahasiswa WHERE ";

            query += String.Format("Nim LIKE'{0}%' ", filterMahasiswa.nim ?? "");

            query += String.Format("AND Nama LIKE'{0}%' ", filterMahasiswa.nama ?? "");

            if (!String.IsNullOrEmpty(filterMahasiswa.jenisKelamin))
            {
                query += String.Format("AND JenisKelamin='{0}' ", filterMahasiswa.jenisKelamin);
            }

            if (!String.IsNullOrEmpty(filterMahasiswa.programStudi))
            {
                query += String.Format("AND ProgramStudi='{0}' ", filterMahasiswa.programStudi);
            }

            if (!String.IsNullOrEmpty(filterMahasiswa.waktuKuliah))
            {
                query += String.Format("AND WaktuKuliah='{0}' ", filterMahasiswa.waktuKuliah);
            }

            if (!String.IsNullOrEmpty(filterMahasiswa.kelas))
            {
                query += String.Format("AND Kelas='{0}' ", filterMahasiswa.kelas);
            }

            Console.WriteLine(query);
            conn.Open();

            mahasiswas = conn.Query<Mahasiswa>(query);

            conn.Close();

            return mahasiswas;
        }
    }
}
