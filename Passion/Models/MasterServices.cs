using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterServices : BaseEntity
    {
        public int MasterServicesId { get; set; }

        public string MasterServicesIcon { get; set; }

        [DataType(DataType.Text)]
        public string MasterServicesTitle { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterServicesDescription { get; set; }

        public string MasterServicesUrl { get; set; }

        [DataType(DataType.Text)]
        public string MasterServicesDetailsList1 { get; set; }
        
        [DataType(DataType.Text)]
        public string MasterServicesDetailsList2 { get; set; }

        [DataType(DataType.Text)]
        public string MasterServicesDetailsNeedHelpDescription { get; set; }

        public string MasterServicesDetailsNeedHelpIconPhone { get; set; }

        [DataType(DataType.Text)]
        public string MasterServicesDetailsNeedHelpPhone { get; set; }

        public string MasterServicesDetailsNeedHelpIconEmail { get; set; }

        [DataType(DataType.EmailAddress)]
        public string MasterServicesDetailsNeedHelpEmail { get; set; }

        public string MasterServicesDetailsNeedHelpUrl { get; set; }

        public string MasterServicesDetailsTitleImageUrl { get; set; }

        [DataType(DataType.ImageUrl)]
        public string MasterServicesDetailsImageUrl { get; set; }

        [DataType(DataType.Text)]
        public string MasterServicesDetailsTitle { get; set; }

        [DataType(DataType.Text)]
        public string MasterServicesDetailsBreef { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterServicesDetailsDescriptionWhatYouWillGet { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterServicesDetailsDescriptionOurProcess { get; set; }
    }
}
