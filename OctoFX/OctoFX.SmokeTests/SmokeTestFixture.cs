using NUnit.Framework;
using OctoFX.SmokeTests.Properties;
using System.Net;

namespace OctoFX.SmokeTests
{
   [TestFixture]
   public class SmokeTestFixture
   {
      #region Public Methods

      [Test]
      public void EnsureWebSiteIsRunning()
      {
         string responseText = new WebClient().DownloadString(Settings.Default.endpointUrl);

         Assert.That(responseText, Does.Contain("OctoFX makes it easy to buy and sell"));
      }

      #endregion Public Methods
   }
}