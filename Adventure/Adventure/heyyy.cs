using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure
{
    class adding
     static string Add(int x,int y)
    {
        int sum = x + y;
        return String.Format($"{sum} is the result of {x} plus {y}");
    }
}
