using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterMenuViewModel : BaseEntity
    {
        public int MasterMenuId { get; set; }

        [DataType(DataType.Text)]
        public string MasterMenuName { get; set; }

        public string MasterMenuUrl { get; set; }
    }
}
