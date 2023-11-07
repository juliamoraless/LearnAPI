namespace LearnAPI.Application.Notificator;

public interface INotificator
{
    bool HasNotification();
    List<Notification> GetNotifications();
    void Handle(Notification notification);
}