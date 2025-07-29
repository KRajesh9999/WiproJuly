using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace NUnitTestDemoProject.Test
{
    [TestFixture]
    internal class EmployTest
    {
        [Test]
        public void TestSearchEmploy()
        {
            EmployDao employDao = new EmployDao();
            Employ employFound = employDao.SearchEmploy(1);
            Assert.IsNotNull(employFound);
            employFound = employDao.SearchEmploy(-1);
            Assert.Null(employFound);
        }

        [Test]
        public void TestShowEmploy()
        {
            List<Employ> employList = new EmployDao().ShowEmploy();
            Assert.AreEqual(4, employList.Count);
        }

        [Test]
        public void TestToString()
        {
            Employ employ = new Employ();
            employ.Empno = 1;
            employ.Name = "Rajesh";
            employ.Basic = 99878;

            string expected = "Empno 1 Name Rajesh Basic 99878";
            Assert.AreEqual(expected, employ.ToString());
        }

        [Test]
        public void TestGettersAndSetters()
        {
            Employ employ = new Employ();
            employ.Empno = 2;
            employ.Name = "Rakesh";
            employ.Basic = 88321;

            Assert.AreEqual(2, employ.Empno);
            Assert.AreEqual("Rakesh", employ.Name);
            Assert.AreEqual(88321, employ.Basic);
        }

        [Test]
        public void TestConstructor()
        {
            Employ employ = new Employ();
            Assert.NotNull(employ);
            Employ employ1 = new Employ(88, "Venkata", 99923);
            Assert.AreEqual(88, employ1.Empno);
            Assert.AreEqual("Venkata", employ1.Name);
            Assert.AreEqual(99923, employ1.Basic);
        }
    }
}
