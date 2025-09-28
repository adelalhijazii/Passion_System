using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterPricing : BaseEntity
    {
        public int MasterPricingId { get; set; }

        public string MasterPricingIcon { get; set; }

        [DataType(DataType.Text)]
        public string MasterPricingTitle { get; set; }

        [DataType(DataType.Text)]
        public string MasterPricingBreef { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterPricingDescription { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterPricingList { get; set; }

        public string MasterPricingUrl { get; set; }
    }
}
