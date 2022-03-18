namespace curso_dio_colecoes_e_linq.src.Model
{
    public class OperationStack
    {
        public static void RemoveAllElementsStack(ref Stack<string> stack)
        {
            while (stack.Count > 0)
            {
                stack.Pop();
            }
        }

        public static void CreateStack(ref Stack<string> stack)
        {
            stack.Push("UM");
            stack.Push("DOIS");
            stack.Push("TRES");
            stack.Push("QUATRO");
            stack.Push("CINCO");
        }

        public static void PrintStack(Stack<string> stack)
        {
            if (stack.Count > 0)
            {
                int i = stack.Count;
                foreach (var item in stack)
                {
                    i--;
                    Console.WriteLine($"indice[{i}], elemento = {item} \n");
                }
            }
            else
            {
                Console.WriteLine("\n Pilha Vazia!");
            }
        }
    }
}
