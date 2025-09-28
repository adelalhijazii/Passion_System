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
    public class MasterPortfolioItemMenuController : Controller
    {
        public UserManager<AppUser> UserManager;

        public IRepository<MasterPortfolioItemMenu> MasterPortfolioItemMenu { get; }

        public IRepository<MasterPortfolioCategoryMenu> MasterPortfolioCategoryMenu { get; }

        public Microsoft.AspNetCore.Hosting.IHostingEnvironment Hosting { get; }

        public MasterPortfolioItemMenuController(IRepository<MasterPortfolioItemMenu> _masterPortfolioItemMenu, IRepository<MasterPortfolioCategoryMenu> _masterPortfolioCategoryMenu, Microsoft.AspNetCore.Hosting.IHostingEnvironment _hosting, UserManager<AppUser> _userManager)
        {
            MasterPortfolioItemMenu = _masterPortfolioItemMenu;
            MasterPortfolioCategoryMenu = _masterPortfolioCategoryMenu;
            Hosting = _hosting;
            UserManager = _userManager;
        }

        public ActionResult Index()
        {
            var data = MasterPortfolioItemMenu.View();
            return View(data);
        }

        public ActionResult Active(int id)
        {
            var data = MasterPortfolioItemMenu.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterPortfolioItemMenu.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Create()
        {
            var data = MasterPortfolioCategoryMenu.View();
            ViewBag.category = data;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MasterPortfolioItemMenuViewmodel collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Error Data Entry..!");
                    return View();
                }
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                string ImageName = UploadFile(collection.MasterPortfolioItemMenuFile);

                var data = new MasterPortfolioItemMenu
                {
                    MasterPortfolioItemMenuId = collection.MasterPortfolioItemMenuId,
                    MasterPortfolioCategoryMenuId = collection.MasterPortfolioCategoryMenuId,
                    MasterPortfolioItemMenuTitle = collection.MasterPortfolioItemMenuTitle,
                    MasterPortfolioItemMenuBreef = collection.MasterPortfolioItemMenuBreef,
                    MasterPortfolioItemMenuImageUrl = ImageName,
                    MasterPortfolioItemMenuDetailsTitle = collection.MasterPortfolioItemMenuDetailsTitle,
                    MasterPortfolioItemMenuDetailsDate = collection.MasterPortfolioItemMenuDetailsDate,
                    MasterPortfolioItemMenuDetailsCompany = collection.MasterPortfolioItemMenuDetailsCompany,
                    MasterPortfolioItemMenuDetailsUrlCompany = collection.MasterPortfolioItemMenuDetailsUrlCompany,
                    MasterPortfolioItemMenuDetailsProjectFeatures = collection.MasterPortfolioItemMenuDetailsProjectFeatures,
                    MasterPortfolioItemMenuDetailsTechnologiesUsed = collection.MasterPortfolioItemMenuDetailsTechnologiesUsed,
                    MasterPortfolioItemMenuDetailsDescription1 = collection.MasterPortfolioItemMenuDetailsDescription1,
                    MasterPortfolioItemMenuDetailsDescription2 = collection.MasterPortfolioItemMenuDetailsDescription2,
                    MasterPortfolioItemMenuDetailsActiveUsers = collection.MasterPortfolioItemMenuDetailsActiveUsers,
                    MasterPortfolioItemMenuDetailsClientSatisfaction = collection.MasterPortfolioItemMenuDetailsClientSatisfaction,
                    MasterPortfolioItemMenuDetailsMonthsDevelopment = collection.MasterPortfolioItemMenuDetailsMonthsDevelopment,
                    MasterPortfolioItemMenuDetailsAppStoreRating = collection.MasterPortfolioItemMenuDetailsAppStoreRating,
                    MasterPortfolioItemMenuDetailsTheChallenge = collection.MasterPortfolioItemMenuDetailsTheChallenge,
                    MasterPortfolioItemMenuDetailsTheSolution = collection.MasterPortfolioItemMenuDetailsTheSolution,
                    MasterPortfolioItemMenuDetailsFeatures1 = collection.MasterPortfolioItemMenuDetailsFeatures1,
                    MasterPortfolioItemMenuDetailsFeatures2 = collection.MasterPortfolioItemMenuDetailsFeatures2,
                    MasterPortfolioItemMenuDetailsFeatures3 = collection.MasterPortfolioItemMenuDetailsFeatures3,
                    CreateUser = user.Id,
                    CreateDate = DateTime.Now,
                    IsActive = true
                };
                MasterPortfolioItemMenu.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var data = MasterPortfolioItemMenu.Find(id);
            var data2 = MasterPortfolioCategoryMenu.View();
            ViewBag.category = data2;
            MasterPortfolioItemMenuViewmodel masterPortfolioItemMenuViewModel = new MasterPortfolioItemMenuViewmodel();
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuId = data.MasterPortfolioItemMenuId;
            masterPortfolioItemMenuViewModel.MasterPortfolioCategoryMenuId = data.MasterPortfolioCategoryMenuId;
            masterPortfolioItemMenuViewModel.MasterPortfolioCategoryMenu = MasterPortfolioCategoryMenu.Find(data.MasterPortfolioCategoryMenuId);
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuTitle = data.MasterPortfolioItemMenuTitle;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuBreef = data.MasterPortfolioItemMenuBreef;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuImageUrl = data.MasterPortfolioItemMenuImageUrl;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsTitle = data.MasterPortfolioItemMenuDetailsTitle;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsDate = data.MasterPortfolioItemMenuDetailsDate;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsCompany = data.MasterPortfolioItemMenuDetailsCompany;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsUrlCompany = data.MasterPortfolioItemMenuDetailsUrlCompany;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsProjectFeatures = data.MasterPortfolioItemMenuDetailsProjectFeatures;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsTechnologiesUsed = data.MasterPortfolioItemMenuDetailsTechnologiesUsed;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsDescription1 = data.MasterPortfolioItemMenuDetailsDescription1;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsDescription2 = data.MasterPortfolioItemMenuDetailsDescription2;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsActiveUsers = data.MasterPortfolioItemMenuDetailsActiveUsers;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsClientSatisfaction = data.MasterPortfolioItemMenuDetailsClientSatisfaction;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsMonthsDevelopment = data.MasterPortfolioItemMenuDetailsMonthsDevelopment;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsAppStoreRating = data.MasterPortfolioItemMenuDetailsAppStoreRating;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsTheChallenge = data.MasterPortfolioItemMenuDetailsTheChallenge;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsTheSolution = data.MasterPortfolioItemMenuDetailsTheSolution;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsFeatures1 = data.MasterPortfolioItemMenuDetailsFeatures1;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsFeatures2 = data.MasterPortfolioItemMenuDetailsFeatures2;
            masterPortfolioItemMenuViewModel.MasterPortfolioItemMenuDetailsFeatures3 = data.MasterPortfolioItemMenuDetailsFeatures3;
            masterPortfolioItemMenuViewModel.CreateUser = data.CreateUser;
            masterPortfolioItemMenuViewModel.CreateDate = data.CreateDate;
            return View(masterPortfolioItemMenuViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, MasterPortfolioItemMenuViewmodel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                string ImageName = UploadFile(collection.MasterPortfolioItemMenuFile);

                var data = new MasterPortfolioItemMenu
                {
                    MasterPortfolioItemMenuId = collection.MasterPortfolioItemMenuId,
                    MasterPortfolioCategoryMenuId = collection.MasterPortfolioCategoryMenuId,
                    MasterPortfolioItemMenuTitle = collection.MasterPortfolioItemMenuTitle,
                    MasterPortfolioItemMenuBreef = collection.MasterPortfolioItemMenuBreef,
                    MasterPortfolioItemMenuImageUrl = (ImageName != "") ? ImageName : collection.MasterPortfolioItemMenuImageUrl,
                    MasterPortfolioItemMenuDetailsTitle = collection.MasterPortfolioItemMenuDetailsTitle,
                    MasterPortfolioItemMenuDetailsDate = collection.MasterPortfolioItemMenuDetailsDate,
                    MasterPortfolioItemMenuDetailsCompany = collection.MasterPortfolioItemMenuDetailsCompany,
                    MasterPortfolioItemMenuDetailsUrlCompany = collection.MasterPortfolioItemMenuDetailsUrlCompany,
                    MasterPortfolioItemMenuDetailsProjectFeatures = collection.MasterPortfolioItemMenuDetailsProjectFeatures,
                    MasterPortfolioItemMenuDetailsTechnologiesUsed = collection.MasterPortfolioItemMenuDetailsTechnologiesUsed,
                    MasterPortfolioItemMenuDetailsDescription1 = collection.MasterPortfolioItemMenuDetailsDescription1,
                    MasterPortfolioItemMenuDetailsDescription2 = collection.MasterPortfolioItemMenuDetailsDescription2,
                    MasterPortfolioItemMenuDetailsActiveUsers = collection.MasterPortfolioItemMenuDetailsActiveUsers,
                    MasterPortfolioItemMenuDetailsClientSatisfaction = collection.MasterPortfolioItemMenuDetailsClientSatisfaction,
                    MasterPortfolioItemMenuDetailsMonthsDevelopment = collection.MasterPortfolioItemMenuDetailsMonthsDevelopment,
                    MasterPortfolioItemMenuDetailsAppStoreRating = collection.MasterPortfolioItemMenuDetailsAppStoreRating,
                    MasterPortfolioItemMenuDetailsTheChallenge = collection.MasterPortfolioItemMenuDetailsTheChallenge,
                    MasterPortfolioItemMenuDetailsTheSolution = collection.MasterPortfolioItemMenuDetailsTheSolution,
                    MasterPortfolioItemMenuDetailsFeatures1 = collection.MasterPortfolioItemMenuDetailsFeatures1,
                    MasterPortfolioItemMenuDetailsFeatures2 = collection.MasterPortfolioItemMenuDetailsFeatures2,
                    MasterPortfolioItemMenuDetailsFeatures3 = collection.MasterPortfolioItemMenuDetailsFeatures3,
                    CreateUser = collection.CreateUser,
                    CreateDate = collection.CreateDate,
                    EditUser = user.Id,
                    EditDate = DateTime.Now,
                    IsActive = true

                };
                MasterPortfolioItemMenu.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int Delete)
        {
            MasterPortfolioItemMenu.Delete(Delete, new Models.MasterPortfolioItemMenu { EditUser = User.Identity.Name, EditDate = DateTime.Now });
            return RedirectToAction(nameof(Index));
        }

        string UploadFile(IFormFile File)
        {
            string fileName = "";
            if (File != null)
            {
                string pathFile = Path.Combine(Hosting.WebRootPath, "Pictures/MasterPortfolioItemMenu");
                if (!Directory.Exists(pathFile))
                {
                    Directory.CreateDirectory(pathFile);
                }
                FileInfo fileInfo = new FileInfo(File.FileName);
                fileName = "Image_" + Guid.NewGuid() + fileInfo.Extension;
                string fullPath = Path.Combine(pathFile, fileName);
                File.CopyTo(new FileStream(fullPath, FileMode.Create));
            }
            return fileName;
        }
    }
}
