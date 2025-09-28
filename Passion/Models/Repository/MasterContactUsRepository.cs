namespace Passion.Models.Repository
{
    public class MasterContactUsRepository : IRepository<MasterContactUs>
    {
        public MasterContactUsRepository(AppDbContext _db)
        {
            Db = _db;
        }

        public AppDbContext Db { get; }

        public void Active(int id, MasterContactUs entity)
        {
            MasterContactUs data = Find(id);
            data.IsActive = !data.IsActive;
            data.EditUser = entity.EditUser;
            data.EditDate = entity.EditDate;
            Update(id, data);
        }

        public void Add(MasterContactUs entity)
        {
            entity.IsActive = true;
            Db.MasterContactUs.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int id, MasterContactUs entity)
        {
            MasterContactUs data = Find(id);
            data.IsActive = false;
            data.IsDelete = true;
            data.EditUser = entity.EditUser;
            data.EditDate = entity.EditDate;
            Update(id, data);
        }

        public MasterContactUs Find(int id)
        {
            var data = Db.MasterContactUs.SingleOrDefault(x => x.MasterContactUsId == id);
            return data;
        }

        public void Update(int id, MasterContactUs entity)
        {
            Db.MasterContactUs.Update(entity);
            Db.SaveChanges();
        }

        public IList<MasterContactUs> View()
        {
            return Db.MasterContactUs.Where(data => data.IsDelete == false).ToList();
        }

        public IList<MasterContactUs> ViewFromClient()
        {
            return Db.MasterContactUs.Where(data => data.IsDelete == false && data.IsActive == true).ToList();
        }
    }
}
