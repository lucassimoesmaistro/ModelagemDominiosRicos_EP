﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
        //private readonly DomainNotificationHandler _notifications;
        //private readonly IMediatorHandler _mediatorHandler;

        protected Guid ClienteId = Guid.Parse("4885e451-b0e4-4490-b959-04fabc806d32");

        //protected ControllerBase(INotificationHandler<DomainNotification> notifications,
        //                         IMediatorHandler mediatorHandler)
        //{
        //    _notifications = (DomainNotificationHandler)notifications;
        //    _mediatorHandler = mediatorHandler;
        //}


    }
}
