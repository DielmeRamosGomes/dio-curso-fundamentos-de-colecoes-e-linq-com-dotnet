namespace curso_dio_colecoes_e_linq.src.Model
{
    public class OperationDictionary
    {
        public static void RemoveAllElementDictionary(ref Dictionary<string, string> dictionary)
        {
            foreach (var item in dictionary)
            {
                dictionary.Remove(item.Key);
            }
        }

        public static void UpdateElementFromKeyDictionary(ref Dictionary<string, string> dictionary, string keyElement)
        {
            Console.WriteLine($"\nAtualizando Valor da chave {keyElement} \n");
            dictionary[keyElement] = $"Mato Grosso";
        }

        public static void FindElementFromKeyDictionary(ref Dictionary<string, string> dictionary, string keyElement)
        {
            Console.WriteLine($"\n O valor procurado a partir da chave {keyElement} = {dictionary[keyElement]}");
        }

        public static void CreateDictionary(ref Dictionary<string, string> dictionary)
        {
            dictionary.Add("SP", "São Paulo");
            dictionary.Add("MG", "Minas Gerais");
            dictionary.Add("BA", "Bahia");
        }

        public static void PrintDictionary(Dictionary<string, string> dictionary)
        {
            if (dictionary.Count > 0)
            {
                int i = 0;
                foreach (var item in dictionary)
                {
                    Console.WriteLine($"indice[{i}], Chave = {item.Key}, valor = {item.Value} \n");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\nDicionario Vazio!");
            }               
        }
    }
}
