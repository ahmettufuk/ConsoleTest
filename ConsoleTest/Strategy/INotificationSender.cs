using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Strategy
{
    public interface INotificationSender
    {
        void Send(NotificationModel model);
    }
}
