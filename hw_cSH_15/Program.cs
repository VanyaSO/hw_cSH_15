namespace hw_cSH_15;

// JSON прост в сериализации/десириализации 
// просто маштабировать в случае добавлении новых полей
// легко прочитать что в нем записано
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Magazine magFromFile = FileSystem.LoadFromFile("magazine.json");
            Console.WriteLine(magFromFile);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        
        
        // Magazine mag = Magazine.CreateMagazine();
        // Console.WriteLine(mag);

        // Console.WriteLine();
        // Console.WriteLine("Enter path and file name \nOr press Enter and file will be saved by default path with name \"magazine.json\"");
        // string path = Console.ReadLine();
        // FileSystem.SaveToFile(mag, path);
    }
}