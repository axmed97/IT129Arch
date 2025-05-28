using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;
public class EfProductDAL : EfRepositoryBase<Product, AppDbContext>, IProductsDAL
{
    public void AddProduct(Product product)
    {
        using AppDbContext context = new();

        context.Products.Add(product);
        context.SaveChanges();
    }
}
