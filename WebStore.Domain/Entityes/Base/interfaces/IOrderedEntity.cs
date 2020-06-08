namespace WebStore.Domain.Entityes.Base.interfaces
{
    public interface IOrderedEntity : IBaseEntity
    {
        int Order { get; set; }
    }
}

