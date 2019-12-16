using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.Notifications.Messages
{
    public interface IEntityStateNotification<TKey>
    {
        TKey EntityIdentifier { get; }
        bool ValidState { get; }
    }
}
