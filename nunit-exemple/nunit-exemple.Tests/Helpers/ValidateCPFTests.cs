using NUnit.Framework;
using nunit_exemple.Helpers;

namespace nunit_exemple.Tests.Helpers
{
    [TestFixture]
    public class ValidateCPFTests
    {

        [TestCase("899.772.560-20")]
        [TestCase("142.819.070-84")]
        [TestCase("619.219.190-51")]
        public void ValidateCPF_ShouldBeSuccessful(string cpf)
        {           
            var result = ValidateCPF.IsCpf(cpf);

            Assert.IsTrue(result);
        }

        [TestCase("899.772.560-21")]
        [TestCase("142.819.070-82")]
        [TestCase("619.219.190-53")]
        [TestCase("41")]
        [TestCase(null)]
        public void ValidateCPF_ShouldBeUnsuccessful(string cpf)
        {
            var result = ValidateCPF.IsCpf(cpf);

            Assert.IsFalse(result);
        }

    }
}
