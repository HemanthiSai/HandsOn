using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployeesNUnit
{
    [TestFixture]
    public class TestEmployee
    {
        Employee emp;
        EmployeeManager empmanager;
        [Test]
        public void AddEmployee()
        {
            int a = empmanager.HeadCount;
            Assert.That(0, Is.EqualTo(a));
            emp = new Employee()
            {
                Id = 1000,
                Name = "Hemanthi"
            };
            empmanager.AddEmployee(emp);
            int b = empmanager.HeadCount;
            Assert.That(1, Is.EqualTo(b));
        } 
    }
}
