using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Passion.Models;
using Passion.Models.Repository;
using Passion.ViewModels;
using System.Diagnostics;

namespace Passion.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IRepository<MasterAboutUs> _masterAboutUs, IRepository<MasterChooseCategory> _masterChooseCategory,
            IRepository<MasterChooseItemMenu> _masterChooseItemMenu, IRepository<MasterContactUs> _masterContactUs,
            IRepository<MasterContactUsInformation> _masterContactUsInformation, IRepository<MasterFeature> _masterFeature,
            IRepository<MasterFeatures> _masterFeatures, IRepository<MasterFocus> _masterFocus, IRepository<MasterHowWeWork> _masterHowWeWork,
            IRepository<MasterMenu> _masterMenu, IRepository<MasterOurServices> _masterOurServices, IRepository<MasterPartner> _masterPartner,
            IRepository<MasterPortfolioCategoryMenu> _masterPortfolioCategoryMenu, IRepository<MasterPortfolioItemMenu> _masterPortfolioItemMenu,
            IRepository<MasterPricing> _masterPricing, IRepository<MasterQuestions> _masterQuestions, IRepository<MasterService> _masterService,
            IRepository<MasterServices> _masterServices, IRepository<MasterSocialMedium> _masterSocialMedium, IRepository<MasterTeam> _masterTeam,
            IRepository<MasterUsefullLinks> _masterUsefullLinks, IRepository<MasterWhatPeopleSay> _masterWhatPeopleSay,
            IRepository<SystemSetting> _systemSetting, IRepository<TransactionContactUs> _transactionContactUs)
        {
            MasterAboutUs = _masterAboutUs;
            MasterChooseCategory = _masterChooseCategory;
            MasterChooseItemMenu = _masterChooseItemMenu;
            MasterContactUs = _masterContactUs;
            MasterContactUsInformation = _masterContactUsInformation;
            MasterFeature = _masterFeature;
            MasterFeatures = _masterFeatures;
            MasterFocus = _masterFocus;
            MasterHowWeWork = _masterHowWeWork;
            MasterMenu = _masterMenu;
            MasterOurServices = _masterOurServices;
            MasterPartner = _masterPartner;
            MasterPortfolioCategoryMenu = _masterPortfolioCategoryMenu;
            MasterPortfolioItemMenu = _masterPortfolioItemMenu;
            MasterPricing = _masterPricing;
            MasterQuestions = _masterQuestions;
            MasterService = _masterService;
            MasterServices = _masterServices;
            MasterSocialMedium = _masterSocialMedium;
            MasterTeam = _masterTeam;
            MasterUsefullLinks = _masterUsefullLinks;
            MasterWhatPeopleSay = _masterWhatPeopleSay;
            SystemSetting = _systemSetting;
            TransactionContactUs = _transactionContactUs;
        }

        public IRepository<MasterAboutUs> MasterAboutUs { get; }
        public IRepository<MasterChooseCategory> MasterChooseCategory { get; }
        public IRepository<MasterChooseItemMenu> MasterChooseItemMenu { get; }
        public IRepository<MasterContactUs> MasterContactUs { get; }
        public IRepository<MasterContactUsInformation> MasterContactUsInformation { get; }
        public IRepository<MasterFeature> MasterFeature { get; }
        public IRepository<MasterFeatures> MasterFeatures { get; }
        public IRepository<MasterFocus> MasterFocus { get; }
        public IRepository<MasterHowWeWork> MasterHowWeWork { get; }
        public IRepository<MasterMenu> MasterMenu { get; }
        public IRepository<MasterOurServices> MasterOurServices { get; }
        public IRepository<MasterPartner> MasterPartner { get; }
        public IRepository<MasterPortfolioCategoryMenu> MasterPortfolioCategoryMenu { get; }
        public IRepository<MasterPortfolioItemMenu> MasterPortfolioItemMenu { get; }
        public IRepository<MasterPricing> MasterPricing { get; }
        public IRepository<MasterQuestions> MasterQuestions { get; }
        public IRepository<MasterService> MasterService { get; }
        public IRepository<MasterServices> MasterServices { get; }
        public IRepository<MasterSocialMedium> MasterSocialMedium { get; }
        public IRepository<MasterTeam> MasterTeam { get; }
        public IRepository<MasterUsefullLinks> MasterUsefullLinks { get; }
        public IRepository<MasterWhatPeopleSay> MasterWhatPeopleSay { get; }
        public IRepository<SystemSetting> SystemSetting { get; }
        public IRepository<TransactionContactUs> TransactionContactUs { get; }

        public IActionResult Index()
        {
            HomeViewModel obj = new HomeViewModel();

            obj.ListMenu = MasterMenu.ViewFromClient().ToList();
            obj.ListPartner = MasterPartner.ViewFromClient().ToList();
            obj.Feature = MasterFeature.Find(1);
            obj.ListFeatures = MasterFeatures.ViewFromClient().ToList();
            obj.ListHowWeWork = MasterHowWeWork.ViewFromClient().ToList();
            obj.ListChooseCategory = MasterChooseCategory.ViewFromClient().ToList();
            obj.ListChooseItemMenu = MasterChooseItemMenu.ViewFromClient().ToList();
            obj.Service = MasterService.Find(1);
            obj.ListServices = MasterServices.ViewFromClient().ToList();
            obj.ListPricing = MasterPricing.ViewFromClient().ToList();
            obj.ListQuestions = MasterQuestions.ViewFromClient().ToList();
            obj.Focus = MasterFocus.Find(1);
            obj.ListWhatPeopleSay = MasterWhatPeopleSay.ViewFromClient().ToList();
            obj.ListPortfolioCategoryMenu = MasterPortfolioCategoryMenu.ViewFromClient().ToList();
            obj.ListPortfolioItemMenu = MasterPortfolioItemMenu.ViewFromClient().ToList();
            obj.ListTeam = MasterTeam.ViewFromClient().ToList();
            obj.ContactUsInformation1 = MasterContactUsInformation.Find(1);
            obj.ContactUsInformation2 = MasterContactUsInformation.Find(2);
            obj.ContactUsInformation3 = MasterContactUsInformation.Find(3);
            obj.ContactUsInformation4 = MasterContactUsInformation.Find(4);
            obj.AboutUs = MasterAboutUs.Find(1);
            obj.Contactus = MasterContactUs.Find(1);
            obj.ListUsefullLinks = MasterUsefullLinks.ViewFromClient().ToList();
            obj.ListOurServices = MasterOurServices.ViewFromClient().ToList();
            obj.ListSocialMedium = MasterSocialMedium.ViewFromClient().ToList();

            obj.Setting = SystemSetting.Find(1);
            return View(obj);
        }

        public IActionResult PortfolioDetails(int idDetails)
        {
            HomeViewModel obj = new HomeViewModel();
            obj.PortfolioItemMenu = MasterPortfolioItemMenu.Find(idDetails);

            obj.AboutUs = MasterAboutUs.Find(1);
            obj.Contactus = MasterContactUs.Find(1);
            obj.ListMenu = MasterMenu.ViewFromClient().ToList();
            obj.ListUsefullLinks = MasterUsefullLinks.ViewFromClient().ToList();
            obj.ListOurServices = MasterOurServices.ViewFromClient().ToList();
            obj.ListSocialMedium = MasterSocialMedium.ViewFromClient().ToList();

            obj.Setting = SystemSetting.Find(1);
            return View(obj);
        }

        public IActionResult ServiceDetails(int idDetails)
        {
            HomeViewModel obj = new HomeViewModel();
            obj.Services = MasterServices.Find(idDetails);

            obj.AboutUs = MasterAboutUs.Find(1);
            obj.Contactus = MasterContactUs.Find(1);
            obj.ListMenu = MasterMenu.ViewFromClient().ToList();
            obj.ListUsefullLinks = MasterUsefullLinks.ViewFromClient().ToList();
            obj.ListOurServices = MasterOurServices.ViewFromClient().ToList();
            obj.ListSocialMedium = MasterSocialMedium.ViewFromClient().ToList();

            obj.Setting = SystemSetting.Find(1);
            return View(obj);
        }

        [HttpPost]
        public IActionResult ContactUs(HomeViewModel data)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.message = "Failed";
                return RedirectToAction("ContactUs", "Home");
            }

            TransactionContactUs.Add(data.ContactUs);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult PrivacyPolicy()
        {
            HomeViewModel obj = new HomeViewModel();

            obj.AboutUs = MasterAboutUs.Find(1);
            obj.Contactus = MasterContactUs.Find(1);
            obj.ListMenu = MasterMenu.ViewFromClient().ToList();
            obj.ListUsefullLinks = MasterUsefullLinks.ViewFromClient().ToList();
            obj.ListOurServices = MasterOurServices.ViewFromClient().ToList();
            obj.ListSocialMedium = MasterSocialMedium.ViewFromClient().ToList();

            obj.Setting = SystemSetting.Find(1);
            return View(obj);
        }

        public IActionResult TermsOfService()
        {
            HomeViewModel obj = new HomeViewModel();

            obj.AboutUs = MasterAboutUs.Find(1);
            obj.Contactus = MasterContactUs.Find(1);
            obj.ListMenu = MasterMenu.ViewFromClient().ToList();
            obj.ListUsefullLinks = MasterUsefullLinks.ViewFromClient().ToList();
            obj.ListOurServices = MasterOurServices.ViewFromClient().ToList();
            obj.ListSocialMedium = MasterSocialMedium.ViewFromClient().ToList();

            obj.Setting = SystemSetting.Find(1);
            return View(obj);
        }
    }
}
