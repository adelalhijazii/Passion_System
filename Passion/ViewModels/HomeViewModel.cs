using Passion.Models;

namespace Passion.ViewModels
{
    public class HomeViewModel
    {
        public MasterAboutUs AboutUs { get; set; }

        public IList<MasterChooseCategory> ListChooseCategory { get; set; }

        public IList<MasterChooseItemMenu> ListChooseItemMenu { get; set; }

        public MasterContactUs Contactus { get; set; }

        public MasterContactUsInformation ContactUsInformation1 { get; set; }

        public MasterContactUsInformation ContactUsInformation2 { get; set; }

        public MasterContactUsInformation ContactUsInformation3 { get; set; }

        public MasterContactUsInformation ContactUsInformation4 { get; set; }

        public MasterFeature Feature { get; set; }

        public IList<MasterFeatures> ListFeatures { get; set; }

        public MasterFocus Focus { get; set; }
        
        public IList<MasterHowWeWork> ListHowWeWork { get; set; }

        public IList<MasterMenu> ListMenu { get; set; }

        public IList<MasterOurServices> ListOurServices { get; set; }

        public IList<MasterPartner> ListPartner { get; set; }

        public IList<MasterPortfolioCategoryMenu> ListPortfolioCategoryMenu { get; set; }

        public IList<MasterPortfolioItemMenu> ListPortfolioItemMenu { get; set; }

        public MasterPortfolioItemMenu PortfolioItemMenu { get; set; }

        public IList<MasterPricing> ListPricing { get; set; }

        public IList<MasterQuestions> ListQuestions { get; set; }

        public MasterService Service { get; set; }

        public IList<MasterServices> ListServices { get; set; }

        public MasterServices Services { get; set; }

        public IList<MasterSocialMedium> ListSocialMedium { get; set; }

        public IList<MasterTeam> ListTeam { get; set; }

        public IList<MasterUsefullLinks> ListUsefullLinks { get; set; }

        public IList<MasterWhatPeopleSay> ListWhatPeopleSay { get; set; }

        public SystemSetting Setting { get; set; }

        public TransactionContactUs ContactUs { get; set; }
    }
}
