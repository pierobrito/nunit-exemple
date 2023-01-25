using NUnit.Framework;
using nunit_exemple.Extensions;
using nunit_exemple.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunit_exemple.Tests.CrossCutting.Extensions
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [Test]
        [TestCase("11.302.132/0001-94")]
        [TestCase("41.44##%%%##@!@##0")]
        [TestCase("98!@@#!@#")]

        public void ToNumbers_ShouldBeSuccessful(string numbers)
        {
            var result = numbers.ToNumbers();

            bool isNumeric = long.TryParse(result, out _);

            Assert.IsTrue(isNumeric);
        }

        [TestCase(null)]
        public void ToNumbers_ShouldBeUnSuccessful(string numbers)
        {
            var result = numbers.ToNumbers();

            bool isNumeric = long.TryParse(result, out _);

            Assert.IsFalse(isNumeric);
        }
    }
}
