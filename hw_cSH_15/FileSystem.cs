using Newtonsoft.Json;

namespace hw_cSH_15;

public static class FileSystem
{
    private static string SerializationMagazine(Magazine obj) => JsonConvert.SerializeObject(obj);
    
    public static void SaveToFile(Magazine obj, string path)
    {
        string SerializedObj = SerializationMagazine(obj);
        string buildPath = path.Length == 0 ? "magazine.json" : $"{path.Trim()}.json";
        File.WriteAllText(buildPath, SerializedObj);
    }

    public static Magazine LoadFromFile(string path)
    {
        Magazine mag = null;
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            mag = JsonConvert.DeserializeObject<Magazine>(json);
        }

        return mag;
    }
}