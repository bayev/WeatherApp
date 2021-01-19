using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Shared.Models
{
     public class WeatherData
    {
        
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public string Location { get; set; }
            public decimal Temp { get; set; }
            public int Humid { get; set; }
        
    }
}
