using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroAPI.Models
{
    [Table("Heroes", Schema = "HeroAPI")] 
    public class Hero
    {
        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        
        [Required]  
        [Column(TypeName = "varchar(200)")]  
        public string OwnName { get; set; }
        
        [Required]  
        [Column(TypeName = "varchar(200)")]  
        public string HeroName { get; set; }
        
        [Required]  
        [Column(TypeName = "enum('Male', 'Female')")]  
        public string Gender { get; set; }
        
        [Required]  
        [Column(TypeName = "varchar(200)")]  
        public string Powers { get; set; }
        
        [Required]  
        [Column(TypeName = "varchar(200)")]  
        public string Universe { get; set; }
        
        [Required]  
        [Column(TypeName = "varchar(200)")]  
        public string Team { get; set; }
        
        [Required]  
        [Column(TypeName = "int(11)")]  
        public int Classification { get; set; }
        
        [Required]  
        [Column(TypeName = "longtext")]  
        public string Description { get; set; }

    }
}