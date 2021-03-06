﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Classes.Models.Business
{
    public class InstaBusinessCategory
    {
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }
    }
    public class InstaBusinessCategoryList : List<InstaBusinessCategory> { }

  
    public class InstaBusinessSugesstedCategory : InstaBusinessCategory
    {
        [JsonProperty("super_cat_name")]
        public string SuperCatName { get; set; }
        [JsonProperty("super_cat_id")]
        public string SuperCatIid { get; set; }
    }
    public class InstaBusinessSugesstedCategoryList : List<InstaBusinessSugesstedCategory> { }


    internal class InstaBusinessCategoryContainer
    {
        [JsonExtensionData]
        internal IDictionary<string, JToken> Extras { get; set; }
    }
}
