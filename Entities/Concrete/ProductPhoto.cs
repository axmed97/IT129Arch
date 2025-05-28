using Core.Entities.Abstract;
using Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;
public class ProductPhoto : BaseEntity
{
    public string PhotoUrl { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
}
