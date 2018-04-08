using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Easycomtec.Models
{
    [Table("InformationBank")]
    public class InformationBank
    {
        [Key]
        [ForeignKey("Canditates")]
        public int InformationBankID { get; set; }
        [Required]
        [Display(Name = "Only for Brazilians/ CPF:")]
        public string Cpf { get; set; }
        [Required]
        [Display(Name = "Bank/ Banco* ( Itau, Bradesco, ect..):")]
        public string BanK { get; set; }
        [Required]
        [Display(Name = "Agency /Agencia*:")]
        public string Agency { get; set; }
        [Required]
        [Display(Name = "Account Type/ Tipo de conta*:")]
        public string AccountType { get; set; }
        [Required]
        [Display(Name = "Account Number / Número da conta*:")]
        public string AccountNumber { get; set; }

        public virtual Candidates Canditates { get; set; }
    }
}