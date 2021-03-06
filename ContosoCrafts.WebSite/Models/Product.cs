﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {
        public string Id { get; set; }

        public string Maker { get; set; }

        [JsonProperty("img")]
        public string Image { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int[] Ratings { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
