Console.WriteLine("Введите строки через зпятую");
string[] words = Console.ReadLine().Split(",");
for(int i=0; i<words.Length; i++)
{
    if(words[i].Length<=3)
        Console.WriteLine(words[i]);
}