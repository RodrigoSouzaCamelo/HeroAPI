using HeroAPI.Data.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroAPI.Data.Entities
{
    public class Entity<TId> : IEntity<TId>
    //where TId : struct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TId id { get; set; }
    }
}