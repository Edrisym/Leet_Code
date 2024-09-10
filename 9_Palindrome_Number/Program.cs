static bool IsPalindrome(int x)
{
        var reversedNumber = string.Concat(x.ToString().Reverse());
        return reversedNumber == x.ToString();
}