﻿using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entityes.Base.interfaces;

namespace WebStore.Domain.Entityes.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }

}
