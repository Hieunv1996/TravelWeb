using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel.Common
{
    public class Alert
    {
        public string Content { get; set; }
        public string Type { get; set; }


        public Alert(string c, string t)
        {
            this.Content = c;
            this.Type = t;
        }
        public Alert() { }
    }
}