using NUnit.Framework;
using nunit_exemple.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunit_exemple.Tests.CrossCutting.Helpers
{
    [TestFixture]
    public class TemperatureSensorTests
    {
        [Test]
        public void ReadTemperature_ShouldBeUnsuccessful()
        {
            var sut = new TemperatureSensor();

            sut.Initialize();

            var temperature = sut.ReadCurrentTemperature();

            Assert.AreEqual(42, temperature);
        }

        [Test]
        public void ErrorIfReadingBeforeInitialized()
        {
            var sut = new TemperatureSensor();

            Assert.Throws<InvalidOperationException>(() => sut.ReadCurrentTemperature());
        }

        [Test]
        public void ErrorIfReadingBeforeInitialized_CaptureExDemo()
        {
            var sut = new TemperatureSensor();

            var ex = Assert.Throws<InvalidOperationException>(() => sut.ReadCurrentTemperature());

            // Assert.That(ex.Message, Is.EqualTo("Cannot read temperature before initializing."));
        }

    }
}
