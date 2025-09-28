using Passion.Models;
using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class MasterHowWeWorkViewModel : BaseEntity
    {
        public int MasterHowWeWorkId { get; set; }

        [DataType(DataType.Text)]
        public string MasterHowWeWorkIcon { get; set; }

        [DataType(DataType.Text)]
        public string MasterHowWeWorkTitle { get; set; }

        [DataType(DataType.Text)]
        public string MasterHowWeWorkBreef { get; set; }

        [DataType(DataType.Text)]
        public string MasterHowWeWorkDescription { get; set; }
    }
}
