//Challenge Lab 3.4

Console.WriteLine("Input string: ");
string s = Console.ReadLine().ToUpper();

int result = MinStringLegth(s);
Console.WriteLine($"Output: { result}");

int MinStringLegth (string s) {
    while (s.Contains("AB") || s.Contains("CD"))
    {
        s = s.Replace("AB", "");
        s = s.Replace("CD", "");
    }
    
    return s.Length;
}
