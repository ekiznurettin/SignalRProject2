﻿using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        int TTotalOrderCount();
        int TActiveOrderCount();
        int TPassiveOrderCount();
        decimal TLastOrderPrice();
        decimal TTodayTotalPrice();
    }
}
