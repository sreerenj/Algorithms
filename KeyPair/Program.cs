using System;
using System.Collections.Generic;

public class GFG {
	static public void Main () {
	    int T = Convert.ToInt32(Console.ReadLine());
	    for(int i = 0; i < T; i++)
	    {
	        string[] strNums = Console.ReadLine().Split(' ');
	        int N = Convert.ToInt32(strNums[0]);
	        int X = Convert.ToInt32(strNums[1]);
	        
	        string[] strNumbers = Console.ReadLine().Split(' ');
	        int[] numbers = new int[N];
	        HashSet<int> hashset = new HashSet<int>();
	        bool isExist = false;
	        for(int j = 0; j < N; j++)
	        {
	            numbers[j] = Convert.ToInt32(strNumbers[j]);
	            int mod = numbers[j] % X;
                Console.WriteLine(mod + " " + numbers[j]);
	            if(hashset.Contains(mod))
	            {
	                isExist = true;
	                break;
	            }
	            hashset.Add(numbers[j]);
	        }   
	        if(isExist)
	        {
	            Console.WriteLine("Yes");
	        }
	        else
	        {
	            Console.WriteLine("No");
	        }
	    }
	}
}