namespace Adapter;

public class SmsSenderAdapter : INotificationSender
{
    private SmsSender smsSender = new SmsSender();
    public void SendNotification(int userId, Notification notification)
    {
        //i.e. by userid get phone number from database
        string userPhoneNumber = "sume number";

        smsSender.SendSms(userPhoneNumber, $"{notification.Title} {notification.Body}");
    }
}
