using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebPage
{
    public class PagePattern
    {
        IWebDriver _driver = new ChromeDriver();
        private IWebElement _payee_Name;
        private SelectElement _account;
        private SelectElement _type;
        private IWebElement _payees;
        public string table;
        public string new_table;
        public string ex_log = "";
        public PagePattern(string url) 
        {
            ex_log = "";
            try
            {
                _driver.Url = url;
                _payee_Name = _driver.FindElement(By.Id("input1"));
                _account = new SelectElement(_driver.FindElement(By.Id("input2")));
                _type = new SelectElement(_driver.FindElement(By.Id("input3")));
                _payees = _driver.FindElement(By.Id("input4"));
                table = _driver.FindElement(By.XPath("/html/body/div/table")).Text;
            }
            catch (Exception ex)
            {
                ex_log += ex.ToString();
            }
        }
        public void Search_by_Payee_Name(string name)
        {
            _payee_Name.SendKeys(name);
            FilterTable();
        }
        public void Search_by_Account(string loc_account)
        {
            _account.SelectByText(loc_account);
            FilterTable();
        }
        public void Search_by_Type(string loc_type)
        {
            _type.SelectByText(loc_type);
            FilterTable();
        }
        public void Search_by_Payees(string loc_payees)
        {
            _payees.SendKeys(loc_payees);
            FilterTable();
        }
        private void FilterTable()
        {
            new_table = "";
            new_table = _driver.FindElement(By.XPath("/html/body/div/table")).Text;
        }
    }
}
