using Core.RepositoryBase;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;
public interface IProductsDAL : IRepositoryBase<Product>
{
    void AddProduct(Product product);
}
