using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterFeatureViewModel : BaseEntity
    {
        public int MasterFeatureId { get; set; }

        [DataType(DataType.Text)]
        public string MasterFeatureTitle { get; set; }

        [DataType(DataType.Text)]
        public string MasterFeatureBreef { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterFeatureDescription { get; set; }

        [DataType(DataType.Text)]
        public string MasterFeatureUrl { get; set; }

        [DataType(DataType.ImageUrl)]
        public string MasterFeatureImageUrl { get; set; }

        public IFormFile MasterFeatureFile { get; set; }
    }
}
