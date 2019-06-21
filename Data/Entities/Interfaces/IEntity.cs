using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroAPI.Data.Entities.Interfaces
{
    public interface IEntity<TId>
    {
        TId id { get; set; }
    }
}