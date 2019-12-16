using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GroupChat.Notifications.Interfaces
{
    public interface INotificationService
    {
        ChannelReader<IEntityStateNotification<string>> Subscribe();
    }
}
