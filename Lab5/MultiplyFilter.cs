using OpenQA.Selenium.Chrome;
using WebPage;

namespace Lab5
{
    [TestClass]
    public class MultiplyFilter
    {
        [TestMethod]
        public void MultiTrue()
        {
            //Arrange
            var drv = new ChromeDriver();
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/";
            string account = "Cash";
            string payeename = "InternetBill";
            PagePattern pagePattern = new PagePattern(url, drv);
            //Act
            pagePattern.Search_by_Payee_Name(payeename);
            pagePattern.Search_by_Account(account);
            //Assert
            string result = pagePattern.GetTable();
            Assert.IsTrue(result.Contains("Cash EXPENDITURE InternetBill 1200"));
            //End
            drv.Quit();
        }
    }
}
