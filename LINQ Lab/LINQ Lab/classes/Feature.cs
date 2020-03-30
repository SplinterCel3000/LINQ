using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Text;
using System.Collections.Generic;

namespace LINQ_Lab.classes
{
    public class Feature
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("geomerty")]
        public Geometry geometry { get; set; }

        [JsonProperty("properties")]
        public Properties properties { get; set; }
    }
}