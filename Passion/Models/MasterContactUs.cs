using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterContactUs : BaseEntity
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
