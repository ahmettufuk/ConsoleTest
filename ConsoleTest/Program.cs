using ConsoleTest;
using ConsoleTest.Concrete;
using ConsoleTest.Constants;
using ConsoleTest.Facade;
using ConsoleTest.Factory;
using System.Reflection.Metadata;


var notificationSender = new NotificationFacade(new NotificationFactory());
notificationSender.SendNotification("Error!!!");



//var sms = new SmsSender();
//var mail = new MailSender();
//var push = new PushSender();
//sms.Send("Error!!");
//mail.Send("Error!!");
//push.Send("Error!!");