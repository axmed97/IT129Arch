using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SOLID
// Single Reponsibilty
// Open Close
namespace Business.Concrete;
public class ProductManager : IProductService
{
    private readonly IProductsDAL _productsDAL;

    public ProductManager(IProductsDAL productsDAL)
    {
        _productsDAL = productsDAL;
    }

    public void Create(Product product)
    {
        _productsDAL.Add(product);
    }
}
