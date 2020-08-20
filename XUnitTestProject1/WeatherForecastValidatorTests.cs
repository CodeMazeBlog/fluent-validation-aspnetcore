using System;
using FluentValidation.TestHelper;
using WebApplication1;
using Xunit;

namespace XUnitTestProject1
{
    public class WeatherForecastValidatorTests
    {
        private readonly WeatherForecastValidator _validator = new WeatherForecastValidator();

        [Fact]
        public void GivenAnInvalidTemperatureCValue_ShouldHaveValidationError()
            => _validator.ShouldHaveValidationErrorFor(model => model.TemperatureC, 101);

        [Theory]
        [InlineData(99)]
        [InlineData(100)]
        public void GivenAValidTemperatureCValue_ShouldNotHaveValidationError(int temperatureC)
            => _validator.ShouldNotHaveValidationErrorFor(model => model.TemperatureC, temperatureC);
    }
}
