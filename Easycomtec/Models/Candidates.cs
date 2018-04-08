using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Easycomtec.Models
{
    [Table("Candidates")]
    public class Candidates
    {
        [Key]
        public int CandidateID { get; set; }
        [Required]
        [Display(Name = "Email address *")]
        public string Email { get; set; }

        public virtual OccupationArea OccupationArea { get; set; }
        public virtual InformationBank InformationBank { get; set; }
        public virtual Knowledge Knowledge { get; set; }
    }
}