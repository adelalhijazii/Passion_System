using Microsoft.EntityFrameworkCore;

namespace Passion.Models.Repository
{
    public class MasterChooseItemMenuRepository : IRepository<MasterChooseItemMenu>
    {
        public MasterChooseItemMenuRepository(AppDbContext _db)
        {
            Db = _db;
        }

        public AppDbContext Db { get; }

        public void Active(int id, MasterChooseItemMenu entity)
        {
            MasterChooseItemMenu data = Find(id);
            data.IsActive = !data.IsActive;
            data.EditUser = entity.EditUser;
            data.EditDate = entity.EditDate;
            Update(id, data);
        }

        public void Add(MasterChooseItemMenu entity)
        {
            entity.IsActive = true;
            Db.MasterChooseItemMenu.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int id, MasterChooseItemMenu entity)
        {
            MasterChooseItemMenu data = Find(id);
            data.IsActive = false;
            data.IsDelete = true;
            data.EditUser = entity.EditUser;
            data.EditDate = entity.EditDate;
            Update(id, data);
        }

        public MasterChooseItemMenu Find(int id)
        {
            var data = Db.MasterChooseItemMenu.SingleOrDefault(x => x.MasterChooseItemMenuId == id);
            return data;
        }

        public void Update(int id, MasterChooseItemMenu entity)
        {
            Db.MasterChooseItemMenu.Update(entity);
            Db.SaveChanges();
        }

        public IList<MasterChooseItemMenu> View()
        {
            return Db.MasterChooseItemMenu.Include(x => x.MasterChooseCategory).Where(data => data.IsDelete == false).ToList();
        }

        public IList<MasterChooseItemMenu> ViewFromClient()
        {
            return Db.MasterChooseItemMenu.Where(data => data.IsDelete == false && data.IsActive == true).ToList();
        }
    }
}
