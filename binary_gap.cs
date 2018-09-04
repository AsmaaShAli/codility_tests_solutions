using System;
// you can also use other imports, for example:
 using System.Collections.Generic;
 using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution( long N)
    {
        string s = Convert.ToString(N, 2);

            if (multiple_of_two(N) || multiple_of_two(N + 1))
               return 0;
             else if (multiple_of_two(N - 1))
               return (s.Length - 2);
            else
            {               
                 int g = calculate_gap(s);
                 return g;
             }
    }

 public static bool multiple_of_two(long x)
        {
            if ( x % 2 != 0 )
                return false;
            else if (x == 2)
                return true;
            else
            {
                x /= 2;
                return multiple_of_two(x);
            }
        }

        public static int calculate_gap(string binary)
        {
           bool currently_one = false;
            int gap = 0;
            int []gap_values = new int[10];
            int index = 0 ;
            for (int i = 1; i < binary.Length; i++)
            {
                
                if (binary[i] == '0')
                {
                    currently_one = false;
                    gap++;
                }
                else if (binary[i] == '1')
                {
                    if (currently_one)
                        continue;
                    else
                        currently_one = true;
                        gap_values[index++] = gap;
                        gap = 0;
                }
            }
            return gap_values.Max();
        }
        
}