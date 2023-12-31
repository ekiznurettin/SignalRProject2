﻿using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IOrderDal : IGenericDal<Order>
    {
        int TotalOrderCount();
        int ActiveOrderCount();
        int PassiveOrderCount();
        decimal LastOrderPrice();
        decimal TodayTotalPrice();
    }
}
