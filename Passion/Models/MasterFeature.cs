using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Passion.Models
{
    public class MasterFeature : BaseEntity
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
    }
}
