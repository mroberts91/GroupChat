using GroupChat.Application.Common.Interfaces;
using System;

namespace GroupChat.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
