using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterAboutUsViewModel : BaseEntity
    {
        public int MasterAboutUsId { get; set; }

        [DataType(DataType.Text)]
        public string MasterAboutUsTitle { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterAboutUsDescription { get; set; }
    }
}
