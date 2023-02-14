using AutoMapper;
using System.Xml.Linq;
using TaskNotissimus.Application.Interfaces;
using TaskNotissimus.Domain;
using TaskNotissimus.Infrastructure.Models;

namespace TaskNotissimus.Infrastructure.Services
{
    public class OfferService : IOfferService
    {
        private readonly IXmlDeserializer _deserializer;
        private readonly IXmlDownloader _downloader;
        private readonly IMapper _mapper;

        public OfferService(IXmlDeserializer serializer, IXmlDownloader downloader, IMapper mapper)
        {
            _deserializer = serializer;
            _downloader = downloader;
            _mapper = mapper;
        }

        public async Task<List<Offer>> GetOffersFromXmlInWeb(Uri uri)
        {
            XDocument doc = await _downloader.DownloadXml(uri);
            XElement offersElement = doc.Element("yml_catalog").Element("shop").Element("offers");
            var deserializerOffers = _deserializer.Deserialize<DeserializedOffers>(offersElement).Offer;
            return deserializerOffers.Select(deserializerOffers => _mapper.Map<Offer>(deserializerOffers)).ToList();
        }
    }
}
