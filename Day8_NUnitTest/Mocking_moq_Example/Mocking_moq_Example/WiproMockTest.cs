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
    internal class WiproMockTest
    {
        [Test]
        public void TestMileStone1()
        { 
            Mock<IWiproData> mock = new Mock<IWiproData>();
            mock.Setup(x => x.MileStoneExam1()).Returns("MileStone Exam 1 on Aug 1...");
            Assert.AreEqual("MileStone Exam 1 on Aug 1...", mock.Object.MileStoneExam1());
        }

        [Test]
        public void TestMileStone2()
        {
            Mock<IWiproData> mock = new Mock<IWiproData>();
            mock.Setup(x => x.MileStoneExam2()).Returns("MileStone Exam 2 on Aug 10...");
            Assert.AreEqual("MileStone Exam 2 on Aug 10...", mock.Object.MileStoneExam2());
        }
    }
}
