using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterFeaturesViewModel : BaseEntity
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
