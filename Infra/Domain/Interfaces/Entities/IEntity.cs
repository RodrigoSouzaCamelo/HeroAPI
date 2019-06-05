using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroAPI.Infra.Domain.Interfaces.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
