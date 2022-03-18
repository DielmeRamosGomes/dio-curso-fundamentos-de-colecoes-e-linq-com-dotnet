namespace curso_dio_colecoes_e_linq.src.Model
{
    public class OperationQueue
    {
        public static void CreateQueue(ref Queue<string> queue)
        {
            queue.Enqueue("SP");
            queue.Enqueue("RJ");
            queue.Enqueue("MG");
            queue.Enqueue("MT");
            queue.Enqueue("RO");
        }

        public static void RemoveFirstElementQueue(ref Queue<string> queue)
        {
            queue.Dequeue();
        }

        public static void RemoveAllElementQueue(ref Queue<string> queue)
        {
            while (queue.Count > 0)
            {
                queue.Dequeue();
            }
        }

        public static void PrintQueue(Queue<string> queue)
        {
            if (queue.Count != 0)
            {
                int i = 0;
                foreach (var item in queue)
                {
                    Console.WriteLine($"indice[{i}], elemento = {item} \n");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\n Fila Vazia!");
            }
        }

    }
}
