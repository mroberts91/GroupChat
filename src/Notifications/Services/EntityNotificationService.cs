using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using GroupChat.Notifications.Messages;
using Grpc.Core;
using Grpc.Net.Client;
using MessageServices;

namespace GroupChat.Notifications.Services
{
    public class EntityNotificationService
    {
        private readonly Channel<IEntityStateNotification<string>> NotificationChannel;
        private readonly ChannelWriter<IEntityStateNotification<string>> writer;
        private readonly string _entityId;
        private readonly NotifyService.NotifyServiceClient _client;
        public EntityNotificationService(GrpcChannel channel, string entityId)
        {
            _client = new NotifyService.NotifyServiceClient(channel);
            _entityId = entityId;
            NotificationChannel = Channel.CreateUnbounded<IEntityStateNotification<string>>(new UnboundedChannelOptions
            {
               AllowSynchronousContinuations = true,
               SingleReader = true,
               SingleWriter = true
            });
            writer = NotificationChannel.Writer;
        }

        private async Task InitStream()
        {
            using var stream = _client.MonitorEntityUpdates(new EntityIdentifier { EntityID = _entityId }, cancellationToken: default);
            await foreach (var update in stream.ResponseStream.ReadAllAsync())
            {
                await writer.WriteAsync(new EntityNotificationMessage<string>
                {
                    EntityIdentifier = update.EntityID
                });
            }
        }
        
        public ChannelReader<IEntityStateNotification<string>> Subscribe()
        {
            return NotificationChannel.Reader;
        }
        
    }

    internal class EntityNotificationMessage<TKey> : IEntityStateNotification<TKey>
    {
        public TKey EntityIdentifier { get; set; }

        public bool ValidState => EntityIdentifier != null;


    }
}
