using MessageServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.Notifications.Interfaces
{
    public interface IEntityNotificationDataStream
    {
        IAsyncEnumerable<EntityIdentifier> ReadAllAsync(string entityId);
    }
}
