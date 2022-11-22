namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var value = input.Split(' ');

            var stack = new Stack<string>(value.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string oper = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (oper == "+")
                {
                    stack.Push((first + second).ToString());
                }
                if (oper == "-")
                {
                    stack.Push((first - second).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
