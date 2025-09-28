using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterService : BaseEntity
    {
        public int MasterServiceId { get; set; }

        [DataType(DataType.Text)]
        public string MasterServiceProjectsCompleted { get; set; }

        [DataType(DataType.Text)]
        public string MasterServiceClientSatisfaction { get; set; }

        [DataType(DataType.Text)]
        public string MasterServiceSupportAvailable { get; set; }

        [DataType(DataType.Text)]
        public string MasterServiceYearsExperience { get; set; }
    }
}
