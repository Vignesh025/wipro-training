using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Function1()
        {
            int result = 100, mark1 = 20, mark2 = 30;

            Assert.That(mark1, Is.Not.EqualTo(mark2));

            Assert.That(mark1, Is.LessThan(mark2));
        }
    }
}
