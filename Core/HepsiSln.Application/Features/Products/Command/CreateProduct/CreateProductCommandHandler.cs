using HepsiSln.Application.Interfaces.UnitOfWorks;
using HepsiSln.Domain.Entities;
using MediatR;

namespace HepsiSln.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = new(request.BrandId, request.Title, request.Description, request.Price, request.Discount);
            await unitOfWork.GetWriteRepository<Product>().AddAsync(product);

            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var categoryId in request.CategoryIdss)
                    await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        ProductId = product.Id,
                        CategoryId = categoryId
                    });

            }
        }
    }
}