using Microsoft.VisualStudio.TestTools.UnitTesting;
using OWASP.WebGoat.NET.WebGoatCoins;

namespace WebGoat.Tests.Tests
{
    [TestClass]
    public class SecurityTests
    {
        [TestMethod]
        public void OpenRedirect_ReturnUrl_ShouldBeRelative()
        {
            string returnUrl = "http://evil.com";
            bool isRelative = System.Uri.IsWellFormedUriString(returnUrl, System.UriKind.Relative);
            Assert.IsFalse(isRelative);
        }
    }
}
