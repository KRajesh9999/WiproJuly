﻿using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Moq;
using System.Threading.Tasks;

namespace Mocking_moq_Example
{
    [TestFixture]
    internal class DetailsTestEx2
    {
        //[Test]
        //public void TestShowCompany()
        //{
        //    Assert.AreEqual("Its Capgemini from Hyderabad...", new Details().ShowCompany());
        //    Mock<IDetails> mockObject = new Mock<IDetails>();
        //    mockObject.Setup(x => x.ShowCompany()).Returns("Its Capgemini from Bangalore...");
        //    Assert.AreEqual("Its Capgemini from Bangalore...", mockObject.Object.ShowCompany());
        //}

        [Test]
        public void TestShowStudent()
        {
            Mock<IDetails> mockObject = new Mock<IDetails>();
            mockObject.Setup(x => x.ShowStudent()).Returns("Its Yash from Capgemini...");
            Assert.AreEqual("Its Yash from Capgemini...", mockObject.Object.ShowStudent());
        }

        [Test]
        public void TestMockShowCompany()
        {
            Mock<IDetails> mockObject = new Mock<IDetails>();
            DetailsMockEx2 m = new DetailsMockEx2();
            mockObject.Setup(x => x.ShowCompany()).Returns(m.ShowCompany());
            Assert.AreEqual("Its Capgemini from Chennai...", mockObject.Object.ShowCompany());
        }

        [Test]
        public void TestMockShowStudent()
        {
            Mock<IDetails> mockObject = new Mock<IDetails>();
            DetailsMockEx2 m = new DetailsMockEx2();
            mockObject.Setup(x => x.ShowStudent()).Returns(m.ShowStudent());
            Assert.AreEqual("Hi Manali here from Capgemini...", mockObject.Object.ShowStudent());
        }
    }
}
