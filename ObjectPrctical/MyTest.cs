using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectPrctical
{
    [TestFixture]
    class MyTest
    {
        [Test]
        public void Readtext()
        {
       

            string text1 = File.ReadAllText(@"E:\Designite\push.txt");
            
            string text = File.ReadAllText(@"E:\Designite\pushkar.txt");
            Assert.IsFalse(string.IsNullOrEmpty(text1));
            Assert.AreNotEqual(text1, text);
            Assert.AreEqual(text, text1);



        }
        
    }
}
