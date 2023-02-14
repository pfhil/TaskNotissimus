using MediatR;

namespace TaskNotissimus.Application.Offers.Commands.CreateOfferById
{
    public class CreateOfferByIdCommand : IRequest
    {
        public int Id { get; set; }
    }
}
