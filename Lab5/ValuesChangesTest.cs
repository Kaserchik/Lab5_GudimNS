using WebPage;
namespace Lab5
{
    [TestClass]
    public class ValuesChangesTest
    {
        [TestMethod]
        public void ValueInPayeeTest()
        {
            //Arrange
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/";
            PagePattern pagePattern = new PagePattern(url);
            string payee_name = "HouseRent";
            //Act
            pagePattern.Search_by_Payee_Name(payee_name);
            //Assert
            Assert.IsTrue(pagePattern.new_table.Contains(payee_name),"You was wrong somewhere...");
        }
        [TestMethod]
        public void ValueIsNotInPayeeTest()
        {
            //Arrange
            string url = "https://www.globalsqa.com/angularJs-protractor/SearchFilter/";
            PagePattern pagePattern = new PagePattern(url);
            string payee_name = "!";
            //Act
            pagePattern.Search_by_Payee_Name(payee_name);
            //Assert
            Assert.IsTrue((pagePattern.table.Contains(pagePattern.new_table)) && (!pagePattern.new_table.Contains(payee_name)), "You was wrong somewhere...");
        }
    }
}
