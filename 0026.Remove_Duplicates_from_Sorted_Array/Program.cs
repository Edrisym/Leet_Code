int[] input = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

Solution.RemoveDuplicates(input);

// nums = [0,0,1,1,1,2,2,3,3,4]
//expected = [0,1,2,3,4]

public static class Solution
{
    public static int RemoveDuplicates(int[] nums)
    {
        int current;
        int next;
        var output = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            current = nums[i];
            if (i + 1 < nums.Length)
            {
                next = nums[i + 1];

                if (current == next)
                {
                    output++;
                }
            }
        }
        return output;
    }
}