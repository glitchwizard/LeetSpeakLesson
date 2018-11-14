using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTest
  {
    [TestMethod]
        public void LeedSpeak()
        {
          Leetspeak testSeedProject = new Leetspeak();
          Assert.AreEqual(false, testLeetspeak.LeedSpeak());
        }
  }
}
