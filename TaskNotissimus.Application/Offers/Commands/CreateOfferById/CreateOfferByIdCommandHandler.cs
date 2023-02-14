using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using TaskNotissimus.Application.Common.Exceptions;
using TaskNotissimus.Application.Interfaces;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Application.Offers.Commands.CreateOfferById
{
    public class CreateOfferByIdCommandHandler : IRequestHandler<CreateOfferByIdCommand, Unit>
    {
        private readonly IApplicationDbContext _context;
        private readonly IOfferService _offerService;
        private readonly IUriService _uriService;

        public CreateOfferByIdCommandHandler(IApplicationDbContext context, IOfferService offerService, IUriService uriService)
        {
            _context = context;
            _offerService = offerService;
            _uriService = uriService;
        }

        public async Task<Unit> Handle(CreateOfferByIdCommand request, CancellationToken cancellationToken)
        {
            var offer = await _context.Offers.FirstOrDefaultAsync(offer => offer.Id == request.Id, cancellationToken);
            if (offer == null)
            {
                offer = (await _offerService.GetOffersFromXmlInWeb(_uriService.XmlUri))
                    .FirstOrDefault(offer => offer.Id == request.Id);

                if (offer == null)
                {
                    throw new NotFoundException(nameof(Offer), request.Id);
                }

                await _context.Offers.AddAsync(offer, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
            }

            return Unit.Value;
        }
    }
}
