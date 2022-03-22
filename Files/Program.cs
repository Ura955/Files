string path = Console.ReadLine();

if (!File.Exists(path))
{
    Console.WriteLine(path);
    Console.WriteLine("Файл не найден!");
    return;
}

List<string> list = new List<string>();

using (StreamReader sr = new StreamReader(path))
{
    string s;
    while (!sr.EndOfStream)
    {
        s = sr.ReadLine();
        string[] split = s.Split(' ');
        
        for (int i = 0; i < split.Length; i++)
        {
            if (split[i] != "")
            {
                list.Add(split[i]);
            }
            else
            {
                continue;
            }
        }
    }
    sr.Close();
}

for (int i = 0; i < list.Count - 1; i++)
{
    string ec = list[i].Substring(list[i].Length - 1);
    string sc = list[i + 1].Substring(0, 1);
    
    if (ec == sc)
    {
        Console.WriteLine(list[i] + "\t" + list[i+1]);
    }

}
