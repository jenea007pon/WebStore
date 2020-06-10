using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.interfaces;

namespace WebStore.Domain.Entityies
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
