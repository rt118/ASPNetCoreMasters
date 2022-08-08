using Services;

namespace ASPNetCoreMastersTodoList.Api
{
    public static class ServiceExtension
    {
        public static void RegisterServices(this IServiceCollection collection)
        {
            collection.AddTransient<IItemService, ItemService>();
            //Add other repositories
        }
    }
}
