using System;

// README.md를 읽고 코드를 작성하세요.

string hi = " hello world ";

string result1 = StringExtensions.Replace(StringExtensions.Upper(StringExtensions.Trim(hi)), ' ', '_');
string result2 = hi.Trim().Upper().Replace(' ', '_');

Console.WriteLine("결과1: " + result1);
Console.WriteLine("결과2: " + result2);

SecretBox secret = new SecretBox();

Console.WriteLine($"공개 데이터: {secret.Print()}");


Greeter g = new Greeter();

Console.Write($"인스턴스 메서드:");
g.SayHello();
Console.Write($"확장 메서드:");
g.SayGoodbye();
Console.Write($"확장 메서드:");
GreeterExtensions.SayHello(g);


static class StringExtensions
{
    public static string Upper(this string text)
    {
        return text.ToUpper();
    }

    public static string Trim(this string text)
    {
        return text.Trim();
    }

    public static string Replace(this string text, char oldChar, char newChar)
    {
        return text.Replace(oldChar, newChar).ToString();
    }
}

class SecretBox
{
    private string _secret;
    public string PublicData = "공개";

}


static class SecretBoxExtensions
{
    public static string data;

    public static string secret;

    public static string Print(this SecretBox secretBox)
    {
        return data = secretBox.PublicData;
    }
}

class Greeter
{
    public void SayHello()
    {
        Console.WriteLine("안녕하세요");
    }
}

static class GreeterExtensions
{
    public static void SayHello(this Greeter g)
    {
        Console.WriteLine("반갑습니다");

    }

    public static void SayGoodbye(this Greeter g)
    {
        Console.WriteLine("안녕히 가세요");

    }
}