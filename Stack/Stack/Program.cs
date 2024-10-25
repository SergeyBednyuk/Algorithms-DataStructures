namespace Stack;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(2); // 2
        stack.Push(7); // 7,2
        Console.WriteLine(stack.Peek()); // 7,2 
        stack.Pop(); // 2
        Console.WriteLine(stack.Peek()); // 2
        stack.Push(3); // 3, 2
        stack.Push(4); // 4, 3, 2
        Console.WriteLine(stack.Peek());
        
        //Balanced parentheses task
        string s1 = "(){}[]"; // true
        string s2 = "{}"; // true
        string s3 = "}{"; // false
        string s4 = ""; // true
        string s5 = "(()"; // false
        string s6 = "())"; // false
        string s7 = "[(])"; // false
        
        Console.WriteLine(IsBalanced(s1));
        Console.WriteLine(IsBalanced(s2));
        Console.WriteLine(IsBalanced(s3));
        Console.WriteLine(IsBalanced(s4));
        Console.WriteLine(IsBalanced(s5));
        Console.WriteLine(IsBalanced(s6));
        Console.WriteLine(IsBalanced(s7));
        Console.ReadKey();
    }

    static bool IsBalanced(string s)
    {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (IsOpen(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count != 0 && IsPair(stack.Peek(), s[i]))
                {
                    stack.Pop();   
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    private static bool IsPair(char peek, char c)
    {
        if (peek == '(' && c == ')')
        {
            return true;
        }
        if (peek == '[' && c == ']')
        {
            return true;
        }
        if (peek == '{' && c == '}')
        {
            return true;
        }
        
        return false;
    }

    private static bool IsOpen(char c)
    {
        return c == '(' || c == '{' || c == '[';
    }
    
}