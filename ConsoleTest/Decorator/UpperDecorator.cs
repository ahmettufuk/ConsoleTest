using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Decorator
{
    public class UpperDecorator : INotification
    {
        private readonly INotification decoratedNotification;

        public UpperDecorator(INotification decoratedNotification)
        {
            this.decoratedNotification = decoratedNotification;
        }

        public bool Send(NotificationModel model)
        {
            return decoratedNotification.Send(new NotificationModel { Message = model.Message.ToUpper()});
        }


    }
}
