using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ItemService : IItemService
    {
        private readonly DataContext _context;

        public ItemService(DataContext context)
        {
            _context = context;
        }

        public List<Item> GetAll() => _context.Items.ToList();

        public Item Get(int id) => _context.Items.FirstOrDefault(p => p.Id == id);

        public Item Add(Item pizza)
        {
            _context.Items.Add(pizza);
            _context.SaveChanges();
            return pizza;
        }

        public void Delete(int id)
        {
            var pizza = Get(id);
            if (pizza != null)
            {
                _context.Items.Remove(pizza);
                _context.SaveChanges();
            }
        }

        public Item Update(Item pizza)
        {
            var existingPizza = _context.Items.Find(pizza.Id);
            if (existingPizza != null)
            {
                existingPizza.Name = pizza.Name;
                existingPizza.Price = pizza.Price;
                _context.SaveChanges();
            }
            return existingPizza;
        }
    }
}
