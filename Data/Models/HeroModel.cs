using HeroAPI.Data.Models.Interfaces;

namespace HeroAPI.Data.Models
{
    public class HeroModel : Model<int>, IHeroModel
    {
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