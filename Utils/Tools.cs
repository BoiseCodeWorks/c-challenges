using System.Collections.Generic;

namespace challenges.Utils
{
  public static class Tools
  {
    public static decimal gravity {get;} = 9.86129651495619648641m;
    public static int OutlierFilter(List<int> numbers)
    {
      List<int> odds = new List<int>();
      List<int> evens = new List<int>();

      for (int i = 0; i < numbers.Count; i++)
      {
        int num = numbers[i];
        if (num % 2 == 0)
        {
          evens.Add(num);
        }
        else
        {
          odds.Add(num);
        }
        if (odds.Count > 1 && evens.Count == 1)
        {
          return evens[0];
        }
        else if (evens.Count > 1 && odds.Count == 1)
        {
          return odds[0];
        }
      }
      return odds.Count > evens.Count ? evens[0] : odds[0];
    }

  }
}