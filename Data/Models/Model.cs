using HeroAPI.Data.Models.Interfaces;

namespace HeroAPI.Data.Models
{
    public class Model<TId> : IViewModel<TId>
    {
        public TId Id { get; set; }
    }
}