using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Factory
{
    public interface INotificationFactory
    {
        List<INotification> Create();
    }
}
