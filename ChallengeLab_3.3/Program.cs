
//Challenge Lab 3.3


//get array size and values
Console.WriteLine("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Input value for index {i}: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}


//target to find
Console.WriteLine("Enter target: ");
int target = Convert.ToInt32(Console.ReadLine());


//call method, store result in array, print array indices
int[] result = FindIndices(nums, target);
Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
 


//method to find index locations of target sum
int[]  FindIndices(int[] nums, int target)
{
    

    //outer loop starts at first index
    for (int i = 0; i < nums.Length; i++)
    {
        //inner loop to start at second index then increment by one
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };   //retrun int array of locations containing index values totaling target
            }
        }

        
    }
    return new int[] { -1, -1 };  //return int array indicating no indexes added total target
}

