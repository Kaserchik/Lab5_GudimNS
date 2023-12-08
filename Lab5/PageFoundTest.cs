using WebPage;
namespace Lab5
{
    [TestClass]
    public class PageElementsFind
    {
        [TestMethod]
        public void PageTest()
        {
            //Arrange PageFoundTest
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/";
            PagePattern pagePattern = new PagePattern(url);
            //Assert
            Assert.AreEqual("",pagePattern.ex_log, "You was wrong somewhere...");
        }
    }
}
