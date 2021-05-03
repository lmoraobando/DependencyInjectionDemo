using DependencyInjectionDemo.NotificationModel.Notificators;
using System;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificateToDB notificateToDB = new NotificateToDB();
            NotificatorToEmail notificatorToEmail = new NotificatorToEmail();


            NotificationOperator notificationOperator = new NotificationOperator(notificateToDB);
            notificationOperator.SendNotification("Hola mundo");

            NotificationOperator notificationOperator1 = new NotificationOperator(notificatorToEmail);
            notificationOperator1.SendNotification("Hola mundo 2");



        }
    }
}
