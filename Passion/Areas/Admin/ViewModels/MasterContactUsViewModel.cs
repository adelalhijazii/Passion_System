using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterContactUsViewModel : BaseEntity
    {
        public int MasterContactUsId { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterContactUsDescription { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string MasterContactUsPhone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string MasterContactUsEmail { get; set; }
    }
}
