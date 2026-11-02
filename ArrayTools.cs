/// <summary>
/// Provides methods for searching, inserting, removing, and displaying elements in an array.
/// </summary>
public static class ArrayTools
{
    /// <summary>
    /// Finds the index of the first matching value in the array.
    /// </summary>
    /// <param name="data">The array to search.</param>
    /// <param name="count">The number of elements currently in use.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the first matching value, or -1 if not found.</returns>
    public static int IndexOf(int[] data, int count, int target)
    {
        for (int i = 0; i < count; i++)
        {
            if (data[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// Inserts a value at the specified index by shifting active elements to the right.
    /// </summary>
    /// <param name="data">The array containing the values.</param>
    /// <param name="count">The number of elements currently in use.</param>
    /// <param name="index">The index where the value will be inserted.</param>
    /// <param name="value">The value to insert.</param>
    /// <returns>The updated number of elements in use.</returns>
    public static int InsertAt(int[] data, int count, int index, int value)
    {
        for (int i = count; i > index; i--)
        {
            data[i] = data[i - 1];
        }

        data[index] = value;
        return count + 1;
    }

    /// <summary>
    /// Removes an element at the specified index by shifting active elements to the left.
    /// </summary>
    /// <param name="data">The array containing the values.</param>
    /// <param name="count">The number of elements currently in use.</param>
    /// <param name="index">The index of the element to remove.</param>
    /// <returns>The updated number of elements in use.</returns>
    public static int RemoveAt(int[] data, int count, int index)
    {
        for (int i = index; i < count - 1; i++)
        {
            data[i] = data[i + 1];
        }

        return count - 1;
    }

    /// <summary>
    /// Returns the active array elements as a space separated string.
    /// </summary>
    /// <param name="data">The array containing the values.</param>
    /// <param name="count">The number of elements currently in use.</param>
    /// <returns>A formatted string containing the active elements.</returns>
    public static string Show(int[] data, int count)
    {
        string result = "";
        for (int i = 0; i < count; i++)
        {
            if (i > 0)
            {
                result += " ";
            }
            result += data[i];
        }
        return result;
    }
}