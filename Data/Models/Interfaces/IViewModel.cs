namespace HeroAPI.Data.Models.Interfaces
{
    public interface IViewModel<TId>
    {
        TId Id { get; set; }
    }
}