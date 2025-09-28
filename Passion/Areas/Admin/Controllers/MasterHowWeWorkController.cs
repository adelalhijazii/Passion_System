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
    public class MasterHowWeWorkController : Controller
    {
        public IRepository<MasterHowWeWork> MasterHowWeWork { get; }

        public UserManager<AppUser> UserManager { get; }

        public MasterHowWeWorkController(IRepository<MasterHowWeWork> _masterHowWeWork, UserManager<AppUser> _userManager)
        {
            MasterHowWeWork = _masterHowWeWork;
            UserManager = _userManager;
        }

        public ActionResult Index()
        {
            var data = MasterHowWeWork.View();
            return View(data);
        }

        public ActionResult Active(int id)
        {
            var data = MasterHowWeWork.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterHowWeWork.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MasterHowWeWorkViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                var data = new MasterHowWeWork
                {
                    MasterHowWeWorkId = collection.MasterHowWeWorkId,
                    MasterHowWeWorkIcon = collection.MasterHowWeWorkIcon,
                    MasterHowWeWorkTitle = collection.MasterHowWeWorkTitle,
                    MasterHowWeWorkBreef = collection.MasterHowWeWorkBreef,
                    MasterHowWeWorkDescription = collection.MasterHowWeWorkDescription,
                    CreateUser = user.Id,
                    CreateDate = DateTime.Now,
                    IsActive = true
                };
                MasterHowWeWork.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var data = MasterHowWeWork.Find(id);
            MasterHowWeWorkViewModel howweworkmodel = new MasterHowWeWorkViewModel();
            howweworkmodel.MasterHowWeWorkId = data.MasterHowWeWorkId;
            howweworkmodel.MasterHowWeWorkIcon = data.MasterHowWeWorkIcon;
            howweworkmodel.MasterHowWeWorkTitle = data.MasterHowWeWorkTitle;
            howweworkmodel.MasterHowWeWorkBreef = data.MasterHowWeWorkBreef;
            howweworkmodel.MasterHowWeWorkDescription = data.MasterHowWeWorkDescription;
            howweworkmodel.CreateUser = data.CreateUser;
            howweworkmodel.CreateDate = data.CreateDate;
            return View(howweworkmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, MasterHowWeWorkViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                var data = new MasterHowWeWork
                {
                    MasterHowWeWorkId = collection.MasterHowWeWorkId,
                    MasterHowWeWorkIcon = collection.MasterHowWeWorkIcon,
                    MasterHowWeWorkTitle = collection.MasterHowWeWorkTitle,
                    MasterHowWeWorkBreef = collection.MasterHowWeWorkBreef,
                    MasterHowWeWorkDescription = collection.MasterHowWeWorkDescription,
                    CreateUser = collection.CreateUser,
                    CreateDate = collection.CreateDate,
                    EditUser = user.Id,
                    EditDate = DateTime.Now,
                    IsActive = true
                };
                MasterHowWeWork.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int Delete)
        {
            MasterHowWeWork.Delete(Delete, new Models.MasterHowWeWork { EditUser = User.Identity.Name, EditDate = DateTime.Now });
            return RedirectToAction(nameof(Index));
        }
    }
}
