using System.IO;
using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace ObjectPrctical
{
    [TestFixture]
    internal class MyTest
    {
        [Test]
        public void ReadTextarea()
        {
       

            var text1 = File.ReadAllText(@"E:\Designite\push.txt");
            
            var text = File.ReadAllText(@"E:\Designite\pushkar.txt");
            IsFalse(condition: string.IsNullOrEmpty(text1));
            



        }
        [Test]
        public void Push()
        {
            var text1 = File.ReadAllText(@"E:\Designite\push.txt");

            var text = File.ReadAllText(@"E:\Designite\pushkar.txt");
            AreNotEqual(text1, text);
        }
        [Test]
        public void Push1()
        {
            var text1 = File.ReadAllText(@"E:\Designite\push.txt");

            var text = File.ReadAllText(@"E:\Designite\pushkar.txt");
            AreEqual(text, text1);
        }
    }
}
