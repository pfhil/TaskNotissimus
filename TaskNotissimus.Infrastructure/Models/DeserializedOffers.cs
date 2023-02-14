using System.Xml.Serialization;

namespace TaskNotissimus.Infrastructure.Models
{
    [XmlRoot(ElementName = "offers")]
    public class DeserializedOffers
    {

        [XmlElement(ElementName = "offer")]
        public List<DeserializedOffer> Offer { get; set; }
    }
}
