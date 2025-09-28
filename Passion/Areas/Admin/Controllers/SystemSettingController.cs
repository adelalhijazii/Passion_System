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
    public class SystemSettingController : Controller
    {
        public IRepository<SystemSetting> SystemSetting { get; }

        public UserManager<AppUser> UserManager { get; }

        public Microsoft.AspNetCore.Hosting.IHostingEnvironment Hosting { get; }

        public SystemSettingController(IRepository<SystemSetting> _systemSetting, UserManager<AppUser> _userManager, Microsoft.AspNetCore.Hosting.IHostingEnvironment _hosting)
        {
            SystemSetting = _systemSetting;
            UserManager = _userManager;
            Hosting = _hosting;
        }

        public ActionResult Index()
        {
            var data = SystemSetting.View();
            return View(data);
        }

        public ActionResult Active(int id)
        {
            var data = SystemSetting.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            SystemSetting.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SystemSettingViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                if (!ModelState.IsValid)
                {
                    return View();
                }
                string WelcomeNoteImageName = "";
                string AboutImageName = "";
                if (collection.SystemSettingWelcomeNoteImageUrlFile != null)
                {
                    string PathImage = Path.Combine(Hosting.WebRootPath, "Pictures/SystemSetting");
                    if (!Directory.Exists(PathImage))
                    {
                        Directory.CreateDirectory(PathImage);
                    }
                    FileInfo fi = new FileInfo(collection.SystemSettingWelcomeNoteImageUrlFile.FileName);
                    WelcomeNoteImageName = "SystemSettingWelcomeNoteImageUrl" + Guid.NewGuid() + fi.Extension;

                    string FullPath = Path.Combine(PathImage, WelcomeNoteImageName);
                    collection.SystemSettingWelcomeNoteImageUrlFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                }
                if (collection.SystemSettingAboutImageUrlFile != null)
                {
                    string PathImage = Path.Combine(Hosting.WebRootPath, "Pictures/SystemSetting");
                    if (!Directory.Exists(PathImage))
                    {
                        Directory.CreateDirectory(PathImage);
                    }
                    FileInfo fi = new FileInfo(collection.SystemSettingAboutImageUrlFile.FileName);
                    AboutImageName = "SystemSettingAboutImageUrl" + Guid.NewGuid() + fi.Extension;

                    string FullPath = Path.Combine(PathImage, AboutImageName);
                    collection.SystemSettingAboutImageUrlFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                }
                SystemSetting obj = new SystemSetting
                {
                    SystemSettingId = collection.SystemSettingId,
                    SystemSettingLogoImageUrl = collection.SystemSettingLogoImageUrl,
                    SystemSettingWelcomeNoteTitle = collection.SystemSettingWelcomeNoteTitle,
                    SystemSettingWelcomeNoteBreef = collection.SystemSettingWelcomeNoteBreef,
                    SystemSettingWelcomeNoteDescription = collection.SystemSettingWelcomeNoteDescription,
                    SystemSettingServicesUrl = collection.SystemSettingServicesUrl,
                    SystemSettingEmail = collection.SystemSettingEmail,
                    SystemSettingPhoneNumber = collection.SystemSettingPhoneNumber,
                    SystemSettingProjectsCompleted = collection.SystemSettingProjectsCompleted,
                    SystemSettingClientSatisfaction = collection.SystemSettingClientSatisfaction,
                    SystemSettingSupportAvailable = collection.SystemSettingSupportAvailable,
                    SystemSettingSecureAndReliable = collection.SystemSettingSecureAndReliable,
                    SystemSettingHighPerformance = collection.SystemSettingHighPerformance,
                    SystemSettingExpertTeam = collection.SystemSettingExpertTeam,
                    SystemSettingAwardWinning = collection.SystemSettingAwardWinning,
                    SystemSettingCopyright = collection.SystemSettingCopyright,
                    SystemSettingAboutTitle = collection.SystemSettingAboutTitle,
                    SystemSettingAboutBreef = collection.SystemSettingAboutBreef,
                    SystemSettingAboutDescription1 = collection.SystemSettingAboutDescription1,
                    SystemSettingAboutDescription2 = collection.SystemSettingAboutDescription2,
                    SystemSettingAboutAwardIcon = collection.SystemSettingAboutAwardIcon,
                    SystemSettingAboutAwardTitle = collection.SystemSettingAboutAwardTitle,
                    SystemSettingAboutYearsExperience = collection.SystemSettingAboutYearsExperience,
                    SystemSettingAboutProjectsCompleted = collection.SystemSettingAboutProjectsCompleted,
                    SystemSettingAboutTeamMembers = collection.SystemSettingAboutTeamMembers,
                    SystemSettingAboutPortfolioUrl = collection.SystemSettingAboutPortfolioUrl,
                    SystemSettingAboutTeamUrl = collection.SystemSettingAboutTeamUrl,
                    SystemSettingWelcomeNoteImageUrl = WelcomeNoteImageName,
                    SystemSettingAboutImageUrl = AboutImageName,
                    CreateUser = user.Id,
                    CreateDate = DateTime.Now,
                    IsActive = true
                };
                SystemSetting.Add(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var data = SystemSetting.Find(id);
            SystemSettingViewModel systemsetting = new SystemSettingViewModel();
            systemsetting.SystemSettingId = data.SystemSettingId;
            systemsetting.SystemSettingLogoImageUrl = data.SystemSettingLogoImageUrl;
            systemsetting.SystemSettingWelcomeNoteTitle = data.SystemSettingWelcomeNoteTitle;
            systemsetting.SystemSettingWelcomeNoteBreef = data.SystemSettingWelcomeNoteBreef;
            systemsetting.SystemSettingWelcomeNoteDescription = data.SystemSettingWelcomeNoteDescription;
            systemsetting.SystemSettingWelcomeNoteImageUrl = data.SystemSettingWelcomeNoteImageUrl;
            systemsetting.SystemSettingServicesUrl = data.SystemSettingServicesUrl;
            systemsetting.SystemSettingEmail = data.SystemSettingEmail;
            systemsetting.SystemSettingPhoneNumber = data.SystemSettingPhoneNumber;
            systemsetting.SystemSettingProjectsCompleted = data.SystemSettingProjectsCompleted;
            systemsetting.SystemSettingClientSatisfaction = data.SystemSettingClientSatisfaction;
            systemsetting.SystemSettingSupportAvailable = data.SystemSettingSupportAvailable;
            systemsetting.SystemSettingSecureAndReliable = data.SystemSettingSecureAndReliable;
            systemsetting.SystemSettingHighPerformance = data.SystemSettingHighPerformance;
            systemsetting.SystemSettingExpertTeam = data.SystemSettingExpertTeam;
            systemsetting.SystemSettingAwardWinning = data.SystemSettingAwardWinning;
            systemsetting.SystemSettingCopyright = data.SystemSettingCopyright;
            systemsetting.SystemSettingAboutTitle = data.SystemSettingAboutTitle;
            systemsetting.SystemSettingAboutBreef = data.SystemSettingAboutBreef;
            systemsetting.SystemSettingAboutDescription1 = data.SystemSettingAboutDescription1;
            systemsetting.SystemSettingAboutDescription2 = data.SystemSettingAboutDescription2;
            systemsetting.SystemSettingAboutImageUrl = data.SystemSettingAboutImageUrl;
            systemsetting.SystemSettingAboutAwardIcon = data.SystemSettingAboutAwardIcon;
            systemsetting.SystemSettingAboutAwardTitle = data.SystemSettingAboutAwardTitle;
            systemsetting.SystemSettingAboutYearsExperience = data.SystemSettingAboutYearsExperience;
            systemsetting.SystemSettingAboutProjectsCompleted = data.SystemSettingAboutProjectsCompleted;
            systemsetting.SystemSettingAboutTeamMembers = data.SystemSettingAboutTeamMembers;
            systemsetting.SystemSettingAboutPortfolioUrl = data.SystemSettingAboutPortfolioUrl;
            systemsetting.SystemSettingAboutTeamUrl = data.SystemSettingAboutTeamUrl;
            systemsetting.CreateUser = data.CreateUser;
            systemsetting.CreateDate = data.CreateDate;
            return View(systemsetting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, SystemSettingViewModel collection)
        {
            try
            {
                var user = await UserManager.FindByNameAsync(User.Identity.Name);
                string WelcomeNoteImageName = "";
                string AboutImageName = "";
                if (collection.SystemSettingWelcomeNoteImageUrlFile != null)
                {
                    string PathImage = Path.Combine(Hosting.WebRootPath, "Pictures/SystemSetting");
                    if (!Directory.Exists(PathImage))
                    {
                        Directory.CreateDirectory(PathImage);
                    }
                    FileInfo fi = new FileInfo(collection.SystemSettingWelcomeNoteImageUrlFile.FileName);
                    WelcomeNoteImageName = "SystemSettingWelcomeNoteImageUrl" + Guid.NewGuid() + fi.Extension;

                    string FullPath = Path.Combine(PathImage, WelcomeNoteImageName);
                    collection.SystemSettingWelcomeNoteImageUrlFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                }
                if (collection.SystemSettingAboutImageUrlFile != null)
                {
                    string PathImage = Path.Combine(Hosting.WebRootPath, "Pictures/SystemSetting");
                    if (!Directory.Exists(PathImage))
                    {
                        Directory.CreateDirectory(PathImage);
                    }
                    FileInfo fi = new FileInfo(collection.SystemSettingAboutImageUrlFile.FileName);
                    AboutImageName = "SystemSettingAboutImageUrl" + Guid.NewGuid() + fi.Extension;

                    string FullPath = Path.Combine(PathImage, AboutImageName);
                    collection.SystemSettingAboutImageUrlFile.CopyTo(new FileStream(FullPath, FileMode.Create));
                }
                var obj = new SystemSetting
                {
                    SystemSettingId = collection.SystemSettingId,
                    SystemSettingLogoImageUrl = collection.SystemSettingLogoImageUrl,
                    SystemSettingWelcomeNoteTitle = collection.SystemSettingWelcomeNoteTitle,
                    SystemSettingWelcomeNoteBreef = collection.SystemSettingWelcomeNoteBreef,
                    SystemSettingWelcomeNoteDescription = collection.SystemSettingWelcomeNoteDescription,
                    SystemSettingServicesUrl = collection.SystemSettingServicesUrl,
                    SystemSettingEmail = collection.SystemSettingEmail,
                    SystemSettingPhoneNumber = collection.SystemSettingPhoneNumber,
                    SystemSettingProjectsCompleted = collection.SystemSettingProjectsCompleted,
                    SystemSettingClientSatisfaction = collection.SystemSettingClientSatisfaction,
                    SystemSettingSupportAvailable = collection.SystemSettingSupportAvailable,
                    SystemSettingSecureAndReliable = collection.SystemSettingSecureAndReliable,
                    SystemSettingHighPerformance = collection.SystemSettingHighPerformance,
                    SystemSettingExpertTeam = collection.SystemSettingExpertTeam,
                    SystemSettingAwardWinning = collection.SystemSettingAwardWinning,
                    SystemSettingCopyright = collection.SystemSettingCopyright,
                    SystemSettingAboutTitle = collection.SystemSettingAboutTitle,
                    SystemSettingAboutBreef = collection.SystemSettingAboutBreef,
                    SystemSettingAboutDescription1 = collection.SystemSettingAboutDescription1,
                    SystemSettingAboutDescription2 = collection.SystemSettingAboutDescription2,
                    SystemSettingAboutAwardIcon = collection.SystemSettingAboutAwardIcon,
                    SystemSettingAboutAwardTitle = collection.SystemSettingAboutAwardTitle,
                    SystemSettingAboutYearsExperience = collection.SystemSettingAboutYearsExperience,
                    SystemSettingAboutProjectsCompleted = collection.SystemSettingAboutProjectsCompleted,
                    SystemSettingAboutTeamMembers = collection.SystemSettingAboutTeamMembers,
                    SystemSettingAboutPortfolioUrl = collection.SystemSettingAboutPortfolioUrl,
                    SystemSettingAboutTeamUrl = collection.SystemSettingAboutTeamUrl,
                    SystemSettingWelcomeNoteImageUrl = (WelcomeNoteImageName != "") ? WelcomeNoteImageName : collection.SystemSettingWelcomeNoteImageUrl,
                    SystemSettingAboutImageUrl = (AboutImageName != "") ? AboutImageName : collection.SystemSettingAboutImageUrl,
                    CreateUser = collection.CreateUser,
                    CreateDate = collection.CreateDate,
                    EditUser = user.Id,
                    EditDate = DateTime.Now,
                    IsActive = true
                };
                SystemSetting.Update(id, obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int Delete)
        {
            SystemSetting.Delete(Delete, new Models.SystemSetting { EditUser = User.Identity.Name, EditDate = DateTime.Now });
            return RedirectToAction(nameof(Index));
        }
    }
}
