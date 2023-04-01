using Api.FreeSide.Business.Model.Item;
using Api.FreeSide.Business.Model.User;
using Api.FreeSide.Business.Service.Contact;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Free_Side_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller

    {
        private readonly IServiceItem _serviceItem;
        public ItemController(IServiceItem serviceItem)
        {
            _serviceItem = serviceItem;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<ItemReadDTO>), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> ItemListAsync()
        {
            var item = await _serviceItem.GetListItemAsync().ConfigureAwait(false);

            return Ok(item);
        }
    }

}
