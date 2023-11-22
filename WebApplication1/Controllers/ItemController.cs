using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    { 

        private readonly IItemService _itemService; 
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
                       
        }
        [HttpGet]
        public ActionResult<List<Item>> GetAll() =>_itemService.GetAll();


        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            Item a = _itemService.Get(id);
            if (a == null)
            {
                return NotFound();
            }
            else
            {
                return a;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Item> Delete(int id)
        {    Item a = _itemService.Get(id);
             _itemService.Delete(id);
             return a;
        }

        [HttpPost]
        public ActionResult<Item> Add(Item a) { 
           Item b= _itemService.Add(a);        
            return b; }

        [HttpPut]
        public ActionResult<Item> Update(Item a) { 
            Item b= _itemService.Update(a);
            return b;
            
        }

    }
}
