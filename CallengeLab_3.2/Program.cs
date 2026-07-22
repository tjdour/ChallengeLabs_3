//Challenge Lab 3.2

//prompt for sting
Console.WriteLine("Enter a string: ");
string input = Console.ReadLine();

//print result
int result = SumDigitsInString(input);
Console.WriteLine(result);

//method to find sum of digits in a string
int SumDigitsInString(string input)
{
    int sum = 0;
    foreach (char c in input)
    {
        if (c >= '0' && c <= '9')
        {
            int num = c - '0';
            sum += num;

        }
    }

    return sum;
}