using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Moq;
using NUnit.Framework;

namespace Mocking_moq_Example
{
    [TestFixture]
    public class EmployDaoTest
    {
        List<Employ> employList = new List<Employ>()
        {
            new Employ(){Empno = 1, Name = "Rajesh", Basic = 88323 },
            new Employ(){Empno = 2, Name = "Rakesh", Basic = 91911 },
            new Employ(){Empno = 3, Name = "Ramesh", Basic = 86444 },
        };

        Employ e1 = new Employ { Empno = 1, Name = "Raghav", Basic = 84323 };
        Employ e2 = new Employ { Empno = 2, Name = "Rupesh", Basic = 82234 };

        Employ e3 = null;

        [Test]
        public void TestShowEmployList()
        {
            Mock<IEmployDao> mockDao = new Mock<IEmployDao>();
            mockDao.Setup(x => x.ShowEmploy()).Returns(employList);
            Assert.AreEqual(3, mockDao.Object.ShowEmploy().Count());
        }

        [Test]
        public void TestSearchEmploy()
        {
            Mock<IEmployDao> mockDao = new Mock<IEmployDao>();
            mockDao.Setup(x => x.SearchEmploy(1)).Returns(e1);
            Assert.IsNotNull(mockDao.Object.SearchEmploy(1));

            mockDao.Setup(x => x.SearchEmploy(100)).Returns(e2);
            Assert.IsNotNull(mockDao.Object.SearchEmploy(100));

            mockDao.Setup(x =>  x.SearchEmploy(200)).Returns(e3);
            Assert.IsNull(mockDao.Object.SearchEmploy(200));
        }
    }
}
