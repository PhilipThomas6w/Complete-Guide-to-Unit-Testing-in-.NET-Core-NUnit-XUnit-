using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky;

public class Fibo
{
    public int Range { get; set; }

    public Fibo()
    {
        Range = 5;
    }

    public List<int> GetFibonacciSeries()
    {
        var fibonacciSeries = new List<int> { };
        int a = 0, b = 1, c = 0;

        if (Range == 1)
        {
            fibonacciSeries.Add(0);
            return fibonacciSeries;
        }
        fibonacciSeries.Add(0);
        fibonacciSeries.Add(1);

        for (int i = 2; i < Range; i++)
        {
            c = a + b;
            fibonacciSeries.Add(c);
            a = b;
            b = c;
        }

        return fibonacciSeries;
    }

    





}