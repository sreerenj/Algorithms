using System;

namespace CharCost
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution("aabbcc", new int[]{1,2,1,2,1,2}));
            Console.WriteLine(solution.solution("aaaaaaaaaaaaabbbbbbcccccddddd", new int[]{1,1,1,3,2,5,7,2,9,4,2,8,1,  6,3,4,2,8,1,  6,3,2,1,8,  3,2,9,4,2}));
            Console.WriteLine(solution.solution("aaaab", new int[]{1,1,1,1,4}));
        }
    }

    class Solution
    {
        public int solution(string s, int[] c)
        {
            char[] chars = s.ToCharArray();
            int currentLocation = 0;
            int totalCost= 0;
            while(currentLocation < s.Length-1)
            {
                // abccbd [0,1,2,3,4,5]
                // aaaaaaaaaaaaabbbbbbcccccddddd
                // aabbccdd [0,1,2,3,4,5,6,7]
                if(chars[currentLocation] != chars[currentLocation + 1])
                {
                    currentLocation++;
                    continue;
                }
                else
                {
                    int maxLocation = currentLocation; 
                    int startLocation = currentLocation;
                    
                    while((currentLocation < s.Length -1) && (chars[currentLocation] == chars[currentLocation + 1]))
                    {
                        currentLocation++;
                        if(currentLocation >= s.Length)
                        {
                            break;
                        }
                        if(c[currentLocation] > c[maxLocation])
                        {
                            maxLocation = currentLocation;
                        }
                    }
                    int endLocation =  currentLocation;
                    for(int i = startLocation; i <= endLocation; i++)
                    {
                        if(i != maxLocation)
                        {
                            totalCost+=c[i];
                        }
                    }


                }

            }
            return totalCost;
        }
    }
}
