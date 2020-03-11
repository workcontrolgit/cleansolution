using cleansolution.Application.Common.Interfaces;
using System;

namespace cleansolution.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
