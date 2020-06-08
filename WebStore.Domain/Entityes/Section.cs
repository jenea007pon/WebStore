using WebStore.Domain.Entityes.Base;
using WebStore.Domain.Entityes.Base.interfaces;

namespace WebStore.Domain.Entityes
{
    public class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        public int? ParentId { get; set; }
    }
}
