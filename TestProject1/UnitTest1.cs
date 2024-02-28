using NUnit.Framework.Interfaces;
using jenkinsdemo;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_sayJenkins_1()
        {
            Testme obj1 = new Testme();
            String result = obj1.sayJenkins(2);
            Assert.AreEqual("JenkinsJenkins",result);
        }

        [Test]
        public void Test_sayJenkins_2()
        {
            Testme obj1 = new Testme();
            String result = obj1.sayJenkins(1);
            Assert.AreEqual("Jenkins", result);
        }
    }
}