using System;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Base.interfaces;

namespace WebStore.ViewModels
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
