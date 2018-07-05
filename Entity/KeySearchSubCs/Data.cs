﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CQ.Entity;

namespace CQ.Entity
{

    [Obfuscation(Feature = "trigger", Exclude = false)]
    public class Data
    {

        [JsonProperty("postFeeText")]
        public string PostFeeText { get; set; }

        [JsonProperty("trace")]
        public string Trace { get; set; }

        [JsonProperty("auctions")]
        public IList<Auction> Auctions { get; set; }

        [JsonProperty("recommendAuctions")]
        public IList<object> RecommendAuctions { get; set; }

        [JsonProperty("isSameStyleView")]
        public bool IsSameStyleView { get; set; }

        [JsonProperty("sellers")]
        public IList<object> Sellers { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("spmModId")]
        public string SpmModId { get; set; }

        [JsonProperty("clickstaturl")]
        public string Clickstaturl { get; set; }
    }

}