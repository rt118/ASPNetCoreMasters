namespace Services
{
    public class ItemService : IItemService
    {
        public IEnumerable<string> GetAll() {
          return new List<string>() {  
            "String 1",
            "String 2",
            "String 3", 
            }; 
        }
    }
}