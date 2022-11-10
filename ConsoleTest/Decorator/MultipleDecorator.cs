using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Decorator
{
    public class MultipleDecorator : INotification
    {
        private readonly INotification decoratedNotification;
        private readonly int times;

        public MultipleDecorator(INotification decoratedNotification,int times)
        {
            this.decoratedNotification = decoratedNotification;
            this.times = times;
        }
        public bool Send(NotificationModel model)
        {
            
               return decoratedNotification.Send(model);
            

        }
    }
}
