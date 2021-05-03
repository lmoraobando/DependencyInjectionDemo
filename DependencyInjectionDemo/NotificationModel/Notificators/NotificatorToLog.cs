using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo.NotificationModel.Notificators
{
    class NotificatorToLog : INotificator
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending notification to Log {message}");
        }
    }
}
