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
    public class Data8
    {

        [JsonProperty("sortList")]
        public IList<SortList> SortList { get; set; }

        [JsonProperty("pager")]
        public Pager2 Pager { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("filter")]
        public IList<Filter> Filter { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }
    }

}
