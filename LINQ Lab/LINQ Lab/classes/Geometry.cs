using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Text;
using System.Collections.Generic;

namespace LINQ_Lab.classes
{
    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }
}