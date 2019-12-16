using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using GroupChat.Notifications.Interfaces;
using Grpc.Core;
using Grpc.Net.Client;
using MessageServices;

namespace GroupChat.Notifications.Services
{
    public class EntityNotificationService : INotificationService
    {
        private readonly Channel<IEntityStateNotification<string>> _notificationChannel;
        private readonly IEntityNotificationDataStream _dataStream;
        private readonly ChannelWriter<IEntityStateNotification<string>> writer;
        private readonly string _entityId;
        public EntityNotificationService(IEntityNotificationDataStream dataStream, string entityId)
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
        }
        
        public ChannelReader<IEntityStateNotification<string>> Subscribe()
        {
            return _notificationChannel.Reader;
        }
    }

    internal class EntityNotificationMessage<TKey> : IEntityStateNotification<TKey>
    {
        public TKey EntityIdentifier { get; set; }

        public bool ValidState => EntityIdentifier != null;
    }
}
