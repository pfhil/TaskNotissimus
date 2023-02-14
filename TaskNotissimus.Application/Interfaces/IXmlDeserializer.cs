using System.Xml.Linq;

namespace TaskNotissimus.Application.Interfaces
{
    public interface IXmlDeserializer
    {
        T Deserialize<T>(XElement element);
    }
}
