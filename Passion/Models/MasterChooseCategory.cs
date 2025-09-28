using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterChooseCategory : BaseEntity
    {
        public int MasterChooseCategoryId { get; set; }

        [DataType(DataType.Text)]
        public string MasterChooseCategoryIcon { get; set; }

        [DataType(DataType.Text)]
        public string MasterChooseCategoryTitle { get; set; }

        [DataType(DataType.Text)]
        public string MasterChooseCategoryBreef { get; set; }
    }
}
