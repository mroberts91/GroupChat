using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace GroupChat.Notifications.Interfaces
{
    public interface INotificationService<TMessage>
    {
        Channel<TMessage> NotificationChannel { get; }
    }
}
