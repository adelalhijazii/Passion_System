using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterChooseCategoryViewModel : BaseEntity
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
