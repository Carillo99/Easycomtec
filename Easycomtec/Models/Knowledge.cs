using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Easycomtec.Models
{
    [Table("Knowledge")]
    public class Knowledge
    {
        [Key]
        [ForeignKey("Canditates")]
        public int KnowledgeID { get; set; }

        [Display(Name = "Ionic*:")]
        public int Ionic { get; set; }
        [Display(Name = "Android*:")]
        public int Android { get; set; }
        [Display(Name = "Ios*:")]
        public int Ios { get; set; }


        [Display(Name = "Majento*:")]
        public int Majento { get; set; }
        [Display(Name = "WordPress*:")]
        public int WordPress { get; set; }
        [Display(Name = "HTML5*:")]
        public int Html { get; set; }
        [Display(Name = "CSS3*:")]
        public int Css { get; set; }
        [Display(Name = "Bootstrap*:")]
        public int Bootstrap { get; set; }

        [Display(Name = "Django*:")]
        public int Django { get; set; }
        [Display(Name = "Jquery*:")]
        public int Jquery { get; set; }
        [Display(Name = "Angular*:")]
        public int Angular { get; set; }
        [Display(Name = "Vue*: ")]
        public int Vue { get; set; }

        [Display(Name = "SQL Server*:")]
        public int SqlServer { get; set; }
        [Display(Name = "MySQL*:")]
        public int MySql { get; set; }
        [Display(Name = "Java*:")]
        public int Java { get; set; }
        [Display(Name = "Python*:")]
        public int Phyton { get; set; }
        [Display(Name = "Cake*:")]
        public int Cake { get; set; }
        [Display(Name = "PHP*:")]
        public int Php { get; set; }
        [Display(Name = "Asp .Net Mvc")]
        public int AspNetMvc { get; set; }
        [Display(Name = "Ruby on Rails*:")]
        public int Ruby { get; set; }

        [Display(Name = "C*:")]
        public int C { get; set; }
        [Display(Name = "C++")]
        public int C_ { get; set; }



        [Display(Name = "Photoshop*:")]
        public int Photoshop { get; set; }
        [Display(Name = "Illustraitor*:")]
        public int Illustraitor { get; set; }


        [Display(Name = "Salesforce*:")]
        public int Salesforce { get; set; }
        [Display(Name = "Seo*:")]
        public int Seo { get; set; }

        [Display(Name = "Other Language")]
        public string OtherLanguage { get; set; }

        [Display(Name = "Link CRUD*:")]
        public string Crud { get; set; }

        public virtual Candidates Canditates { get; set; }

    }
}