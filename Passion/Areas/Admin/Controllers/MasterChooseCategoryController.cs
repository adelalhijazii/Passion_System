using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Passion.Areas.Admin.ViewModels;
using Passion.Models;
using Passion.Models.Repository;

namespace Passion.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterChooseCategoryController : Controller
    {
        public IRepository<MasterChooseCategory> MasterChooseCategory { get; }

        public UserManager<AppUser> UserManager { get; }

        public MasterChooseCategoryController(IRepository<MasterChooseCategory> _masterChooseCategory, UserManager<AppUser> _userManager)
        {
            MasterChooseCategory = _masterChooseCategory;
            UserManager = _userManager;
        }

        public ActionResult Index()
        {
            var data = MasterChooseCategory.View();
            return View(data);
        }

        public ActionResult Active(int id)
        {
            var data = MasterChooseCategory.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterChooseCategory.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MasterChooseCategoryViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                var data = new MasterChooseCategory
                {
                    MasterChooseCategoryId = collection.MasterChooseCategoryId,
                    MasterChooseCategoryIcon = collection.MasterChooseCategoryIcon,
                    MasterChooseCategoryTitle = collection.MasterChooseCategoryTitle,
                    MasterChooseCategoryBreef = collection.MasterChooseCategoryBreef,
                    CreateUser = user.Id,
                    CreateDate = DateTime.Now,
                    IsActive = true
                };
                MasterChooseCategory.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var data = MasterChooseCategory.Find(id);
            MasterChooseCategoryViewModel choosecategorymodel = new MasterChooseCategoryViewModel();
            choosecategorymodel.MasterChooseCategoryId = data.MasterChooseCategoryId;
            choosecategorymodel.MasterChooseCategoryIcon = data.MasterChooseCategoryIcon;
            choosecategorymodel.MasterChooseCategoryTitle = data.MasterChooseCategoryTitle;
            choosecategorymodel.MasterChooseCategoryBreef = data.MasterChooseCategoryBreef;
            choosecategorymodel.CreateUser = data.CreateUser;
            choosecategorymodel.CreateDate = data.CreateDate;
            return View(choosecategorymodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, MasterChooseCategoryViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                var data = new MasterChooseCategory
                {
                    MasterChooseCategoryId = collection.MasterChooseCategoryId,
                    MasterChooseCategoryIcon = collection.MasterChooseCategoryIcon,
                    MasterChooseCategoryTitle = collection.MasterChooseCategoryTitle,
                    MasterChooseCategoryBreef = collection.MasterChooseCategoryBreef,
                    CreateUser = collection.CreateUser,
                    CreateDate = collection.CreateDate,
                    EditUser = user.Id,
                    EditDate = DateTime.Now,
                    IsActive = true
                };
                MasterChooseCategory.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int Delete)
        {
            MasterChooseCategory.Delete(Delete, new Models.MasterChooseCategory { EditUser = User.Identity.Name, EditDate = DateTime.Now });
            return RedirectToAction(nameof(Index));
        }
    }
}
