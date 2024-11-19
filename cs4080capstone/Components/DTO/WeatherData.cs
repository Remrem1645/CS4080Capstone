using System.Text.Json.Serialization;

// https://www.weatherapi.com/api-explorer.aspx
namespace cs4080capstone.Components.DTO
{
    public class WeatherDataResponse
    {
        [JsonPropertyName("location")]
        public required Location Location { get; set; }

        [JsonPropertyName("current")]
        public required Current Current { get; set; }
    }

    public class Location
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("lat")]
        public double? Lat { get; set; }
        
        [JsonPropertyName("lon")]
        public double? Lon { get; set; }
        
        /*
        public string? Country { get; set; }
        public string? Tz_Id { get; set; }
        public long? Localtime_Epoch { get; set; }
        public string? Localtime { get; set; }
        */
    }

    public class Current
    {
        [JsonPropertyName("temp_c")]
        public double? Temp_C { get; set; }
        
        [JsonPropertyName("temp_f")]
        public double? Temp_F { get; set; }

        [JsonPropertyName("is_day")]
        public int? Is_Day { get; set; }

        [JsonPropertyName("condition")]
        public required Condition Condition { get; set; }

        /*
        public long? Last_Updated_Epoch { get; set; }
        public string? Last_Updated { get; set; }
        public double? Wind_Mph { get; set; }
        public double? Wind_Kph { get; set; }
        public int? Wind_Degree { get; set; }
        public string? Wind_Dir { get; set; }
        public double? Pressure_Mb { get; set; }
        public double? Pressure_In { get; set; }
        public double? Precip_Mm { get; set; }
        public double? Precip_In { get; set; }
        public int? Humidity { get; set; }
        public int? Cloud { get; set; }
        public double? Feelslike_C { get; set; }
        public double? Feelslike_F { get; set; }
        public double? Vis_Km { get; set; }
        public double? Vis_Miles { get; set; }
        public double? Uv { get; set; }
        public double? Gust_Mph { get; set; }
        public double? Gust_Kph { get; set; }
        */
    }

    public class Condition
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        /*
        public string? Icon { get; set; }
        public int? Code { get; set; }
        */
    }
}


/*

Example JSON Response:

{
    "location": {
        "name": "Diamond Bar",
        "region": "California",
        "country": "United States of America",
        "lat": 34.029,
        "lon": -117.809,
        "tz_id": "America/Los_Angeles",
        "localtime_epoch": 1731982576,
        "localtime": "2024-11-18 18:16"
    },
    "current": {
        "last_updated_epoch": 1731982500,
        "last_updated": "2024-11-18 18:15",
        "temp_c": 13.3,
        "temp_f": 55.9,
        "is_day": 0,
        "condition": {
            "text": "Partly cloudy",
            "icon": "//cdn.weatherapi.com/weather/64x64/night/116.png",
            "code": 1003
        },
        "wind_mph": 6.3,
        "wind_kph": 10.1,
        "wind_degree": 223,
        "wind_dir": "SW",
        "pressure_mb": 1015.0,
        "pressure_in": 29.96,
        "precip_mm": 0.0,
        "precip_in": 0.0,
        "humidity": 77,
        "cloud": 75,
        "feelslike_c": 12.6,
        "feelslike_f": 54.6,
        "windchill_c": 14.0,
        "windchill_f": 57.2,
        "heatindex_c": 14.6,
        "heatindex_f": 58.2,
        "dewpoint_c": 6.9,
        "dewpoint_f": 44.4,
        "vis_km": 16.0,
        "vis_miles": 9.0,
        "uv": 0.0,
        "gust_mph": 9.2,
        "gust_kph": 14.8
    }
}

*/