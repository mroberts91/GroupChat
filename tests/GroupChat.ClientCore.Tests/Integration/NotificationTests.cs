using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Castle.Core.Configuration;
using GroupChat.ClientCore.Interfaces;
using GroupChat.ClientCore.Services;
using GroupChat.Notifications.Interfaces;
using MessageServices;
using Microsoft.AspNetCore.Http;
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

        [Fact]
        public async Task RecieveNotificationStreamAsync()
        {
            var messages = new List<string>();
            var iterations = 10;
            Random random = new Random();
            var entityId = random.Next().ToString();
            var service = new NotificationService(new NotificationDataStream(){Iterations = iterations }, entityId);
            var reader = service.Subscribe();
            await foreach (var message in reader.ReadAllAsync())
            {
                messages.Add(message.EntityIdentifier);
                System.Diagnostics.Debug.WriteLine(message.EntityIdentifier);
            }

            messages.Count.ShouldBe(iterations);
            messages.All(m => m == entityId).ShouldBeTrue();
            
        }
        public void Dispose()
        {
            Console.WriteLine();
        }
    }

    internal class NotificationDataStream : IEntityNotificationDataStream
    {
        public int Iterations { get; set; }
        public async IAsyncEnumerable<EntityIdentifier> ReadAllAsync(string entityId)
        {
            for (int i = 0; i < Iterations; i++)
            {
                await Task.Delay(500);
                yield return new EntityIdentifier()
                {
                    EntityID = entityId
                };
            }       
        }
    }

    internal class NotificationService : INotificationService
    {
        private readonly Channel<IEntityStateNotification<string>> _notificationChannel;
        private readonly IEntityNotificationDataStream _dataStream;
        private readonly ChannelWriter<IEntityStateNotification<string>> writer;
        private readonly string _entityId;
        public NotificationService(IEntityNotificationDataStream dataStream, string entityId)
        {
            _entityId = entityId;
            _dataStream = dataStream;
            _notificationChannel = Channel.CreateUnbounded<IEntityStateNotification<string>>(new UnboundedChannelOptions
            {
                AllowSynchronousContinuations = true,
                SingleReader = true,
                SingleWriter = true
            });
            writer = _notificationChannel.Writer;
            InitStream();
        }
        private async Task InitStream()
        {
            await foreach (var update in _dataStream.ReadAllAsync(_entityId))
            {
                await writer.WriteAsync(new EntityNotificationMessage<string>
                {
                    EntityIdentifier = update.EntityID
                });
            }

            writer.Complete();
        }
        public ChannelReader<IEntityStateNotification<string>> Subscribe()
        {
            return _notificationChannel.Reader;
        }

        internal class EntityNotificationMessage<TKey> : IEntityStateNotification<TKey>
        {
            public TKey EntityIdentifier { get; set; }

            public bool ValidState => EntityIdentifier != null;
        }
    }
}
