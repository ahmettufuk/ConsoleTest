using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Decorator
{
    public class ReverseDecorator : INotification
    {
        private readonly INotification decoratedNotification;

        public ReverseDecorator(INotification decoratedNotification)
        {
            this.decoratedNotification = decoratedNotification;
        }


        private string Reverse(string message)
        {
            var charArray = message.ToCharArray();
            Array.Reverse(charArray);
           
            return new string(charArray);
            
        }

        public bool Send(NotificationModel model)
        {
            return decoratedNotification.Send(new NotificationModel() { Message = Reverse(model.Message)});
        }
    }
}
