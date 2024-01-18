using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class SumArray
    {
        public static int[] TwoSum(int[] nums, int target) 
        {
            List<int> ind_num = new List<int>(); 
            int flag = 0, ind=1; 
            bool stop = true;

            while(stop==true) 
            {
                for (int i=ind; i < nums.Length; i++)
                {
                    if (nums[flag] + nums[i] == target)
                    {
                        ind_num.Add(flag);
                        ind_num.Add(i);
                        stop = false;
                        break;
                    }else if (i == nums.Length-1)
                    {
                        flag++;
                        ind++;
                    }
                }
            }
            int[] values_ret = ind_num.ToArray();
            return values_ret;
        }
    }
}
