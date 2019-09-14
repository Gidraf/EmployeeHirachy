using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EmployeeHierachy;

namespace TestEmployeeHierachy
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void TestExceptionisThrownWhenAnInvalidCSVListIsInpiuted()
        {
            Assert.ThrowsException<Exception>(() => new Employees(""));
           
        }

        [TestMethod]
        public void TestExceptionisThrownWhenAnInvalidOneEmployessReportsToMoreThanManger()
        {
            Assert.ThrowsException<Exception>(() => new Employees("john,manager1,100" +
                "\n" +
                "peter,manager1," +
                "1900\ngidraf,manager2,100" +
                "\n" +
                "peter,manager3,1900" +
                "\nCEO,,1000 \n " +
                "manager1,CEO,1900" +
                "\n" +
                "manager3,CEO,1900\nsalasia,manager1,1900\nmanager2,CEO,1900"));

        }

         [TestMethod]
        public void TestExceptionisThrownWhenWehaveMoreThanOneCEO()
        {
            Assert.ThrowsException<Exception>(() => new Employees("john,manager1,100" +
                "\n" +
                "peter,manager1," +
                "1900\ngidraf,manager2,100" +
                "\n" +
                "orenja,,1900" +
                "\nCEO,,1000 \n " +
                "manager1,CEO,1900" +
                "\n" +
                "manager3,CEO,1900\nsalasia,manager1,1900\nmanager2,CEO,1900"));

        }

        [TestMethod]
        public void TestExceptionisThrownWhenWehaveCircularReference()
        {
            Assert.ThrowsException<Exception>(() => new Employees("john,manager1,100" +
                "\n" +
                "peter,manager1," +
                "1900\ngidraf,manager2,100" +
                "\n" +
                "orenja,manager1,1900" +
                "\nCEO,,1000 \n " +
                "manager1,CEO,1900" +
                "\n" +
                "manager2,manager1,1900\nsalasia,manager1,1900\nmanager2,CEO,1900"));

        }

        [TestMethod]
        public void TestExceptionisThrownWhenWeAllManagersAreNotListedInEmployessCell()
        {
            Assert.ThrowsException<Exception>(() => new Employees("john,manager1,100" +
                "\n" +
                "peter,manager1," +
                "1900\ngidraf,manager2,100" +
                "\n" +
                "orenja,manager5,1900" +
                "\nCEO,,1000 \n " +
                "manager1,CEO,1900" +
                "\n" +
                "employess,manager1,1900\nsalasia,manager1,1900\nmanager2,CEO,1900"));

        }

        [TestMethod]
        public void TestManagerBurgetsReturnsCorrect()
        {

            Employees testEmployee = new Employees("john,manager1,100" +
                "\n" +
                "peter,manager1," +
                "1900\ngidraf,manager2,100" +
                "\n" +
                "orenja,manager1,1900" +
                "\nCEO,,1000 \n " +
                "manager1,CEO,1900" +
                "\n" +
                "employess,manager1,1900\nsalasia,manager1,1900\nmanager2,CEO,1900");

            Assert.AreEqual(4800, testEmployee.managerSalaryBudget("CEO"));

        }
    }
}
