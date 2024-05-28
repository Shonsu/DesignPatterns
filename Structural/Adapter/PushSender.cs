namespace Adapter;

public class PushSender : INotificationSender
{
    public void SendNotification(int userId, Notification notification)
    {
        System.Console.WriteLine($"Sending push notification to {userId}, Title: {notification.Title}, Body: {notification.Body}.");
    }
}
