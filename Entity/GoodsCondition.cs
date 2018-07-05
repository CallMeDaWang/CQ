using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQ.Entity
{
    public class GoodsCondition
    {
        public string keyWord { get; set; }
        public bool gltm { get; set; }
        public int maxPayNum  { get; set; }
        public int minPayNum { get; set; }
        public decimal minPrice { get; set; }
        public decimal maxPrice { get; set; }
        public int collectNum { get; set; }
        public bool userLike { get; set; }
        public int  s { get; set; }
        public int data_value { get; set; }
        public GoodsCondition()
        {
            s = 0;
            data_value = 44;
            gltm = true;
            gltm = false;
            maxPayNum = 200;
            minPayNum = 5;
            minPrice = 15;
            maxPrice = 600;
            collectNum = 300;
        }
    }
}
