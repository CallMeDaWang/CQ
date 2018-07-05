using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;
using CQ.Entity;

namespace CQ
{
    public class TbSpider
    {
        static RemoteWebDriver browser = new ChromeDriver();
        WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
        GoodsCondition gc = null;
        private StringBuilder result = new StringBuilder();
        int collectNum = 0;
        public TbSpider(GoodsCondition gc)
        {
            this.gc = gc;
        }
        public StringBuilder Run()
        {
            int total = 5;
            string totalPage = Search();
            int.TryParse(Regex.Match(totalPage, @"(\d+)").ToString(), out total);
            for (int i = 2; i < total + 1; i++)
            {
                NextPage(i);
                if (collectNum >= gc.collectNum) break;
            }
            return result;
        }
        private string Search()
        {
            try
            {
                browser.Url = "https://www.taobao.com";
                IWebElement input = wait.Until<IWebElement>(ExpectedConditions.ElementExists(By.Id("q")));

                IWebElement submit = wait.Until<IWebElement>(ExpectedConditions.ElementToBeClickable(By.CssSelector("#J_TSearchForm > div.search-button > button")));
                input.SendKeys(gc.keyWord);
                submit.Click();
                IWebElement total = wait.Until<IWebElement>(ExpectedConditions.ElementExists(By.CssSelector("#mainsrp-pager > div > div > div > div.total")));
                GetProduct();
                return total.Text;
            }
            catch (Exception e)
            {
                throw;
                Search();

                return "";
            }
        }
        private void NextPage(int page_number)
        {
            try
            {
                IWebElement input = wait.Until(ExpectedConditions.ElementIsVisible((By.CssSelector("#mainsrp-pager > div > div > div > div.form > input"))));
                IWebElement submit = wait.Until(ExpectedConditions.ElementToBeClickable((By.CssSelector("#mainsrp-pager > div > div > div > div.form > span.btn.J_Submit"))));
                input.Clear();
                input.SendKeys(page_number.ToString());
                submit.Click();
                wait.Until(
                    ExpectedConditions.TextToBePresentInElement(browser.FindElement(
                            By.CssSelector("#mainsrp-pager > div > div > div > ul > li.item.active > span"))
                        , page_number.ToString())

                );
                GetProduct();
            }
            catch (Exception e)
            {
                throw;
                NextPage(page_number);
            }
        }
        private void GetProduct()
        {
            try
            {
                //等待商品列表加载完成
                ReadOnlyCollection<IWebElement> items = wait.Until<ReadOnlyCollection<IWebElement>>(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("#mainsrp-itemlist .items .item")));
                foreach (IWebElement item in items)
                {
                    int count = 0;
                    IWebElement dealcnt = item.FindElement(By.ClassName("deal-cnt"));
                    if (!string.IsNullOrEmpty(dealcnt.Text))
                    {

                        string pattern = @"(\d+)";
                        Match m = Regex.Match(dealcnt.Text, pattern);
                        int.TryParse(m.ToString(), out count);
                        if (count < gc.minPayNum | count > gc.maxPayNum) continue;
                    }

                    //Goods goods = new Goods();

                    //IWebElement a1 = item.FindElement(By.ClassName("pic-link"));
                    ////相似

                    ////名称
                    //IWebElement a3 = item.FindElement(By.Id("J_Itemlist_TLink_" + a1.GetAttribute("data-nid")));
                    ////店铺
                    //IWebElement a4 = item.FindElement(By.ClassName("shopname"));
                    ////
                    //IWebElement strong = item.FindElement(By.TagName("strong"));
                    ////location
                    //IWebElement location = item.FindElement(By.ClassName("location"));
                    //goods.id = Guid.NewGuid().ToString();
                    //goods.goodsId = a1.GetAttribute("data-nid");
                    //try
                    //{
                    //    ReadOnlyCollection<IWebElement> a2 = item.FindElement(By.ClassName("similars")).FindElements(By.TagName("a"));
                    //    goods.samestyle = a2[0].GetAttribute("href");
                    //    goods.similar = a2[1].GetAttribute("href");
                    //}
                    //catch (Exception e)
                    //{
                        
                    //}
                    //goods.dealcnt = count;
                    //goods.title = a3.Text;
                    //goods.storeurl = a4.GetAttribute("href");
                    //goods.storename = a4.Text;
                    //goods.price = decimal.Parse(strong.Text);
                    //goods.location = location.Text;
                    //goods.imgUrl = a1.GetAttribute("data-src");
                    //result.AppendLine(a1.GetAttribute("href"));
                    //collectNum++;
                }
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
