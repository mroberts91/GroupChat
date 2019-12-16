using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Shouldly;
using Xunit;

namespace GroupChat.ClientCore.Tests.Integration
{
    public class NotificationTests : IDisposable
    {

        [Fact]
        public async Task RecieveNotificationAsync()
        {
            var foo = true;
            var test = await Task.FromResult(foo);
            test.ShouldBeTrue();
        }
        public void Dispose()
        {
            Console.WriteLine();
        }
    }
}
