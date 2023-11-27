using BusinessLayer.Abstract;
using Microsoft.AspNetCore.SignalR;

namespace WebAPI.Hubs
{
    public class SignalRHub:Hub
	{
		private readonly ICategoryService _categoryService;
		private readonly IProductService _productService;

        public SignalRHub(ICategoryService categoryService, IProductService productService) 
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public async Task SendStatistic()
		{
			var totalCountCount = _categoryService.TGetCategoryCount();
			await Clients.All.SendAsync("ReceiveCategoryCount", totalCountCount);

            var totalProductCount = _productService.TGetProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", totalProductCount);

            var totalActiveCategoryCount = _categoryService.TGetActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", totalActiveCategoryCount);

            var totalPassiveCategoryCount = _categoryService.TGetPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", totalPassiveCategoryCount);

            var totalProductPriceByElektronik = _productService.TGetProductPriceByElektronik();
            await Clients.All.SendAsync("ReceiveProductPriceByElektronik", totalProductPriceByElektronik);

            var totalProductCountByElektronik= _productService.TGetProductCountByCategoryName("Elektronik");
            await Clients.All.SendAsync("ReceiveProductCountByElektronik", totalProductCountByElektronik);

            var totalProductCountByGiyim= _productService.TGetProductCountByCategoryName("Giyim");
            await Clients.All.SendAsync("ReceiveProductCountByGiyim", totalProductCountByGiyim);
        }
       
    }
}
