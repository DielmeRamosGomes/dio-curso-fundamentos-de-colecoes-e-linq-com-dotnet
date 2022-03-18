namespace curso_dio_colecoes_e_linq.src.Model
{
    public class OperationLinq
    {
        public static void SumAllElementArray(ref int[] array)
        {
            Console.WriteLine($"\nA soma de todos os valores do array = {array.Sum()}");
        }

        public static void FindNumbersPairs(ref int[] array)
        {
            var numbersPairs = array.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            Console.WriteLine($"Os numeros pares são: {string.Join(", ", numbersPairs)} \n");
        }

        public static void FindNumbersOdd(ref int[] array)
        {
            var numbersOdd = array.Where(x => x % 2 != 0).OrderBy(x => x).ToList();
            Console.WriteLine($"Os numeros impares são: {string.Join(", ", numbersOdd)} \n");
        }
    }
}
