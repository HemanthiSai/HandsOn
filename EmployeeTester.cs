using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEmployees
{
    [TestFixture]
    public class EmployeeTester
    {
        List<Employee> list;
        [Test]
        public void UniqueId()
        {
            try
            {
                Employee emp = new Employee();
                list = emp.GetEmployees();
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        Assert.AreNotEqual(list[i].EmpId, list[j].EmpId);
                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Test case failed as Id is not unique", ex);
            }
        }
    }
}
