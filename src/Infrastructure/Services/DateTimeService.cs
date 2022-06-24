using cleanddd.Application.Common.Interfaces;
using System;

namespace cleanddd.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
