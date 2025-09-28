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
    public class MasterServiceController : Controller
    {
        public IRepository<MasterService> MasterService { get; }

        public UserManager<AppUser> UserManager { get; }

        public Microsoft.AspNetCore.Hosting.IHostingEnvironment Hosting { get; }

        public MasterServiceController(IRepository<MasterService> _masterService, UserManager<AppUser> _userManager, Microsoft.AspNetCore.Hosting.IHostingEnvironment _hosting)
        {
            MasterService = _masterService;
            UserManager = _userManager;
            Hosting = _hosting;
        }

        public ActionResult Index()
        {
            var data = MasterService.View();
            return View(data);
        }

        public ActionResult Active(int id)
        {
            var data = MasterService.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterService.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MasterServiceViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                var data = new MasterService
                {
                    MasterServiceId = collection.MasterServiceId,
                    MasterServiceProjectsCompleted = collection.MasterServiceProjectsCompleted,
                    MasterServiceClientSatisfaction = collection.MasterServiceClientSatisfaction,
                    MasterServiceSupportAvailable = collection.MasterServiceSupportAvailable,
                    MasterServiceYearsExperience = collection.MasterServiceYearsExperience,
                    CreateUser = user.Id,
                    CreateDate = DateTime.Now,
                    IsActive = true
                };
                MasterService.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var data = MasterService.Find(id);
            MasterServiceViewModel serviceViewModel = new MasterServiceViewModel();
            serviceViewModel.MasterServiceId = data.MasterServiceId;
            serviceViewModel.MasterServiceProjectsCompleted = data.MasterServiceProjectsCompleted;
            serviceViewModel.MasterServiceClientSatisfaction = data.MasterServiceClientSatisfaction;
            serviceViewModel.MasterServiceSupportAvailable = data.MasterServiceSupportAvailable;
            serviceViewModel.MasterServiceYearsExperience = data.MasterServiceYearsExperience;
            serviceViewModel.CreateUser = data.CreateUser;
            serviceViewModel.CreateDate = data.CreateDate;
            return View(serviceViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, MasterServiceViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                var data = new MasterService
                {
                    MasterServiceId = collection.MasterServiceId,
                    MasterServiceProjectsCompleted = collection.MasterServiceProjectsCompleted,
                    MasterServiceClientSatisfaction = collection.MasterServiceClientSatisfaction,
                    MasterServiceSupportAvailable = collection.MasterServiceSupportAvailable,
                    MasterServiceYearsExperience = collection.MasterServiceYearsExperience,
                    CreateUser = collection.CreateUser,
                    CreateDate = collection.CreateDate,
                    EditUser = user.Id,
                    EditDate = DateTime.Now,
                    IsActive = true
                };
                MasterService.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int Delete)
        {
            MasterService.Delete(Delete, new Models.MasterService { EditUser = User.Identity.Name, EditDate = DateTime.Now });
            return RedirectToAction(nameof(Index));
        }
    }
}
