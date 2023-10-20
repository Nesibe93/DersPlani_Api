namespace DersPlani_Api.Models
{
    public class Sınıf
    {
        public int SınıfId { get; set; }

        public string SınıfAdi { get; set; }

        public int DersId { get; set; }
        // Her sınıfın birden fazla dersi vardır
        public virtual ICollection<Ders> Dersler { get; set; }

        // Bir sınıfın birden fazla saati vardır
        public virtual ICollection<Saat> Saatler { get; set; }
    }
}
