using curso_dio_colecoes_e_linq.src.Model;

namespace curso_dio_colecoes_e_linq
{
    class Program
    {
        static void Main()
        {
            CollectionLinq();
        }

        static void CollectionLinq()
        {
            var array = new int[] { 1, 4, 6, 8, 15, 19, 22, 29, 37};
            OperationLinq.FindNumbersPairs(ref array);
            OperationLinq.FindNumbersOdd(ref array);
            OperationLinq.SumAllElementArray(ref array);
        }

        static void CollectionDictionary()
        {
            var dictionary = new Dictionary<string, string>();
            OperationDictionary.CreateDictionary(ref dictionary);
            OperationDictionary.PrintDictionary(dictionary);
            //OperationDictionary.FindElementFromKeyDictionary(ref dictionary, "BA");
            //OperationDictionary.UpdateElementFromKeyDictionary(ref dictionary, "BA");
            OperationDictionary.RemoveAllElementDictionary(ref dictionary);
            OperationDictionary.PrintDictionary(dictionary);
        }

        static void CollectionStack()
        {
            var stack = new Stack<string>();
            OperationStack.CreateStack(ref stack);
            OperationStack.PrintStack(stack);
            OperationStack.RemoveAllElementsStack(ref stack);
            OperationStack.PrintStack(stack);
        }

        static void CollectionQueue()
        {
            var queue = new Queue<string>();
            OperationQueue.CreateQueue(ref queue);
            OperationQueue.PrintQueue(queue);
            //OperationQueue.RemoveFirstElementQueue(ref queue);
            OperationQueue.RemoveAllElementQueue(ref queue);
            OperationQueue.PrintQueue(queue);
        }

        static void ColectionGenerics()
        {
            var states = new List<string>();
            OperationCollections.CreateList(ref states);
            OperationCollections.PrintList(states);
            OperationCollections.CountElementsToList(states);
            OperationCollections.RemoveAllList(ref states);
            OperationCollections.RemoveOneElementList(ref states, "RS");
            OperationCollections.PrintList(states);
        }

        static void ShowDisplayOperationArray()
        {
            //var ArrayInt = new int[] { 6, 3, 8, 1, 9 };
            //OperationArray.DisplayValue();
            //OperationArray.DisplayMatrix();
            //var ArrayCopy = new int[10];
            //Console.WriteLine("Array Original");
            //OperationArray.DisplayValue(ArrayInt);

            //OperationArray.BubbleSort(ref ArrayInt);
            //OperationArray.ArraySort(ref ArrayInt);
            //OperationArray.ArrayCopy(ref ArrayInt, ref ArrayCopy);

            //Console.WriteLine("Array Ordenado");
            //Console.WriteLine("Array Copia");
            //OperationArray.DisplayValue(ArrayCopy);
            //OperationArray.VerifyExistsElementArray(ArrayInt, 8);
            //OperationArray.AllElementsGreaterThanValue(ArrayInt, 8);

            //int value = OperationArray.GetValueArray(ArrayInt, 9);
            //if (value > 0)
            //    Console.WriteLine($"O valor encontrado é: {value}");
            //else
            //    Console.WriteLine("O valor Não foi encontrado!");

            //int element = 8;
            //int index = OperationArray.GetIndex(ArrayInt, element);
            //if (index > -1)
            //    Console.WriteLine($"O indice do elemento {element} é {index}");
            //else
            //    Console.WriteLine("Indice Não encontrado!");

            //Console.WriteLine($"Capacidade atual do array: {ArrayInt.Length}");
            //OperationArray.AddReSize(ref ArrayInt, ArrayInt.Length * 2);
            //Console.WriteLine($"Capacidade atual do array após redimensionar: {ArrayInt.Length}");

            //OperationArray.DisplayValue(ArrayInt);
            //var arrayString = OperationArray.ConvertArrayToString(ArrayInt);
            //Console.WriteLine($"Array de string: {arrayString}");
        }
    }
}