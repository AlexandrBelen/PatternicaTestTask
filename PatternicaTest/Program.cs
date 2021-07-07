using Newtonsoft.Json;
using PatternicaTest.Mapping;
using PatternicaTest.Models;
using PatternicaTest.Services;
using System;
using System.Collections.Generic;

namespace PatternicaTest
{
    public class Program
    {
        private static string fileLocation = "C:\\Users\\Alexandr\\Desktop\\Test\\PatternicaTest\\Example.xml";        

        static void Main(string[] args)
        {
            IEnumerable<CD> list = CdMapper.ToCd(fileLocation);
            Calculate calculate = new Calculate(fileLocation, list);
            
            try
            {
                ResultModel result = new ResultModel()
                {
                    cdsCount = calculate.Count(),
                    pricesSum = calculate.TotalPrice(),
                    countries = calculate.AddingCountries(),
                    minYear = calculate.MinYear(),
                    maxYear = calculate.MaxYear()
                };
                string jsonResult = JsonConvert.SerializeObject(result, Formatting.Indented);
                Console.Write(jsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}