using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Easycomtec.Models
{
    [Table("OccupationArea")]
    public class OccupationArea
    {
        [Key]
        [ForeignKey("Canditates")]
        public int OccupationAreaID { get; set; }
        [Required]
        [Display(Name = "Nome/ Name*:")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Skype* ( please create an account if you don't have yet / bom criar caso não tenha):")]
        public string Skype { get; set; }
        [Required]
        [Display(Name = "Linkedin:")]
        public string Linkedin { get; set; }
        [Required]
        [Display(Name = "Cidade/ City*:")]
        public string Cyte { get; set; }
        [Required]
        [Display(Name = "Estado/ State*:")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Portfolio/ Github*:")]
        public string Portfolio { get; set; }
        [Required]
        [Display(Name = "What is your willingness to work today? / Qual é sua disponibilidade para trabalhar hoje?")]
        public string Willingness { get; set; }
        [Required]
        [Display(Name = "What's the best time to work for you? / Pra você qual é o melhor horário para trabalhar?")]
        public string Horary { get; set; }
        [Required]
        [Display(Name = "What is your hourly salary requirements? / Qual sua pretensão salarial por hora?")]
        public decimal Salary { get; set; }

        public virtual Candidates Canditates { get; set; }
    }
}