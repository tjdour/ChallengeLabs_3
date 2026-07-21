

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a word to check if Palindrome: ");
        string pal = Console.ReadLine();

        Console.WriteLine($"is {pal} a palindrome? {isPal(pal)}");

        bool isPal(string pal)
        {

            int left = 0;
            int right = pal.Length - 1;

            while (left < right)
            {

                if (pal[left] != pal[right])
                {
                    return false;
                }
                left++;
                right--;
            }


            return true;

       }
    }
}
 