﻿using DAL_DataAccessLayer.EntityFramework.InterfaceRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.EntityFramework.Repositories
{
    public class CartItemRepository : EfEntityRepositoryBase<CartItem>, ICartItemRepository
    {
        public CartItemRepository(DbContext context) : base(context)
        {
        }
    }
}