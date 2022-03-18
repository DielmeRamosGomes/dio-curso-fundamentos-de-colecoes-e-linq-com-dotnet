namespace curso_dio_colecoes_e_linq.src.Model
{
    public class OperationCollections
    {
        public static void RemoveOneElementList(ref List<string> list, string element)
        {
            try
            {
                list.Remove(element);
            }
            catch (Exception)
            {
                Console.WriteLine("Elemento Não Encontrado");
            }
            
        }

        public static void RemoveAllList(ref List<string> list)
        {
            list.Clear();
        }

        public static void CreateList(ref List<string> list)
        {
            list.Add("SP");
            list.Add("MG");
            list.Add("BA"); 
        }
        
        public static void PrintList(List<string> list)
        {
            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"\n indice[{list.IndexOf(item)}], elemento = {item} \n");
                }
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            
        }

        public static void CountElementsToList(List<string> list)
        {
            Console.WriteLine($"\n Quantidades de elementos na lista: {list.Count} \n ");
        }
    }
}
