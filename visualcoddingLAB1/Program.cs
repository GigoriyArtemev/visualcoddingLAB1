using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            HW1.QueueTime(new int[] { 2, 3 }, 2);
            HW1.QueueTime(new int[] { 1, 1, 1}, 1);
            HW1.QueueTime(new int[] { 10, 3, 2 }, 2);
        }
    }


    public class HW1
    {
        public static long QueueTime(int[] pokupateli, int n)
        {
            int k = 0;
            int ind = 0;
            int[] cass = new int[n]; 

            for (int i = 0; i < n; i++)
            {
                cass[i] = pokupateli[i];
                k++;
            }
            ind = k;
            bool shouldBrack = false;
            k = 0;
           while (true)
            {
                shouldBrack=true;
                for(int i=0; i<n; i++)
                {
                    cass[i] -= 1; 
                    if ((cass[i] == 0)&& (ind < pokupateli.Length))
                    {
                            cass[i] = pokupateli[ind];
                            ind++; 
                    }
                    if (i == n - 1)
                    {
                        k++;
                    }
                    if (cass[i] >0)
                    {
                        shouldBrack = false;
                    }
                }
                if ((shouldBrack == true))
                {
                    break;
                }
            }
            Console.WriteLine(k);
            return 0;
        }

    }
}