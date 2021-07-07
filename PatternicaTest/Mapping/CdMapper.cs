using PatternicaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PatternicaTest.Mapping
{
    public static class CdMapper
    {
        public static IEnumerable<CD> ToCd(string path)
        {
            var result = from e in XDocument.Load(path).Descendants("CD")
                         select new CD 
                         { 
                             Title = e.Element("TITLE").Value, 
                             Artist = e.Element("ARTIST").Value,
                             Country = e.Element("COUNTRY").Value,
                             Company = e.Element("COMPANY").Value,
                             Price = Convert.ToDecimal(e.Element("PRICE").Value),
                             Year = Convert.ToInt32(e.Element("YEAR").Value)
                         };
            return result;
        }
    }
}