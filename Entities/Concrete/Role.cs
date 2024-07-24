﻿using Shared.Entities.Abstarct;
using Shared.Entities.Abstract_Base_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Role:EntityBase,IEntity
    {
        public string Name { get; set; }
        //fk için
        public ICollection<User> Users { get; set; }
    }
}