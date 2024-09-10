static int[] TwoSum(int[] nums, int target)
{
    var numIndices = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (numIndices.TryGetValue(complement, out var index))
        {
            return [index, i];
        }

        if (!numIndices.TryGetValue(nums[i], out _))
        {
            numIndices[nums[i]] = i;
        }
    }

    return Array.Empty<int>();
}

int[] nums = [2, 7, 11, 15];
//[2,7,11,15]
var target = 9;
var output = TwoSum(nums, target);

Console.WriteLine($"[{string.Join(",", output)}]");