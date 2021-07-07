using System.Collections.Generic;

namespace PatternicaTest.Models
{
    class ResultModel
    {
        public int cdsCount { get; set; }
        public decimal pricesSum { get; set; }
        public List<string> countries { get; set; }
        public int minYear { get; set; }
        public int maxYear { get; set; }
    }
}