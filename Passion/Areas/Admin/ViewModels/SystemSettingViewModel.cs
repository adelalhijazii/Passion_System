using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class SystemSettingViewModel : BaseEntity
    {
        public int SystemSettingId { get; set; }

        public string SystemSettingLogoImageUrl { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingWelcomeNoteTitle { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingWelcomeNoteBreef { get; set; }

        [DataType(DataType.MultilineText)]
        public string SystemSettingWelcomeNoteDescription { get; set; }

        [DataType(DataType.ImageUrl)]
        public string SystemSettingWelcomeNoteImageUrl { get; set; }

        public IFormFile SystemSettingWelcomeNoteImageUrlFile { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingServicesUrl { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingEmail { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingPhoneNumber { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingProjectsCompleted { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingClientSatisfaction { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingSupportAvailable { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingSecureAndReliable { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingHighPerformance { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingExpertTeam { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAwardWinning { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingCopyright { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAboutTitle { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAboutBreef { get; set; }

        [DataType(DataType.MultilineText)]
        public string SystemSettingAboutDescription1 { get; set; }

        [DataType(DataType.MultilineText)]
        public string SystemSettingAboutDescription2 { get; set; }

        [DataType(DataType.ImageUrl)]
        public string SystemSettingAboutImageUrl { get; set; }

        public IFormFile SystemSettingAboutImageUrlFile { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAboutAwardIcon { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAboutAwardTitle { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAboutYearsExperience { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAboutProjectsCompleted { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAboutTeamMembers { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAboutPortfolioUrl { get; set; }

        [DataType(DataType.Text)]
        public string SystemSettingAboutTeamUrl { get; set; }
    }
}
