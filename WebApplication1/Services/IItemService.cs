using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IItemService
    {
       
        List<Item> GetAll();
        Item? Get(int id);
        void Delete(int id);
        Item Update(Item item);
        Item Add(Item pizza);


    }
}
