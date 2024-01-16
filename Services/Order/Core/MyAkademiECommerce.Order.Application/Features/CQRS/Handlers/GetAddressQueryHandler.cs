using MyAkademiECommerce.Order.Application.Interfaces;
using MyAkademiECommerce.Order.Domain.Entites;
using MyAkademiECommerce.Order.Application.Features.CQRS.Results;

namespace MyAkademiECommerce.Order.Application.Features.CQRS.Handlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;
        public GetAddressQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAddressQueryResult
            {
                AddressID = x.AddressID,
                City = x.City,
                Detail = x.Detail,
                District = x.District,
                UserID = x.UserID
            }).ToList();
        }
    }
}
