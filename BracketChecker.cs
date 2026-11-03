/// <summary>
/// Provides methods for checking whether brackets are correctly matched and balanced.
/// </summary>
public static class BracketChecker
{
    /// <summary>
    /// Determines whether all opening brackets in a string are closed in the correct order.
    /// </summary>
    /// <param name="text">The string to check for balanced brackets.</param>
    /// <returns>True if the brackets are balanced; otherwise, false.</returns>
    public static bool IsBalanced(string text)
    {
        MyStack<char> stack = new MyStack<char>();

        foreach (char character in text)
        {
            if (character == '(' || character == '[' || character == '{')
            {
                stack.Push(character);
            }
            else if (character == ')' || character == ']' || character == '}')
            {
                if (stack.IsEmpty)
                {
                    return false; // Unmatched closing bracket
                }

                if (!Matches(stack.Pop(), character))
                {
                    return false; // Mismatched brackets
                }
            }
        }

        return stack.IsEmpty;
    }

    /// <summary>
    /// Determines whether an opening bracket matches a closing bracket.
    /// </summary>
    /// <param name="open">The opening bracket.</param>
    /// <param name="close">The closing bracket.</param>
    /// <returns>True if the brackets match; otherwise, false.</returns>
    public static bool Matches(char open, char close)
    {
        return (open == '(' && close == ')')
            || (open == '[' && close == ']')
            || (open == '{' && close == '}');
    }
}
