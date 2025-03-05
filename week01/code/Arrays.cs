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

        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        //
        // Step 1: Create a new array of doubles with the length specified by the 'length' parameter
        // Step 2: Loop through the array and set value for each element multiplying the number
        // Step 3: Return the array

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples; // replace this return statement with your own
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
        //
        // Step 1: Create a new list of integers to store the rotated list
        // Step 2: Loop through the data list and add the elements to the rotated list starting from the index of data.Count - amount
        // Step 3: Loop through the data list again and add the elements to the rotated list starting from the beginning of the list
        // Step 4: Copy the rotated list to the data list

        List<int> rotatedList = new List<int>();
        for (int i = data.Count - amount; i < data.Count; i++)
        {
            rotatedList.Add(data[i]);
        }
        for (int i = 0; i < data.Count - amount; i++)
        {
            rotatedList.Add(data[i]);
        }
        data.Clear();
        data.AddRange(rotatedList);

    }
}
