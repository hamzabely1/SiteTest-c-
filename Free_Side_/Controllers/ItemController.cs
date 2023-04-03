using Api.FreeSide.Business.Model.Item;
using Api.FreeSide.Business.Model.User;
using Api.FreeSide.Business.Service;
using Api.FreeSide.Business.Service.Contact;
using Api.FreeSide.Datas.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Free_Side_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller

    {

        /// <summary>
        /// get
        /// </summary>
        private readonly IServiceItem _serviceItem;
        public ItemController(IServiceItem serviceItem)
        {
            _serviceItem = serviceItem;
        }

        [HttpGet()]
        public async Task<ActionResult> Get()
        {
            List<ItemReadDTO> item = await _serviceItem.GetListItemAsync().ConfigureAwait(false);

            return Ok(item);
        }



        /// <summary>
        /// post
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        [ProducesResponseType(typeof(ItemReadDTO), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> Post(ItemAddDTO itemTooRead)
        {
            var item = await _serviceItem.CreateItemAsync(itemTooRead).ConfigureAwait(false);

            return Ok(item);
        }

        /// <summary>
        /// get un
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUn(int id)
        {
            ItemReadDTO item = await _serviceItem.GetUnItemAsync(id).ConfigureAwait(false);

            return Ok(item);
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            ItemReadDTO item = await _serviceItem.DeleteItemAsync(id).ConfigureAwait(false);

            return Ok(item);
        }


        /// <summary>
        /// update
        /// </summary>
        /// <returns></returns>
        ///    
        [HttpPatch()]
        [ProducesResponseType(typeof(ItemReadDTO), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> Update(ItemAddDTO itemTooRead)
        {
            var item = "up";

            return Ok(item);
        }


    }

}
