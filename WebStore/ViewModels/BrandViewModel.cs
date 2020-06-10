using WebStore.Domain.Entities.Base.interfaces;

namespace WebStore.ViewModels
{
    public class BrandViewModel:INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }
    }
}
