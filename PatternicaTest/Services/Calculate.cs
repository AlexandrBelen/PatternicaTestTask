using PatternicaTest.Interfaces;
using PatternicaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace PatternicaTest.Services
{
    public class Calculate : ICalculate
    {
        private static List<CD> cds { get; set; }
        private static XmlDocument _doc { get; set; }
        
        public Calculate(string file, IEnumerable<CD> list)
        {
            try
            {
                _doc = new XmlDocument();
                _doc.Load(file);
                cds = list.ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Count()
        {
            return cds.Count;
        }

        public decimal TotalPrice()
        {
            decimal sum = 0;
            foreach (var item in cds)
            {
                sum += item.Price;
            }
            return sum;
        }

        public int MinYear()
        {
            int minYear = cds[0].Year;
            foreach (var item in cds)
            {
                if (minYear > item.Year) minYear = item.Year;
            }
            return minYear;
        }

        public int MaxYear()
        {
            int maxYear = cds[0].Year;
            foreach (var item in cds)
            {
                if (maxYear < item.Year) maxYear = item.Year;
            }
            return maxYear;
        }

        public List<string> AddingCountries()
        {
            List<string> countries = new List<string>();
            foreach(var item in cds)
            {
                if (!countries.Contains(item.Country)) countries.Add(item.Country);
            }
            return countries;
        }
    }
}