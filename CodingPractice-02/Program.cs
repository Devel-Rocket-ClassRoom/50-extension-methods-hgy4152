using System;

// README.md를 읽고 코드를 작성하세요.


Console.WriteLine("안녕하세요".First(3));

Player player1 = new Player()
{
    Name = "용사",
    Level = 5,
    Experience = 150
};

Console.WriteLine(player1.GetInfo());
Console.WriteLine($"레벨업 가능? {player1.CanLevelUp()}");
player1.LevelUp();
Console.WriteLine(player1.GetInfo());





static class StringExtensions
{
    public static string First(this string text, int count)
    {
        if(text == null)
            return null;
        else if(count > text.Length)
            return text;


        return text.Substring(0, count);
    }
}


class Player
{
    public string Name;
    public int Level;
    public int Experience;
}

static class PlayerExtensions
{
    public static string GetInfo(this Player player)
    {
        return $"[{player.Name}] 레벨: {player.Level}, 경험치: {player.Experience}";
    }

    public static bool CanLevelUp(this Player player)
    {
        return player.Experience >= 100;
    }

    public static void LevelUp(this Player player)
    {
        player.Level++;
        player.Experience -= 100;

        Console.WriteLine($"{player.Name}이(가) 레벨업! 현재 레벨: {player.Level}");
    }
}