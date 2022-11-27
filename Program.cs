
namespace NumberofUnequalTripletsinArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int UnequalTriplets(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                HashSet<int> dist = new HashSet<int> { nums[i] };
            }

            HashSet<int> vals = nums.ToHashSet();
            double div = nums.Length / 3;
            if(vals.Count > (int)vals.Count)
            {
                return (int)div + 1;
            }
            else
            {

            }
            if (vals.Count >= 3 && nums.Length == 3)
                return 1;
            if (vals.Count >= 3)
                return vals.Count;
            return 0;
        }
    }
}