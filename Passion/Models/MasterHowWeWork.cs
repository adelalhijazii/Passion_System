using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterHowWeWork : BaseEntity
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
