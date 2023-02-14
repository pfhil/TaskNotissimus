using TaskNotissimus.Application.Interfaces;

namespace TaskNotissimus.Infrastructure.Services
{
    public class UriService : IUriService
    {
        public Uri XmlUri => new Uri("https://yastatic.net/market-export/_/partner/help/YML.xml");
    }
}
