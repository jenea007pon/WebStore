namespace WebStore.Domain.Entities.Base.interfaces
{
    public interface INamedEntity : IBaseEntity
    {
        string Name { get; set; }
    }
}

