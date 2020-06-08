namespace WebStore.Domain.Entityes.Base.interfaces
{
    public interface INamedEntity : IBaseEntity
    {
        string Name { get; set; }
    }
}

