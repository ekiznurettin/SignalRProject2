﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.SignalR;

namespace WebAPI.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IMenuTableService _menuTableService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;


        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IMenuTableService menuTableService, IBookingService bookingService, INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _menuTableService = menuTableService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }
        public static int clientCount { get; set; } = 0;

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

            var totalProductCountByElektronik = _productService.TGetProductCountByCategoryName("Elektronik");
            await Clients.All.SendAsync("ReceiveProductCountByElektronik", totalProductCountByElektronik);

            var totalProductCountByGiyim = _productService.TGetProductCountByCategoryName("Giyim");
            await Clients.All.SendAsync("ReceiveProductCountByGiyim", totalProductCountByGiyim);

            var totalProductAvgPrice = _productService.TGetProductAvgPrice();
            await Clients.All.SendAsync("ReceiveProductAvgPrice", totalProductAvgPrice.ToString("0.00") + " TL");

            var productNameByMaxPrice = _productService.TGetProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", productNameByMaxPrice);

            var productNameByMinPrice = _productService.TGetProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", productNameByMinPrice);

            var totalOrderCount = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", totalOrderCount);

            var activeOrderCount = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeOrderCount);

            var passiveOrderCount = _orderService.TPassiveOrderCount();
            await Clients.All.SendAsync("ReceivePassiveOrderCount", passiveOrderCount);

            var lastOrderPrice = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", lastOrderPrice.ToString("0.00") + " TL");

            var totalMoneyCaseAmount = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", totalMoneyCaseAmount.ToString("0.00") + " TL");

            var todayTotalPrice = _orderService.TTodayTotalPrice();
            await Clients.All.SendAsync("ReceiveTodayTotalPrice", todayTotalPrice.ToString("0.00") + " TL");
        }

        public async Task SendProgress()
        {
            var totalMoneyCaseAmount = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", totalMoneyCaseAmount.ToString("0.00") + " TL");

            var activeOrderCount = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeOrderCount);

            var menuTableCount = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", menuTableCount);
        }
        public async Task GetBookingList()
        {
            var values = _bookingService.TGetAll();
            await Clients.All.SendAsync("ReceiveBookingList", values);
        }
        public async Task SendNotification()
        {
            var count = _notificationService.TNotificationCountByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationsCountByFalse", count);

            var notifications = _notificationService.TNotificationByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotifications", notifications);
        }

        public async Task SendMenuTableStatus()
        {
            var values = _menuTableService.TGetAll();
            await Clients.All.SendAsync("ReceiveMenuTableStatus", values);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public override async Task OnConnectedAsync()
        {
            clientCount++;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            clientCount--;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
