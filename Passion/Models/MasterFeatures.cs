using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterFeatures : BaseEntity
    {
        public int MasterFeaturesId { get; set; }

        [DataType(DataType.Text)]
        public string MasterFeaturesIcon { get; set; }

        [DataType(DataType.Text)]
        public string MasterFeaturesTitle { get; set; }

        [DataType(DataType.Text)]
        public string MasterFeaturesBreef { get; set; }

        [DataType(DataType.Text)]
        public string MasterFeaturesNumber { get; set; }
    }
}
