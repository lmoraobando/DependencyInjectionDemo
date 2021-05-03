using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo.NotificationModel.Notificators
{
    class NotificateToDB : INotificator
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"sending data to DB { message }");
        }
    }
}
