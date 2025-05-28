
using Core.Entities.Abstract;
using Entities.Common;

namespace Entities.Concrete;
public class Product : BaseEntity
{
    public decimal Price { get; set; }
    public decimal? Discount { get; set; }
    public List<ProductPhoto> ProductPhotos { get; set; }
    public List<ProductLanguage> ProductLanguages { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
