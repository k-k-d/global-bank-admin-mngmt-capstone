using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bank.Entities
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        [Required]
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }

    }
}
