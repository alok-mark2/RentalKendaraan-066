using System;
using System.Collections.Generic;

#nullable disable

namespace RENTAL_KENDARAAN.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        public int IdJaminan { get; set; }
        public string NamaJaminan { get; set; }

        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
