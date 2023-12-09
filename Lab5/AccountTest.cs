using OpenQA.Selenium.Chrome;
using WebPage;

namespace Lab5
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void TableEditedOne()
        {
            //Arrange
            var drv = new ChromeDriver();
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/";
            PagePattern pagePattern = new PagePattern(url, drv);
            string account_type = "Cash";

            //Act
            pagePattern.Search_by_Account(account_type);


            //Assert
            string result = pagePattern.GetTable();
            Assert.IsTrue(result.Contains("1 Cash EXPENDITURE HouseRent 1000"));
            Assert.IsTrue(result.Contains("2 Cash EXPENDITURE InternetBill 1200"));
            Assert.IsTrue(result.Contains("3 Cash EXPENDITURE PowerBill 200"));

            //End
            drv.Quit();
        }
        [TestMethod]
        public void TableEditedAll()
        {
            //Arrange
            var drv = new ChromeDriver();
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/";
            PagePattern pagePattern = new PagePattern(url, drv);
            string account_type = "All Accounts";

            //Act
            pagePattern.Search_by_Account(account_type);


            //Assert
            string result = pagePattern.GetTable();
            Assert.AreEqual(result,pagePattern.table);

            // end
            drv.Quit();
        }
    }
}
