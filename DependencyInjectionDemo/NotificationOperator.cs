using DependencyInjectionDemo.NotificationModel.Notificators;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    class NotificationOperator
    {
        private INotificator _notificator;

        public NotificationOperator(INotificator notificator) {
            this._notificator = notificator;
        }

        public void SendNotification(string message) {
            _notificator.SendNotification(message);
        }

    }
}
