using System.Net.Mail;

namespace Adapter;

public interface INotificationSender
{
    void SendNotification(int userId, Notification notification);
}
