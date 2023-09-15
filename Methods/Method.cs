using AttributesConsoleTestProject.Attributes;
namespace AttributesConsoleTestProject.Methods;

public static class Method
{
    [Firts(5)]
    public static void WriteWord(string word)
    {
        Console.WriteLine($"the word length is: {word.Length}");
        Console.WriteLine($"and the eord is: {word} ");
        
    }
}