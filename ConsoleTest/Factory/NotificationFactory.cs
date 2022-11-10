using ConsoleTest.ChainOfResponsibility;
using ConsoleTest.Decorator;
using ConsoleTest.Model;
using ConsoleTest.Strategy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Factory
{
    public class NotificationFactory : INotificationFactory
    {
        //public List<INotification> Create()
        //{
            
        //    return new List<INotification>()
        //    {
        //        { new MultipleDecorator(new ReverseDecorator(new UpperDecorator(new MailSender())),3)},
        //        { new MultipleDecorator(new SmsSender(),4) },
        //        { new MultipleDecorator(new PushSender(),2)}
                
        //    };


        //    //return new List<INotification>()
        //    //{
        //    //    { new UpperDecorator(new MailSender())},
        //    //    { new ReverseDecorator( new SmsSender()) },
        //    //    { new UpperDecorator( new ReverseDecorator( new ReverseDecorator( new UpperDecorator(new PushSender()))))},

        //    //};





        //}

        public IDictionary<SenderTypeEnum, INotification>  Create()
        {
            return new Dictionary<SenderTypeEnum, INotification>()
            {
                { SenderTypeEnum.Mail, new NotificationChainDecorator( new NotificationChainDecorator(new ReverseDecorator(new MailSender()),new UpperDecorator( new SmsSender())), new ReverseDecorator(new UpperDecorator(new PushSender())) )},
                //{ SenderTypeEnum.SMS ,new MultipleDecorator(new SmsSender(),4)  },
                //{ SenderTypeEnum.PUSH ,new MultipleDecorator(new PushSender(),2) }
            };
        }
    }
}
