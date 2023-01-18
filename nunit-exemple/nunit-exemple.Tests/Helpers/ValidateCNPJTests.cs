using NUnit.Framework;
using nunit_exemple.Helpers;

namespace nunit_exemple.Tests.Helpers
{
    [TestFixture]
    public class ValidateCNPJTests
    {
        [TestCase("11.302.132/0001-94")]
        [TestCase("41.444.647/0001-90")]
        [TestCase("98.503.600/0001-77")]
        public void ValidateCNPJ_ShouldBeSuccessful(string cpf)
        {
            var result = ValidateCNPJ.IsCnpj(cpf);

            Assert.IsTrue(result);
        }

        [TestCase("11.302.132/0001-95")]
        [TestCase("41.444.647/0001-96")]
        [TestCase("98.503.600/0001-74")]
        [TestCase("98.503.600/0001-744456456")]
        [TestCase("4")]
        [TestCase("41")]
        //[TestCase("413")]
        //[TestCase("ABCDADAAaSSA")]
        //[TestCase("ABCDADAAaSSAAS")]
        [TestCase(null)]
        public void ValidateCNPJ_ShouldBeUnsuccessful(string cpf)
        {
            var result = ValidateCNPJ.IsCnpj(cpf);

            Assert.IsFalse(result);
        }

    }
}
