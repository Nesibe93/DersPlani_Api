using DersPlani_Api.Data;
using DersPlani_Api.Interfaces;
using DersPlani_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DersPlani_Api.Repositories
{
    public class OgretmenRepository : IRepository<Ogretmen>
    {

        private readonly AppDbContext _context;

        public OgretmenRepository(AppDbContext context)
        {
            _context = context;
        }
        
        //private IEnumerable<Ogretmen> _ogretmenler;
        //public OgretmenRepository() => _ogretmenler = new List<Ogretmen>
        //{
        //    new Ogretmen { OgretmenId = 1, OgretmenAdi = "Nesibe", OgretmenSoyadi = "Kosanoğlu"},
        //    new Ogretmen { OgretmenId = 2, OgretmenAdi = "Ayşe", OgretmenSoyadi = "Kış" },
        //    new Ogretmen { OgretmenId = 3, OgretmenAdi = "Fatma", OgretmenSoyadi = "Yaz" }

        //};

     

        public IEnumerable<Ogretmen> GetAll()
        {
            return _context.Ogretmenler.ToList();
        }

        public Ogretmen GetById(int id)
        {
            return _context.Ogretmenler.FirstOrDefault(o => o.OgretmenId == id);
        }

        public void Add(Ogretmen ogretmen)
        {
            _context.Ogretmenler.Add(ogretmen);
            _context.SaveChanges();

        }

        public void Update(Ogretmen ogretmen)
        {
            _context.Entry(ogretmen).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var ogretmen = _context.Ogretmenler.Find(id);
            if (ogretmen != null)
            {
                _context.Ogretmenler.Remove(ogretmen);
                _context.SaveChanges();
            }
        }

        public void Delete(Ogretmen ogretmen)
        {
            throw new NotImplementedException();
        }
    }
}

