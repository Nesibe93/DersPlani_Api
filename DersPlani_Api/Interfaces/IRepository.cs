namespace DersPlani_Api.Interfaces
{
    public interface IRepository<Ogretmen>
    {
        IEnumerable<Ogretmen> GetAll();
        Ogretmen GetById(int id);
        void Add(Ogretmen ogretmen);
        void Update(Ogretmen ogretmen);
        void Delete(Ogretmen ogretmen);
    }
}