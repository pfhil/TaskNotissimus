using TaskNotissimus.Domain;

namespace TaskNotissimus.Application.Interfaces
{
    public interface IOfferService
    {
        public Task<List<Offer>> GetOffersFromXmlInWeb(Uri uri);
    }
}
