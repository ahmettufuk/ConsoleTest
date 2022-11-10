using ConsoleTest;
using ConsoleTest.Constants;
using ConsoleTest.Facade;
using ConsoleTest.Factory;
using ConsoleTest.Model;
using ConsoleTest.Strategy;
using System.Reflection.Metadata;




var notificationSender = new NotificationFacade(new NotificationSender(new NotificationFactory()));
notificationSender.SendNotification(new NotificationModel(){ SenderTypeEnum= SenderTypeEnum.Mail,Message = "Error!!"});



//var sms = new SmsSender();
//var mail = new MailSender();
//var push = new PushSender();
//sms.Send("Error!!");
//mail.Send("Error!!");
//push.Send("Error!!");