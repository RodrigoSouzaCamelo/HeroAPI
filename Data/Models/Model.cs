using HeroAPI.Data.Models.Interfaces;

namespace HeroAPI.Data.Models
{
    public class Model<TId> : IViewModel<TId>
    //where TId : struct
    {
        public TId Id { get; set; }
    }
}