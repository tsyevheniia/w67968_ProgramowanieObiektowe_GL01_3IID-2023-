using lab2classlibrary.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class LiczTest
    {
        private Licz licz;

        [SetUp]
        public void Setup()
        {
            licz = new Licz();
        }

        [Test]
        [TestCase(2, 3, 5)]  
        public void Dodaj(int i, int x, int expect)
        {
            licz.Dodaj(i);
            licz.Dodaj(x);

            Assert.AreEqual(expect, licz.Value);
        }
    }
}

