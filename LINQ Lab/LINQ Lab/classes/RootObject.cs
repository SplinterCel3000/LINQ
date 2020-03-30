using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace LINQ_Lab.classes
{
    public class RootObject
    {
        public string type { get; set; }
        [JsonProperty("features")]
        public List<Feature> features { get; set; }
    }
}
