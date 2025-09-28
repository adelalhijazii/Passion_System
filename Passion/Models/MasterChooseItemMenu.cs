using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterChooseItemMenu : BaseEntity
    {
        public int MasterChooseItemMenuId { get; set; }

        public int MasterChooseCategoryId { get; set; }

        [DataType(DataType.Text)]
        public string MasterChooseItemMenuTitle { get; set; }

        [DataType(DataType.Text)]
        public string MasterChooseItemMenuBreef { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterChooseItemMenuDescription { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterChooseItemMenuList { get; set; }
        
        [DataType(DataType.ImageUrl)]
        public string MasterChooseItemMenuImageUrl { get; set; }

        public MasterChooseCategory MasterChooseCategory { get; set; }
    }
}
