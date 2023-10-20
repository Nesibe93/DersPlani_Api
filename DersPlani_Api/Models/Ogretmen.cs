namespace DersPlani_Api.Models
{
    public class Ogretmen
    {
        public int OgretmenId { get; set; }
        public string OgretmenAdi { get; set; }
        public string OgretmenSoyadi { get; set; }

        // Bir öğretmen birden fazla derse girebilir
        public virtual ICollection<Ders> Dersler { get; set; }

    }
}
