using HeroAPI.Infra.Domain.Interfaces.Entities;

namespace HeroAPI.Domain.Entities
{
    public class Hero : IEntity
    {
        public int Id { get; set; }
        public string OwnName { get; set; }
        public string HeroName { get; set; }
        public string Gender { get; set; }
        public string Powers { get; set; }
        public string Universe { get; set; }
        public string Team { get; set; }
        public int Classification { get; set; }
        public string Description { get; set; }

    }
}