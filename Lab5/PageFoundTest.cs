using OpenQA.Selenium.Chrome;
using WebPage;
namespace Lab5
{
    [TestClass]
    public class PageElementsFind
    {
        [TestMethod]
        public void PageTestTrue()
        {
            ///Arrange
            var drv = new ChromeDriver();
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/";
            PagePattern pagePattern = new PagePattern(url,drv);
            //Assert
            Assert.IsNotNull(pagePattern.table, "You was wrong somewhere...");
            //End
            drv.Quit();
        }
        [TestMethod]
        public void PageTestFalse()
        {
            //Arrange
            var drv = new ChromeDriver();
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/111";
            PagePattern pagePattern = new PagePattern(url, drv);
            //Assert
            Assert.IsNotNull(pagePattern.table, "You was wrong somewhere...");
            //End
            drv.Quit();
        }
    }
}
