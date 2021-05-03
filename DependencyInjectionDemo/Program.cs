using DependencyInjectionDemo.NotificationModel.Notificators;
using System;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificateToDB notificateToDB = new NotificateToDB();
            NotificationOperator notificationOperator = new NotificationOperator(notificateToDB);
            notificationOperator.SendNotification("Hola mundo");


        }
    }
}
