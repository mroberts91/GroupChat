using GroupChat.ClientCore.Groups.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.ClientCore.Groups
{
    public class ChatGroup
    {
        private readonly EntityID _entityId;
        public ChatGroup(EntityID entityId)
        {
            _entityId = entityId;
        }
        public EntityID GroupID => _entityId;

    }
}
