namespace Adapter;

public class EmailSender : INotificationSender
{
    public void SendNotification(int userId, Notification notification)
    {
        System.Console.WriteLine($"Sending email notification to {userId}, Title: {notification.Title}, Body: {notification.Body}.");
    }
}
