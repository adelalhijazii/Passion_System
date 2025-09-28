namespace Passion.Models
{
    public class MasterPortfolioItemMenu : BaseEntity
    {
        public int MasterPortfolioItemMenuId { get; set; }

        public int MasterPortfolioCategoryMenuId { get; set; }

        public string MasterPortfolioItemMenuTitle { get; set; }

        public string MasterPortfolioItemMenuBreef { get; set; }

        public string MasterPortfolioItemMenuImageUrl { get; set; }

        public MasterPortfolioCategoryMenu MasterPortfolioCategoryMenu { get; set; }

        public string MasterPortfolioItemMenuDetailsTitle { get; set; }

        public string MasterPortfolioItemMenuDetailsDate { get; set; }

        public string MasterPortfolioItemMenuDetailsCompany { get; set; }

        public string MasterPortfolioItemMenuDetailsUrlCompany { get; set; }

        public string MasterPortfolioItemMenuDetailsProjectFeatures { get; set; }

        public string MasterPortfolioItemMenuDetailsTechnologiesUsed { get; set; }

        public string MasterPortfolioItemMenuDetailsDescription1 { get; set; }

        public string MasterPortfolioItemMenuDetailsDescription2 { get; set; }

        public string MasterPortfolioItemMenuDetailsActiveUsers { get; set; }

        public string MasterPortfolioItemMenuDetailsClientSatisfaction { get; set; }

        public string MasterPortfolioItemMenuDetailsMonthsDevelopment { get; set; }

        public string MasterPortfolioItemMenuDetailsAppStoreRating { get; set; }

        public string MasterPortfolioItemMenuDetailsTheChallenge { get; set; }
        
        public string MasterPortfolioItemMenuDetailsTheSolution { get; set; }

        public string MasterPortfolioItemMenuDetailsFeatures1 { get; set; }

        public string MasterPortfolioItemMenuDetailsFeatures2 { get; set; }

        public string MasterPortfolioItemMenuDetailsFeatures3 { get; set; }
    }
}
