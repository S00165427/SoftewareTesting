using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace TestingSoftware.Tests
{
    [TestFixture]

    class PremiumTests
    {
        [Test]
        public void femaleAgeTest1()
        {
            var female = new Class1();
            Assert.AreEqual(5, female.CalcPremium(20, "female"));
        }

        [Test]
        public void femaleAgeTest2()
        {
            var female = new Class1();
            Assert.AreEqual(2.5, female.CalcPremium(34, "female"));
        }

        [Test]
        public void femaleAgeTest3()
        {
            var female = new Class1();
            Assert.AreEqual(0, female.CalcPremium(16, "female"));
        }

        [Test]
        public void maleAgeTest1()
        {
            var male = new Class1();
            Assert.AreEqual(6, male.CalcPremium(19, "male"));
        }

        [Test]
        public void maleAgeTest2()
        {
            var male = new Class1();
            Assert.AreEqual(5, male.CalcPremium(38, "male"));
        }

        [Test]
        public void maleAgeTest3()
        {
            var male = new Class1();
            Assert.AreEqual(0, male.CalcPremium(17, "male"));
        }

        [Test]
        public void ageTest1()
        {
            var age = new Class1();
            Assert.AreEqual(5 * 0.15, age.CalcPremium(52, "male"));
        }

        [Test]
        public void ageTest2()
        {
            var age = new Class1();
            Assert.AreEqual(2.5 * 0.15, age.CalcPremium(54, "female"));
        }

        [Test]
        public void GenderTest()
        {
            var gender = new Class1();
            Assert.AreEqual(0, gender.CalcPremium(20, ""));
        }
    }
    
    

}
