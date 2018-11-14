using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTest
  {
    [TestMethod]
        public void LeetSpeakTester_TestforE_3()
        {
          LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
          Assert.AreEqual("3", testLeetspeak.Translate("e"));

        }

    [TestMethod]
        public void LeetSpeakTester_TestForO_0()
        {
          LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
          Assert.AreEqual("0", testLeetspeak.Translate("o"));

        }
    [TestMethod]
        public void LeetSpeakTester_TestForI_1()
        {
          LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
          Assert.AreEqual("1", testLeetspeak.Translate("I"));

        }
    [TestMethod]
        public void LeetSpeakTester_TestForT_7()
        {
          LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
          Assert.AreEqual("7", testLeetspeak.Translate("t"));

        }
    [TestMethod]
        public void LeetSpeakTester_TestForS_Z()
        {
          LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
          Assert.AreEqual("Z", testLeetspeak.Translate("s"));

        }
  }
}
