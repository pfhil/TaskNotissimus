using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using TaskNotissimus.Application.Common.Exceptions;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Application.Offers.Queries.GetOfferDetails
{
    public class GetOfferDetailsQueryHandler : IRequestHandler<GetOfferDetailsQuery, OfferVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetOfferDetailsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OfferVm> Handle(GetOfferDetailsQuery request, CancellationToken cancellationToken)
        {
            var offer = await _context.Offers.Include(e => e.DataTour).Include(e => e.CategoryId).Include(e => e.Hall).FirstOrDefaultAsync(offer => offer.Id == request.Id, cancellationToken);

            if (offer == null)
            {
                throw new NotFoundException(nameof(Offer), request.Id);
            }

            return _mapper.Map<OfferVm>(offer);
        }
    }
}
