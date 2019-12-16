using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using MessageServices;

namespace Server.Services
{
    public class NotificationService : NotifyService.NotifyServiceBase
    {
        public override async Task MonitorEntityUpdates(EntityIdentifier request, IServerStreamWriter<EntityIdentifier> responseStream, ServerCallContext context)
        {
            var i = 0;
            while (!context.CancellationToken.IsCancellationRequested && i < 25)
            {
                var entity = new EntityIdentifier()
                {
                    EntityID = request.EntityID
                };
                await responseStream.WriteAsync(entity);

                await Task.Delay(500);
                if (i % 5 == 0)
                {
                    await Task.Delay(10000);
                }
                i ++;
            }
        }
    }
}
