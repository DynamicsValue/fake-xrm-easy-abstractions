using FakeXrmEasy.Abstractions.Settings;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.Settings
{
    public class DateTimeSettingsTests
    {
        [Fact]
        public void Should_create_date_time_settings()
        {
            var dateTimeSettings = new DateTimeSettings();
            Assert.Null(dateTimeSettings.SystemTimeZone);
        }
    }
}
