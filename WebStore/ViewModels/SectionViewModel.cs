using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Base.interfaces;

namespace WebStore.ViewModels
{
    public class SectionViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public List<SectionViewModel> ChildSections { get; set; } = new List<SectionViewModel>();

    }
    public class BrandViewModel:INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }
    }
}
