using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using WebStore.Domain.Entityes.Base;
using WebStore.Domain.Entityes.Base.interfaces;

namespace WebStore.Domain.Entityes
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
