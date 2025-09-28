using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterContactUsInformationViewModel : BaseEntity
    {
        public int MasterContactUsInformationId { get; set; }

        public string MasterContactUsInformationIcon { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterContactUsInformationDescription { get; set; }
    }
}
