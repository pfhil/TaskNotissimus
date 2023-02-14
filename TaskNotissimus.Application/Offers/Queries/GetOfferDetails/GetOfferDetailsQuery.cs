using MediatR;

namespace TaskNotissimus.Application.Offers.Queries.GetOfferDetails
{
    public class GetOfferDetailsQuery : IRequest<OfferVm>
    {
        public int Id { get; set; }
    }
}
