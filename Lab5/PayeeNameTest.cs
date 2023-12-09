using OpenQA.Selenium.Chrome;
using WebPage;
namespace Lab5
{
    [TestClass]
    public class PayeeNameTest
    {
        [TestMethod]
        public void ValueInPayeeTest()
        {
            //Arrange
            var drv = new ChromeDriver();
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/";
            PagePattern pagePattern = new PagePattern(url,drv);
            string payee_name = "HouseRent";
            //Act
            pagePattern.Search_by_Payee_Name(payee_name);
            //Assert
            string result = pagePattern.GetTable();
            Assert.IsTrue(result.Contains(payee_name),"You was wrong somewhere...");
            //End
            drv.Quit();
        }
        [TestMethod]
        public void ValueIsNotInPayeeTest()
        {
            //Arrange
            var drv = new ChromeDriver();
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/";
            PagePattern pagePattern = new PagePattern(url,drv);
            string payee_name = "!";
            //Act
            pagePattern.Search_by_Payee_Name(payee_name);
            //Assert
            string result = pagePattern.GetTable();
            Assert.IsTrue((pagePattern.table.Contains(result)) && (!result.Contains(payee_name)), "You was wrong somewhere...");
            //End
            drv.Quit();
        }
    }
}
