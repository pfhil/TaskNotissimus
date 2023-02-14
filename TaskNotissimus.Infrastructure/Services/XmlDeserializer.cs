using System.Xml.Linq;
using System.Xml.Serialization;
using TaskNotissimus.Application.Interfaces;

namespace TaskNotissimus.Infrastructure.Services
{
    public class XmlDeserializer : IXmlDeserializer
    {
        public T Deserialize<T>(XElement element)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using StringReader reader = new StringReader(element.ToString());
            return (T)serializer.Deserialize(reader);
        }
    }
}
