using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfAppSube2
{
    internal class Ogrenci
    {
        public int OgrenciId { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public int Ad { get; set; }

        public int Soyad { get; set; }

        public int Numara { get; set;}

        public override string ToString()
        {
            return $" {this.Ad}-{this.Numara}-{this.Soyad}";
        }
    }
}
