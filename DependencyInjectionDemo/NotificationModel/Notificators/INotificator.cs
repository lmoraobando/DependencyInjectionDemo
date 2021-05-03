using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo.NotificationModel.Notificators
{
    interface INotificator
    {
        void SendNotification(string message);
    }
}
