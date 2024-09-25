var num = SingleNumber(2, 2, 1);
Console.WriteLine(num);

static int SingleNumber(params int[] nums)
{
    var result = 0;
    foreach (var num in nums)
    {
        result ^= num;
    }

    return result;


    // var fn = 0;
    //
    // if (nums.Length == 1)
    // {
    //     return nums[0];
    // }
    //
    // foreach (var t in nums)
    // {
    //     for (var j = 1; j < nums.Length;)
    //     {
    //         var sn = nums[j];
    //
    //         var s = t - sn;
    //
    //         if (s != 0)
    //         {
    //             return t;
    //         }
    //
    //         return sn;
    //     }
    // }
    //
    // return fn;
}