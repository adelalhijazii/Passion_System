using System.ComponentModel.DataAnnotations;

namespace Passion.Models
{
    public class MasterQuestions : BaseEntity
    {
        public int MasterQuestionsId { get; set; }

        [DataType(DataType.Text)]
        public string MasterQuestionsIcon { get; set; }
        
        [DataType(DataType.Text)]
        public string MasterQuestionsTitle { get; set; }

        [DataType(DataType.MultilineText)]
        public string MasterQuestionsDescription { get; set; }
    }
}
