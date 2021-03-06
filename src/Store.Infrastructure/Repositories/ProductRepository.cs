﻿using Store.Core.Entities;
using Store.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(StoreContext context):base(context)
        {

        }

        public Product GetById(int id)
        {
            Product product = this.Set.FirstOrDefault<Product>(x => x.ProductId == id);
            return product;
        }
    }
}
