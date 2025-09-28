namespace Passion.Models.Repository
{
    public class MasterHowWeWorkRepository : IRepository<MasterHowWeWork>
    {
        public MasterHowWeWorkRepository(AppDbContext _db)
        {
            Db = _db;
        }

        public AppDbContext Db { get; }

        public void Active(int id, MasterHowWeWork entity)
        {
            MasterHowWeWork data = Find(id);
            data.IsActive = !data.IsActive;
            data.EditUser = entity.EditUser;
            data.EditDate = entity.EditDate;
            Update(id, data);
        }

        public void Add(MasterHowWeWork entity)
        {
            entity.IsActive = true;
            Db.MasterHowWeWork.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int id, MasterHowWeWork entity)
        {
            MasterHowWeWork data = Find(id);
            data.IsActive = false;
            data.IsDelete = true;
            data.EditUser = entity.EditUser;
            data.EditDate = entity.EditDate;
            Update(id, data);
        }

        public MasterHowWeWork Find(int id)
        {
            var data = Db.MasterHowWeWork.SingleOrDefault(x => x.MasterHowWeWorkId == id);
            return data;
        }

        public void Update(int id, MasterHowWeWork entity)
        {
            Db.MasterHowWeWork.Update(entity);
            Db.SaveChanges();
        }

        public IList<MasterHowWeWork> View()
        {
            return Db.MasterHowWeWork.Where(data => data.IsDelete == false).ToList();
        }

        public IList<MasterHowWeWork> ViewFromClient()
        {
            return Db.MasterHowWeWork.Where(data => data.IsDelete == false && data.IsActive == true).ToList();
        }
    }
}
