using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterAboutUs : BaseEntity
    {
        public int MasterAboutUsId { get; set; }

        [DataType(DataType.Text)]
        public string MasterAboutUsTitle { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterAboutUsDescription { get; set; }
    }
}
