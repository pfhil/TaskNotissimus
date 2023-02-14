using System.Text;
using System.Xml.Linq;

namespace TaskNotissimus.Application.Interfaces
{
    public interface IXmlDownloader
    {
        Task<XDocument> DownloadXml(Uri uri, Encoding? encoding = null);
    }
}
