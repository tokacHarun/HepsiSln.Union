using HepsiSln.Application.Bases;

namespace HepsiSln.Application.Features.Products.Exceptions
{
    public class ProductTitleMustNotBeSameException : BaseExceptions
    {
        public ProductTitleMustNotBeSameException() : base("Ürün başlığı zaten var !")
        {

        }
    }
}
