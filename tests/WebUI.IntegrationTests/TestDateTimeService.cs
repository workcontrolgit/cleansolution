using cleansolution.Application.Common.Interfaces;
using System;

namespace cleansolution.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
