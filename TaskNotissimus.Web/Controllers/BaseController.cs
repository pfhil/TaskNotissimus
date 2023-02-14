using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaskNotissimus.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IMediator Mediator => HttpContext.RequestServices.GetService<IMediator>();
    }
}
