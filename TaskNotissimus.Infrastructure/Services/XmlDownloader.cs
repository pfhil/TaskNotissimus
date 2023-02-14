using System.Net;
using System.Text;
using System.Xml.Linq;
using TaskNotissimus.Application.Interfaces;

namespace TaskNotissimus.Infrastructure.Services
{
    public class XmlDownloader : IXmlDownloader
    {
        public async Task<XDocument> DownloadXml(Uri uri, Encoding? encoding = null)
        {
            if (encoding is null)
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                encoding = Encoding.GetEncoding("windows-1251");
            }

            using var webClient = new WebClient { Encoding = encoding };
            string xmlString = await webClient.DownloadStringTaskAsync(uri);
            return XDocument.Parse(xmlString);
        }
    }
}
