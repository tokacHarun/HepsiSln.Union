using HepsiSln.Application.Bases;
using HepsiSln.Application.Features.Products.Exceptions;
using HepsiSln.Domain.Entities;

namespace HepsiSln.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products, string requestTitle)
        {
            if (products.Any(x => x.Title == requestTitle))
                throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;

        }
    }
}
