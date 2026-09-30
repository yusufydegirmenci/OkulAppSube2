using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfAppSube2
{
    internal class Ogrenci
    {
        public int OgrenciId { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Ad { get; set; } = string.Empty;

        public string Soyad { get; set; } = string.Empty;

        public string Numara { get; set; } = string.Empty;

        public override string ToString()
        {
            return $" {Ad}-{Numara}-{Soyad}";
        }
    }
}
