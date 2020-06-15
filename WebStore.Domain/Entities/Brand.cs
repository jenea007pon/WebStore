using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.interfaces;

namespace WebStore.Domain.Entityies
{
    [Table("ProductBrand")]
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
