using System;
using System.Collections.Generic;

#nullable disable

namespace RENTAL_KENDARAAN.Models
{
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalians = new HashSet<Pengembalian>();
        }

        public int IdKondisi { get; set; }
        public string NamaKondisi { get; set; }

        public virtual ICollection<Pengembalian> Pengembalians { get; set; }
    }
}
