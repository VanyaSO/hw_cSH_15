namespace hw_cSH_15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FileSystem.LoadFromFile("magazine.json"));
        
        // Magazine mag = Magazine.CreateMagazine();
        // Console.WriteLine(mag);

        // Console.WriteLine();
        // Console.WriteLine("Enter path and name file without extension \nOr press Enter and file will be saved by default path with name \"magazine.json\"");
        // string path = Console.ReadLine();
        // FileSystem.SaveToFile(mag, path);
    }
}