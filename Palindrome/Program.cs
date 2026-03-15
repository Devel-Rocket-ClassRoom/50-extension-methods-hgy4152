using System;
using System.Linq;
using System.Text.RegularExpressions;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 회문 판별 테스트 ===");
Console.WriteLine($"\"토마토\" -> {"토마토".IsPalindrome()}");
Console.WriteLine($"\"기러기\" -> {"기러기".IsPalindrome()}");
Console.WriteLine($"\"level\" -> {"level".IsPalindrome()}");
Console.WriteLine($"\"Level\" -> {"Level".IsPalindrome()}");
Console.WriteLine($"\"A man, a plan, a canal: Panama\" -> {"A man, a plan, a canal: Panama".IsPalindrome()}");
Console.WriteLine($"\"race a car\" -> {"race a car".IsPalindrome()}");
Console.WriteLine($"\"hello\" -> {"hello".IsPalindrome()}");
Console.WriteLine($"\"가나다\" -> {"가나다".IsPalindrome()}");
Console.WriteLine($"\"\" -> {"".IsPalindrome()}");


static class PalindromeExtension
{
    public static bool IsPalindrome(this string word)
    {
        word = Regex.Replace(word, "\\p{P}", "");
        string result = word.Replace(" ", "").ToLower();
        Console.WriteLine(result);
        
        char[] c = result.ToCharArray();
        Array.Reverse(c);
        string reverse = new string(c);


        return result == reverse;
    }
}
