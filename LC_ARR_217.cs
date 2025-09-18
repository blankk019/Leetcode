namespace leetcode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==============");
            int[] nums = { 5, 1, 2, 3, 4};
            Console.WriteLine(hasDuplicate(nums));
        }
        /*
         * BRUTE FALSE SOLUTION WITH COMPLEXITY OF N2
        public static bool hasDuplicate(int[] nums)
        {   
            for(int j =  0; j < nums.Length;j++)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (i == j) continue;
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }

            }
            return false;
        }   */

        //MOST OPTIMUM SOLUTION WITH TIME COMPLEXITY OF O(n) cuz it loops once 
        //space complexity of O(n) cuz it saves up space for a hashset
        public static bool hasDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i])) { return true; }
                set.Add(nums[i]);
                
            }
            Console.WriteLine(string.Join(", ", set));
            return false;
        }
    }
}