using CQ.Entity;
using CQ.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CQ.Bll
{
    public class KeySearch
    {
        private GoodsCondition gc;

        public KeySearch(GoodsCondition gc)
        {
            this.gc = gc;
        }

        public string Key { get; set; }
        //https://s.taobao.com/search?data-key=s&data-value=44&ajax=true&_ksTS=1530675367499_1105&callback=jsonp1106&q=%E7%8E%BB%E7%92%83%E8%83%B6&refpid=430267_1006&source=tbsy&style=grid&tab=all&pvid=2012ee9ea433deff6428d02b0f006788&clk1=46514d9e4314d81b4a5d7c918df01106&spm=a21bo.2017.201856-sline.2.5af911d9mVIzuW&filter=reserve_price%5B4.01%2C12.00%5D&bcoffset=0&p4ppushleft=%2C44
        public List<Auction> GetKeySearchResult()
        {
            /***
          * 1. 页数信息                      JSON.mods.sortbar.data.pager
          * 2. 价格区间信息                  JSON.mods.sortbar.data.price
          * 3. 排序信息                      JSON.mods.sortbar.data.sortList
          * 4. 其他过滤信息                  JSON.mods.sortbar.data.filter
          * 5. 所有商品id                    JSON.mainInfo.traceInfo.traceData.auctionNids
          * 6. 所有商品(allOldBiz30Day)      JSON.mainInfo.traceInfo.traceData.allOldBiz30Day
          * 7. 所有商品分类                  JSON.mainInfo.traceInfo.traceData.allCategories
          * 7. 所有价格                      JSON.mainInfo.traceInfo.traceData.allPrices
          * 8. 所有活跃价格                  JSON.mainInfo.traceInfo.traceData.auctionPrices
          * 9. 相关关键词                    JSON.mainInfo.traceInfo.traceData.rsKeywords
          * 10.旺旺昵称                      JSON.mainInfo.traceInfo.traceData.auctionNicks
          * 11.不知名（销售类型）            JSON.mainInfo.traceInfo.traceData.sp_seller_types
          * 12.商品信息                      JSON.mods.itemlist.data.auctions
          * 
          **/
            List<Auction> finalResult = new List<Auction>();
            Rank r = null;
            KeySearchResult result = Collect();
            Pager2 p = result.Mods.Sortbar.Data.Pager;
            if (gc.userLike)
            {
                IList<Rank> rank = result.Mods.Sortbar.Data.Price.Rank;
                if (rank.Count > 0)
                {
                    r = (from item in rank
                         orderby item.Percent descending
                         select item).ToList<Rank>()[0];
                }
                gc.minPrice = decimal.Parse(r.Start);
                gc.maxPrice = decimal.Parse(r.End);
                result = Collect();
            }
            IList<Auction> items = result.Mods.Itemlist.Data.Auctions;
            FilterResult(items,ref finalResult);
            for (int i = 0; i < p.TotalPage; i++)
            {
                if (finalResult.Count >= gc.collectNum) break;
                gc.s += p.PageSize;
                gc.data_value += p.PageSize;
                result = Collect();
                items = result.Mods.Itemlist.Data.Auctions;
                FilterResult(items, ref finalResult);
            }
            return finalResult;
        }
        private void FilterResult(IList<Auction> items, ref List<Auction> finalResult)
        {
            int CommentCount = 0;
            foreach (Auction item in items)
            {
                int.TryParse(item.CommentCount,out CommentCount);
                if (CommentCount < gc.minPayNum || CommentCount > gc.maxPayNum) continue;

                if (gc.gltm)
                {
                    if (item.Shopcard.IsTmall) continue;
                }
                finalResult.Add(item);
                if (finalResult.Count >= gc.collectNum) break;
            }
        }
        //private string DropDownBoxResultHandle(KeySearchResult result)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < result.Result.Count; i++)
        //    {
        //        sb.AppendLine(result.Result[i][0].Replace(this.Key, ""));
        //    }
        //    return sb.ToString();
        //}
        private KeySearchResult Collect()
        {
            string baseUrl = "https://s.taobao.com/search";
            Param param = new Param();
            param.data__key = "s";
            param.data__value = gc.data_value.ToString();
            param.ajax = "true";
            param._ksTS = "1530679427450_1405";
            param.callback = "";
            param.q = gc.keyWord;
            param.refpid = "430267_1006";
            param.source = "tbsy";
            param.style = "grid";
            param.tab = "all";
            param.pvid = "2012ee9ea433deff6428d02b0f006788";
            param.clk1 = "46514d9e4314d81b4a5d7c918df01106";
            param.spm = "a21bo.2017.201856__sline.2.5af911d9mVIzuW";
            param.filter = string.Format("reserve_price[{0},{1}]", gc.minPrice, gc.maxPrice);
            param.bcoffset = "0";
            param.p4ppushleft = ",44";
            param.s = gc.s.ToString();
            string url = RequestUrlHelper.CreateUrl(baseUrl, param);
            CookieContainer cookie = RequestHelper.GetCookie("http://www.taobao.com", "GET");
            string content = RequestHelper.GetContent(cookie, url);
            KeySearchResult result = JsonHelper.DeserializeJsonToObject<KeySearchResult>(content);
            return result;
        }
    }
}
