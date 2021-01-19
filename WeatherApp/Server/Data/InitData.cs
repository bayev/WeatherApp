using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Shared.Models;

namespace WeatherApp.Server.Data
{
    //public class InitData
    //{
        
    //    public static void ReadCSV()
    //    {
    //        string[] resultSet = File.ReadAllLines(@"C:\Users\Azama\Desktop\code\dotnet\blazor-apps\WeatherApp\WeatherApp\Server\Data\TemperaturData.csv");
    //        using (var context = new ApplicationDBContext())
    //        {
    //            foreach (var data in resultSet)
    //            {
    //                WeatherData tmp = new WeatherData();
    //                string[] tmpString = data.Split(",");
    //                tmp.Date = DateTime.Parse(tmpString[0]);
    //                tmp.Location = tmpString[1];
    //                tmp.Temp = decimal.Parse(tmpString[2], CultureInfo.InvariantCulture);
    //                tmp.Humid = int.Parse(tmpString[3], CultureInfo.InvariantCulture);


    //                context.Add(tmp);
    //            }
    //            context.SaveChanges();
    //        }


    //    }

    //}
   
}
    
