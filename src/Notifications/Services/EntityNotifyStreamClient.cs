using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GroupChat.Notifications.Interfaces;
using Grpc.Core;
using Grpc.Net.Client;
using MessageServices;

namespace GroupChat.Notifications.Services
{
    public class EntityNotifyStreamClient : NotifyService.NotifyServiceClient, IEntityNotificationDataStream
    {
        public EntityNotifyStreamClient(GrpcChannel channel) : base(channel)
        { }

        public IAsyncEnumerable<EntityIdentifier> ReadAllAsync(string entityId)
        {
            var stream = MonitorEntityUpdates(new EntityIdentifier{ EntityID = entityId });
            return stream.ResponseStream.ReadAllAsync();
        }
    }
}
