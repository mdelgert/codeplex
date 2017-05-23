﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace SelfHost
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return new List<Product> 
            {
                new Product() { Id = 1, Name = "Gizmo 1", Price = 1.99M },
                new Product() { Id = 2, Name = "Gizmo 2", Price = 2.99M },
                new Product() { Id = 3, Name = "Gizmo 3", Price = 3.99M }
            };
        }

        public Product GetProductById(int id)
        {
            if (id < 1 || id > 3)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return new Product()
            {
                Id = id,
                Name = "Gizmo " + id.ToString(),
                Price = id + 0.99M
            };
        }
    }
}
