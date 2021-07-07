using System.Collections.Generic;

namespace PatternicaTest.Interfaces
{
    public interface ICalculate
    {
        int Count();
        decimal TotalPrice();
        int MinYear();
        int MaxYear();
        List<string> AddingCountries();
    }
}