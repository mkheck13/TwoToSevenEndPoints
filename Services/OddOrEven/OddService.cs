

namespace TwoToSevenEndPoints.Services.OddOrEven
{
    public class OddService : IOddService
    {
         public string OddOrEven(int num1)
        {
            if (num1 % 2 != 0)
            {
                return $"{num1} is odd";
            }
            else
            {
                return $"{num1} is even";
            }
        }
    }
}