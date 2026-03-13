using System;
using System.Collections.Generic;
using System.Text;
// README.md를 읽고 코드를 작성하세요.


Console.WriteLine($"'hello' 대문자로 시작? {"hello".IsCapitalized()}");
Console.WriteLine($"첫 글자 대문자: {"hello".Capitalize()}");
Console.WriteLine($"뒤집기: {"hello".Reverse()}");

string str = "안녕하세요 반갑습니다 좋은 하루 되세요";
string str1 = "안녕하세요 반갑습니다 좋은 하루 되세요"
    .Take(10)
    .AddEllipsis()
    .AddPrefix("[메시지] ")
    .AddSuffix(" (더보기)");

Console.WriteLine("원본: " + str);
Console.WriteLine("결과: " + str1);


string[] names = { "철수", "영희", "민수" };
List<int> emptyList = new List<int>();

Console.WriteLine($"names 비어있음? {names.IsEmpty()}");
Console.WriteLine($"emptyList 비어있음? {emptyList.IsEmpty()}");
Console.WriteLine($"names 요소 있음? {names.HasItems()}");

Console.WriteLine();
Console.WriteLine("이름 목록:");
names.ForEach(x => Console.WriteLine($" - {x}"));

static class StringExtensions
{
    public static bool IsCapitalized(this string text)
    {

        return char.ToUpper(text[0]) == text[0];
    }
    public static string Capitalize(this string text)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(text);

        sb[0] = char.ToUpper(sb[0]);

        return sb.ToString();
        
    }
    public static string Reverse(this string text)
    {
        char[] chars = text.ToCharArray();
        
        Array.Reverse(chars);

        return new string(chars);
    }
}

static class StringChainExtensions
{
    public static string AddPrefix(this string text, string prefix)
    {
    
        return prefix + text;
    }
    public static string AddSuffix(this string text, string suffix)
    {
        return text + suffix;
    }
    public static string Take(this string text, int count)
    { 
        return text.Substring(0, count);
    }
    public static string AddEllipsis(this string text)
    {
        return text + "...";
    }
}

static class CollectionExtensions
{
    public static bool IsEmpty<T>(this ICollection<T> collection)
    {
        return collection.Count == 0;
    }

    public static bool HasItems<T>(this ICollection<T> collection)
    {
        return collection.Count != 0;
    }

    public static void ForEach<T>(this IList<T> list, Action<T> action)
    {
        foreach (var item in list) 
        {
            action(item);
        }
    }
}