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
    public class MasterContactUsController : Controller
    {
        public IRepository<MasterContactUs> MasterContactUs { get; }

        public UserManager<AppUser> UserManager { get; }

        public MasterContactUsController(IRepository<MasterContactUs> _masterContactUs, UserManager<AppUser> _userManager)
        {
            MasterContactUs = _masterContactUs;
            UserManager = _userManager;
        }

        public ActionResult Index()
        {
            var data = MasterContactUs.View();
            return View(data);
        }

        public ActionResult Active(int id)
        {
            var data = MasterContactUs.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterContactUs.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MasterContactUsViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                var data = new MasterContactUs
                {
                    MasterContactUsId = collection.MasterContactUsId,
                    MasterContactUsDescription = collection.MasterContactUsDescription,
                    MasterContactUsPhone = collection.MasterContactUsPhone,
                    MasterContactUsEmail = collection.MasterContactUsEmail,
                    CreateUser = user.Id,
                    CreateDate = DateTime.Now,
                    IsActive = true
                };
                MasterContactUs.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var data = MasterContactUs.Find(id);
            MasterContactUsViewModel contactusmodel = new MasterContactUsViewModel();
            contactusmodel.MasterContactUsId = data.MasterContactUsId;
            contactusmodel.MasterContactUsDescription = data.MasterContactUsDescription;
            contactusmodel.MasterContactUsPhone = data.MasterContactUsPhone;
            contactusmodel.MasterContactUsEmail = data.MasterContactUsEmail;
            contactusmodel.CreateUser = data.CreateUser;
            contactusmodel.CreateDate = data.CreateDate;
            return View(contactusmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, MasterContactUsViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                var data = new MasterContactUs
                {
                    MasterContactUsId = collection.MasterContactUsId,
                    MasterContactUsDescription = collection.MasterContactUsDescription,
                    MasterContactUsPhone = collection.MasterContactUsPhone,
                    MasterContactUsEmail = collection.MasterContactUsEmail,
                    CreateUser = collection.CreateUser,
                    CreateDate = collection.CreateDate,
                    EditUser = user.Id,
                    EditDate = DateTime.Now,
                    IsActive = true
                };
                MasterContactUs.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int Delete)
        {
            MasterContactUs.Delete(Delete, new Models.MasterContactUs { EditUser = User.Identity.Name, EditDate = DateTime.Now });
            return RedirectToAction(nameof(Index));
        }
    }
}
