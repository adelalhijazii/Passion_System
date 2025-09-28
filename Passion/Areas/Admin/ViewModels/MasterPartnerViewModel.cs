using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterPartnerViewModel : BaseEntity
    {
        public int MasterPartnerId { get; set; }

        [DataType(DataType.ImageUrl)]
        public string MasterPartnerLogoImageUrl { get; set; }

        public IFormFile MasterPartnerFile { get; set; }

        [DataType(DataType.Url)]
        public string MasterPartnerWebsiteUrl { get; set; }
    }
}
