namespace curso_dio_colecoes_e_linq.src.Model
{
    public class OperationArray
    {
        public static string[] ConvertArrayToString(int[] array)
        {
            return Array.ConvertAll(array, element => element.ToString());
        }

        public static void AddReSize(ref int[] array, int newSize)
        {
            Array.Resize(ref array, newSize);
        }

        public static int GetIndex(int[] array, int value)
        {
            return Array.IndexOf(array, value);
        }

        public static int GetValueArray(int[] array, int value)
        {
            return Array.Find(array, element => element == value);
        }

        public static void AllElementsGreaterThanValue(int[] ArrayInt, int value)
        {
            if (Array.TrueForAll(ArrayInt, element => element > value))
                Console.WriteLine($"Os elementos são maiores que {value} no array");
            else
                Console.WriteLine($"Algum elemento é menor que {value} no array");
        }

        public static void VerifyExistsElementArray(int[] ArrayInt, int value)
        {
            if (Array.Exists(ArrayInt, element => element == value))
                Console.WriteLine($"O elemento {value} existe no array");
            else
                Console.WriteLine($"O elemento {value} Não existe no array");  
        }

        public static void ArrayCopy(ref int[] ArrayInt, ref int[] ArrayDest)
        {
            Array.Copy(ArrayInt, ArrayDest, ArrayInt.Length);
        }

        public static void ArraySort(ref int[] ArrayInt)
        {
            Array.Sort(ArrayInt);
        }

        public static void BubbleSort(ref int[] ArrayInt)
        {
            int temp = 0;
            for (int i = 0; i < ArrayInt.Length; i++)
            {
                for (int j = 0; j < ArrayInt.Length - 1; j++)
                {
                    if (ArrayInt[j] > ArrayInt[j + 1])
                    {
                        temp = ArrayInt[j + 1];
                        ArrayInt[j + 1] = ArrayInt[j];
                        ArrayInt[j] = temp;
                    }
                }
            }
        }

        public static void DisplayValue(int[] ArrayInt)
        {
            foreach (var item in ArrayInt)
                Console.Write($"{item}" + " ");
            Console.WriteLine("");
        }

        public static void DisplayValue()
        {
            int[] ArrayInt = new int[] { 10, 20, int.Parse("30") };
            foreach (var item in ArrayInt)
                Console.WriteLine($"ArrayInt[{Array.IndexOf(ArrayInt, item)}] = {item}");
        }

        public static void DisplayMatrix()
        {
            int[,] MatrixInt = new int[4, 2]
            {
                {10, 20},
                {30, 40},
                {50, 60},
                {70, 80}
            };
            for (int i = 0; i < MatrixInt.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixInt.GetLength(1); j++)
                {
                    Console.WriteLine($"Matrix[{i},{j}] = {MatrixInt[i, j]}");
                    //Console.Write($"{MatrixInt[i, j]}" + " ");
                }
                //Console.WriteLine("");
            }
        }
    }
}
