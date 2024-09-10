//"abc", t = "ahbgdc" true
//"axc", t = "ahbgdc" false

var s = "axc";
var t = "ahbgdc";

var output = IsSubsequence(s, t);
Console.WriteLine(1);


static bool IsSubsequence(string s, string t)
{
    var i = 0;
    int j = 0;
    while (j < t.Length)
    {
        if (i < s.Length && s[i] == t[j])
        {
            i++;
        }

        j++;
    }

    return i == s.Length;
}