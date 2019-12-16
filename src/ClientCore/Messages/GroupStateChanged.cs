using GroupChat.ClientCore.Groups.ValueObjects;
using GroupChat.Notifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.ClientCore.Messages
{
    public class GroupStateChanged : IEntityStateNotification<EntityID>
    {
        private readonly EntityID _entityId;
        private readonly bool   _validState;
        public GroupStateChanged(string entityId)
        {
            EntityID.TryParse(entityId, out _entityId);
            _validState = entityId != null && EntityID.IsValid(_entityId);
        }
        public EntityID EntityIdentifier => _entityId;

        public bool ValidState => _validState;
    }
}
