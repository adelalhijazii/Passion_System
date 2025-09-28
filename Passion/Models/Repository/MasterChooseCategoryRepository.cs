namespace Passion.Models.Repository
{
    public class MasterChooseCategoryRepository : IRepository<MasterChooseCategory>
    {
        public MasterChooseCategoryRepository(AppDbContext _db)
        {
            Db = _db;
        }

        public AppDbContext Db { get; }

        public void Active(int id, MasterChooseCategory entity)
        {
            MasterChooseCategory data = Find(id);
            data.IsActive = !data.IsActive;
            data.EditUser = entity.EditUser;
            data.EditDate = entity.EditDate;
            Update(id, data);
        }

        public void Add(MasterChooseCategory entity)
        {
            entity.IsActive = true;
            Db.MasterChooseCategory.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int id, MasterChooseCategory entity)
        {
            MasterChooseCategory data = Find(id);
            data.IsActive = false;
            data.IsDelete = true;
            data.EditUser = entity.EditUser;
            data.EditDate = entity.EditDate;
            Update(id, data);
        }

        public MasterChooseCategory Find(int id)
        {
            var data = Db.MasterChooseCategory.SingleOrDefault(x => x.MasterChooseCategoryId == id);
            return data;
        }

        public void Update(int id, MasterChooseCategory entity)
        {
            Db.MasterChooseCategory.Update(entity);
            Db.SaveChanges();
        }

        public IList<MasterChooseCategory> View()
        {
            return Db.MasterChooseCategory.Where(data => data.IsDelete == false).ToList();
        }

        public IList<MasterChooseCategory> ViewFromClient()
        {
            return Db.MasterChooseCategory.Where(data => data.IsDelete == false && data.IsActive == true).ToList();
        }
    }
}
