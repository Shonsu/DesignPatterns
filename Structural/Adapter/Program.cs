using Adapter;

INotificationSender notificationSender = new EmailSender();
notificationSender.SendNotification(1, new Notification() { Title = "some email title", Body = "email body" });

notificationSender = new SmsSenderAdapter();

notificationSender.SendNotification(1, new Notification() { Title = "some email title", Body = "email body" });
