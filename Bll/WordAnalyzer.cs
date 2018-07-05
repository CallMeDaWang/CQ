using IKAnalyzerNet;
using Lucene.Net.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQ.Bll
{
    public class WordAnalyzer
    {
        public Dictionary<string, int> GetParticipleResult(string article)
        {
            String slen = article.Length.ToString();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            IKAnalyzer ika = new IKAnalyzer();
            System.IO.TextReader r = new System.IO.StringReader(article);
            TokenStream ts = ika.TokenStream("TestField", r);
            int m = 0;
            long begin = System.DateTime.Now.Ticks;
            for (Token t = ts.Next(); t != null; t = ts.Next())
            {
                m++;
                dic.ContainsKey(t.TermText());
                if (dic.ContainsKey(t.TermText()))
                {
                    dic[t.TermText()] += 1;
                }
                else
                {
                    dic.Add(t.TermText(), 1);
                }
            }
            dic = (from entry in dic
                            orderby entry.Value descending
                            select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
            return dic;
        }
        //    String testString = rtfRichtxtInput.Text;
        //    String slen = testString.Length.ToString();

        //    IKAnalyzer ika = new IKAnalyzer();

        //    System.IO.TextReader r = new System.IO.StringReader(testString);
        //    TokenStream ts = ika.TokenStream("TestField", r);
        //    int m = 0;
        //    long begin = System.DateTime.Now.Ticks;
        //        for (Token t = ts.Next(); t != null; t = ts.Next())
        //        {
        //            m++;
        //            rtfRichTxtResult.Text += m + ")" + (t.StartOffset() + "," + t.EndOffset() + " = " + t.TermText()) + "\r\n";
        //        }

        //int end = (int)((System.DateTime.Now.Ticks - begin) / 10000);

        //rtfRichTxtResult.Text += ("长度：" + slen + " 耗时： " + (end) + "ms" + " 分词个数：" + m + " 效率(词/秒)：" + ((int)(m* 1.0f / (end) * 1000))) + "\r\n";

    }
}
