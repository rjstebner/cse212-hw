using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
{
    // Create a list to store the multiples
    List<double> multiples = new List<double>();
    
    // Loop from 0 to length-1
    for (int i = 0; i < length; i++)
    {
        // Add the multiple of the number to the list
        multiples.Add(number * (i + 1));
    }
    
    // Convert the list to an array and return it
    return multiples.ToArray();
}


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem 
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // Step 1: Calculate the effective rotation, which is the amount modulo the count of the list. Only really necessary if the amount is greater than the count.
        int count = data.Count;
        amount = amount % count;

        // Step 2: Handle edge cases in the case that no rotation is necassary.
        if (count == 0 || amount == 0) return;

        // Step 3: Create a temporary list
        List<int> temp = new List<int>(data);

        // Step 4: Reassign elements to the original data list
        for (int i = 0; i < count; i++)
        {
            data[(i + amount) % count] = temp[i];
        }

    }
}

