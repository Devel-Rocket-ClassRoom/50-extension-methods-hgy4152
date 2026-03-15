using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


Console.WriteLine("=== 컬렉션 청킹 테스트 ===");
Console.WriteLine("[숫자를 3개씩 그룹화]");

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (var chunk in numbers.Chunk(3))
{
    Console.WriteLine($"[{string.Join(", ", chunk)}]");
}

Console.WriteLine();

Console.WriteLine("[학생들을 2명씩 팀 구성]");
var students = new List<string> { "김철수", "이영희", "박민수", "최지연", "정우진" };
int count = 1;
foreach (var chunk in students.Chunk(2))
{
    Console.WriteLine($"팀 {count++}: {string.Join(", ", chunk)}");
}

Console.WriteLine();
Console.WriteLine("[페이지별로 5개씩 나누기]");

var pages = new List<int>();

for(int i = 0;  i < 25; i++)
    pages.Add(i+1);

count = 1;
foreach (var chunk in pages.Chunk(5))
{
    Console.WriteLine($"페이지 {count++}: {string.Join(", ", chunk)}");
}


static class IEnumerableExtension
{
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> collection, int size)
    {

        if(size < 1)
        {
            throw new ArgumentException();
        }
        
        List<T> list = new List<T>();

        foreach (T item in collection)
        {
            list.Add(item);

            if(list.Count == size)
            {
                yield return list;
                list = new List<T>();
            }
        }

        if(list.Count > 0) 
            yield return list;
    }

}

