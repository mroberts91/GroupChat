using System;
using System.Collections.Generic;
using System.Text;
using GroupChat.ClientCore.Groups.ValueObjects;
using GroupChat.ClientCore.Messages;
using Shouldly;
using Xunit;

namespace GroupChat.ClientCore.Tests.Unit.Notification
{
    public class NotificationTests
    {

        [Fact]
        public void GroupStateChanged_ValidState()
        {
            EntityID.TryParse("entityId", out EntityID validId);
            var message = new GroupStateChanged(validId);
            message.ValidState.ShouldBeTrue();
        }
    }
}
