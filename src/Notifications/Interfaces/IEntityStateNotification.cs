using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.Notifications.Interfaces
{
    public interface IEntityStateNotification<TKey>
    {
        TKey EntityIdentifier { get; }
        bool ValidState { get; }
    }
}
