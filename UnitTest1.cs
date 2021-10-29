using EmployeeManagment;
using EmployeeManagmentTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeManagmentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalaryDetails_AbleToUpdateSalaryDetails()
        {
            Salary sal = new Salary();
            SalaryUpdateModel updateModel = new SalaryUpdateModel()
            {
                SalaryId = 12,
                Month = "Jan",
                EmployeeSalary = 12000,
                EmployeeId = 123
            };

            int EmpSalary = sal.UpdateEmployeeSalary(updateModel);

            Assert.AreEqual(updateModel.EmployeeSalary, EmpSalary);

        }
    }
}
