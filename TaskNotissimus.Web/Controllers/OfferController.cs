using Microsoft.AspNetCore.Mvc;
using TaskNotissimus.Application.Offers.Commands.CreateOfferById;
using TaskNotissimus.Application.Offers.Queries.GetOfferDetails;

namespace TaskNotissimus.Web.Controllers
{
    public class OfferController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateById(int id)
        {
            var command = new CreateOfferByIdCommand()
            {
                Id = id
            };
            await Mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> Get(int id)
        {
            var query = new GetOfferDetailsQuery()
            {
                Id = id
            };
            var vm = await Mediator.Send(query);
            return Json(vm);
        }
    }
}
