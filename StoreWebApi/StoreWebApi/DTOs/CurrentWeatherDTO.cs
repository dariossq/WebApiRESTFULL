using System;
using System.Collections.Generic;

namespace StoreWebApi.DTOs
{
    public partial class CurrentWeatherDTO
    {
        
        public int CurrentWeatherId { get; set; }
        public TimeSpan? ObservationTime { get; set; }
        public decimal? Temperature { get; set; }
        public string WeatherDescriptions { get; set; }
        public decimal? WindSpeed { get; set; }
        public decimal? WindDegree { get; set; }
        public string WindDir { get; set; }
        public decimal? Pressure { get; set; }
        public decimal? Precip { get; set; }
        public decimal? Humidity { get; set; }
        public decimal? Cloudcover { get; set; }
        public decimal? Feelslike { get; set; }
        public decimal? UvIndex { get; set; }
        public decimal? Visibility { get; set; }

        public List<NewsDTO> News { get; set; }
    }
}
