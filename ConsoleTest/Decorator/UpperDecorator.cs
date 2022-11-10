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

        public void Send(string message)
        {
            Console.WriteLine();
        }

        public void ToUpper(string message)
        {
            message = message.ToUpper();
            decoratedNotification.Send(message);
        }

    }
}
