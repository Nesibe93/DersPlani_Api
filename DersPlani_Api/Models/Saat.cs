using System.Security.Claims;

namespace DersPlani_Api.Models
{
    public class Saat
    {
        public int SaatId { get; set; }
        public string DersSaati { get; set; }
        // Foreign Keys
        public int DersId { get; set; }
        public int SınıfId { get; set; }

       // Her saatin bir dersi vardır
        public virtual Ders Ders { get; set; }
        // Her bir saatin bir sınıfı vardır
        public virtual Sınıf Sınıf { get; set; }
    }
}
