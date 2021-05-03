using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo.NotificationModel.Notificators
{
    class NotificatorToEmail : INotificator
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending notification to Email {message}");
        }
    }
}
