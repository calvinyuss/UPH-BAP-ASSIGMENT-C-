using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan15
{
    class Order
    {
        // order group 
        public int Nomor { get; set; }
        public DateTime Tanggal { get; set; }
        public string Supplier { get; set; }
        public string Keterangan { get; set; }

        // barang group
        public int KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Satuan { get; set; }

        // order detail group
        public int NomorUrut { get; set; }
        public string Quantity { get; set; }

    }
}
