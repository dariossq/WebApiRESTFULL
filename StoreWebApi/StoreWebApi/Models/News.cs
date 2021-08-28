using System;
using System.Collections.Generic;

namespace StoreWebApi.Models
{
    public partial class News
    {
        public int NewId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }
        public int CurrentWeatherId { get; set; }

        public CurrentWeather CurrentWeather { get; set; }
    }
}
