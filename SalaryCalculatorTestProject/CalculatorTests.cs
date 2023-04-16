using Calculator;

namespace SalaryCalculatorTestProject
{
    /*  Test Driven Development
     *  RED         - Write a failing test case
     *  GREEN       - Update the unit test to pass
     *  REFACTOR    - 
     */


    /* 
     *  To get hourly, divide anual salary by 2080
     *  $100,006.40 / 2080 = $48.08 hr
     *  
     *  To get annual, multiply hourly salary by 2080
     *  $48.08 * 2080 = $100,006.40 hr
     */

    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();

            //Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            //Assert
            Assert.AreEqual(104000, annualSalary);

        }


        [TestMethod]
        public void HourlyWageTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();

            //Act
            decimal hourlyWage = sc.GetHourlyWage(52000);

            //Assert
            Assert.AreEqual(25, hourlyWage);

        }
    }
}