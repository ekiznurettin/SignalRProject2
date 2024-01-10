﻿using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusApproved(int id);
        void TBookingStatusCanceled(int id);
    }
}
