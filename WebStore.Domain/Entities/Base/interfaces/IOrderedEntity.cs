namespace WebStore.Domain.Entities.Base.interfaces
{
    public interface IOrderedEntity : IBaseEntity
    {
        int Order { get; set; }
    }
}

