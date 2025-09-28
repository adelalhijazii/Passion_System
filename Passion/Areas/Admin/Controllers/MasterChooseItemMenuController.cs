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
    public class MasterChooseItemMenuController : Controller
    {
        public IRepository<MasterChooseItemMenu> MasterChooseItemMenu { get; }

        public IRepository<MasterChooseCategory> MasterChooseCategory { get; }

        public UserManager<AppUser> UserManager { get; }

        public Microsoft.AspNetCore.Hosting.IHostingEnvironment Hosting { get; }

        public MasterChooseItemMenuController(IRepository<MasterChooseItemMenu> _masterChooseItemMenu, IRepository<MasterChooseCategory> _masterChooseCategory, UserManager<AppUser> _userManager, Microsoft.AspNetCore.Hosting.IHostingEnvironment _hosting)
        {
            MasterChooseItemMenu = _masterChooseItemMenu;
            MasterChooseCategory = _masterChooseCategory;
            UserManager = _userManager;
            Hosting = _hosting;
        }

        public ActionResult Index()
        {
            var data = MasterChooseItemMenu.View();
            return View(data);
        }

        public ActionResult Active(int id)
        {
            var data = MasterChooseItemMenu.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterChooseItemMenu.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Create()
        {
            var data = MasterChooseCategory.View();
            ViewBag.category = data;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MasterChooseItemMenuViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                if (!ModelState.IsValid)
                {
                    return View();
                }
                string ImageName = "";
                if (collection.MasterChooseItemMenuFile != null)
                {
                    string PathImage = Path.Combine(Hosting.WebRootPath, "Pictures/MasterChooseItemMenu");
                    if (!Directory.Exists(PathImage))
                    {
                        Directory.CreateDirectory(PathImage);
                    }
                    FileInfo fi = new FileInfo(collection.MasterChooseItemMenuFile.FileName);
                    ImageName = "MasterChooseItemMenuImageUrl" + Guid.NewGuid() + fi.Extension;

                    string FullPath = Path.Combine(PathImage, ImageName);
                    collection.MasterChooseItemMenuFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                }
                MasterChooseItemMenu obj = new MasterChooseItemMenu
                {
                    MasterChooseItemMenuId = collection.MasterChooseItemMenuId,
                    MasterChooseCategoryId = collection.MasterChooseCategoryId,
                    MasterChooseItemMenuTitle = collection.MasterChooseItemMenuTitle,
                    MasterChooseItemMenuBreef = collection.MasterChooseItemMenuBreef,
                    MasterChooseItemMenuDescription = collection.MasterChooseItemMenuDescription,
                    MasterChooseItemMenuList = collection.MasterChooseItemMenuList,
                    MasterChooseItemMenuImageUrl = ImageName,
                    CreateUser = user.Id,
                    CreateDate = DateTime.Now,
                    IsActive = true
                };
                MasterChooseItemMenu.Add(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var data = MasterChooseItemMenu.Find(id);
            var data2 = MasterChooseCategory.View();
            ViewBag.category = data2;
            MasterChooseItemMenuViewModel chooseitemmenumodel = new MasterChooseItemMenuViewModel();
            chooseitemmenumodel.MasterChooseItemMenuId = data.MasterChooseItemMenuId;
            chooseitemmenumodel.MasterChooseCategoryId = data.MasterChooseCategoryId;
            chooseitemmenumodel.MasterChooseItemMenuTitle = data.MasterChooseItemMenuTitle;
            chooseitemmenumodel.MasterChooseItemMenuBreef = data.MasterChooseItemMenuBreef;
            chooseitemmenumodel.MasterChooseItemMenuDescription = data.MasterChooseItemMenuDescription;
            chooseitemmenumodel.MasterChooseItemMenuList = data.MasterChooseItemMenuList;
            chooseitemmenumodel.MasterChooseItemMenuImageUrl = data.MasterChooseItemMenuImageUrl;
            chooseitemmenumodel.CreateUser = data.CreateUser;
            chooseitemmenumodel.CreateDate = data.CreateDate;
            return View(chooseitemmenumodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, MasterChooseItemMenuViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                string ImageName = "";
                if (collection.MasterChooseItemMenuFile != null)
                {
                    string PathImage = Path.Combine(Hosting.WebRootPath, "Pictures/MasterChooseItemMenu");
                    if (!Directory.Exists(PathImage))
                    {
                        Directory.CreateDirectory(PathImage);
                    }
                    FileInfo fi = new FileInfo(collection.MasterChooseItemMenuFile.FileName);
                    ImageName = "MasterChooseItemMenuImageUrl" + Guid.NewGuid() + fi.Extension;

                    string FullPath = Path.Combine(PathImage, ImageName);
                    collection.MasterChooseItemMenuFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                }
                var obj = new MasterChooseItemMenu
                {
                    MasterChooseItemMenuId = collection.MasterChooseItemMenuId,
                    MasterChooseCategoryId = collection.MasterChooseCategoryId,
                    MasterChooseItemMenuTitle = collection.MasterChooseItemMenuTitle,
                    MasterChooseItemMenuBreef = collection.MasterChooseItemMenuBreef,
                    MasterChooseItemMenuDescription = collection.MasterChooseItemMenuDescription,
                    MasterChooseItemMenuList = collection.MasterChooseItemMenuList,
                    MasterChooseItemMenuImageUrl = (ImageName != "") ? ImageName : collection.MasterChooseItemMenuImageUrl,
                    CreateUser = collection.CreateUser,
                    CreateDate = collection.CreateDate,
                    EditUser = user.Id,
                    EditDate = DateTime.Now,
                    IsActive = true
                };
                MasterChooseItemMenu.Update(id, obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int Delete)
        {
            MasterChooseItemMenu.Delete(Delete, new Models.MasterChooseItemMenu { EditUser = User.Identity.Name, EditDate = DateTime.Now });
            return RedirectToAction(nameof(Index));
        }
    }
}
