using System.Security.Claims;

namespace DersPlani_Api.Models
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }

        public int OgretmenId { get; set; }
        // Her dersin bir öğretmeni vardır
        public virtual Ogretmen Ogretmen{ get; set; }

        // Bir dersin birden fazla sınıfı olabilir
        public virtual ICollection<Sınıf> Sınıflar { get; set; }

        // Bir dersin birden fazla saati olabilir
        public virtual ICollection<Saat> Saatler { get; set; }

    }
}
