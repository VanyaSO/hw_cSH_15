using Newtonsoft.Json;

namespace hw_cSH_15;

public static class FileSystem
{
    private static string BuildDefPath(string path) => path.Length == 0 ? "magazine.json" : $"{path.Trim()}";
    public static string SerializationMagazine(Magazine obj) => JsonConvert.SerializeObject(obj);
    
    public static void SaveToFile(string serializedObj, string path)
    {
        string buildPath = BuildDefPath(path);
        File.WriteAllText(buildPath, serializedObj);
    }
    public static void SaveToFile(Magazine obj, string path)
    {
        string SerializedObj = SerializationMagazine(obj);
        string buildPath = BuildDefPath(path);
        File.WriteAllText(buildPath, SerializedObj);
    }

    public static Magazine LoadFromFile(string path)
    {
        Magazine mag;
        
        string buildPath = BuildDefPath(path);
        if (File.Exists(buildPath))
        {
            string json = File.ReadAllText(buildPath);
            mag = JsonConvert.DeserializeObject<Magazine>(json);
        }
        else 
            throw new Exception("File not found");

        return mag;
    }
}