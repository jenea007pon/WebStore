using WebStore.Domain.Entityes.Base.interfaces;

namespace WebStore.Domain.Entityes.Base
{
    public abstract class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }

}
