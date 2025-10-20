namespace _13_Roman_to_Integer;
public static class SolutionRomanToIntFun
{
    public static int RomanToIntFun(string s)
    {
        var output = 0;
        var map = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        for (var i = 0; i < s.Length; i++)
        {
            var current = map[s[i]];
            if (i + 1 < s.Length)
            {
                var next = map[s[i + 1]];

                if (current < next)
                {
                    output -= current;
                }
                else
                {
                    output += current;
                }
            }
            else
            {
                output += current;
            }
        }

        return output;
    }
}