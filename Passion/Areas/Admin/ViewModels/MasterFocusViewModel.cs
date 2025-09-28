using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterFocusViewModel : BaseEntity
    {
        public int MasterFocusId { get; set; }

        [DataType(DataType.Text)]
        public string MasterFocusTitle { get; set; }

        [DataType(DataType.Text)]
        public string MasterFocusBreef { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterFocusDescription { get; set; }

        public string MasterFocusQuickSetupIcon { get; set; }

        public string MasterFocusQuickSetupDescription { get; set; }

        public string MasterFocusFullSecurityIcon { get; set; }

        public string MasterFocusFullSecurityDescription { get; set; }

        public string MasterFocusUrl { get; set; }

        public string MasterFocusMoneyBack { get; set; }

        public string MasterFocusRatingIcon { get; set; }

        public string MasterFocusRating { get; set; }

        public string MasterFocusUsersIcon { get; set; }

        public string MasterFocusUsers { get; set; }

        [DataType(DataType.ImageUrl)]
        public string MasterFocusImageUrl { get; set; }

        public IFormFile MasterFocusFile { get; set; }
    }
}
