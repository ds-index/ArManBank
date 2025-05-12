//ArMan DS
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArManBank.Domain
{
    public class User : IUser
    {
        [Key]
        [DisplayName("User Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First name")]
        public string? FirstName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        [DisplayName("Last name")]
        public string? LastName { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Account Balance")]
        public decimal? Balance { get; set; }

        [DisplayName("Account Type")]
        public TypeOfBalance TypeOfBalance { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayName("Created Data")]
        public DateTime CreateDate { get; set; }
    }
}
