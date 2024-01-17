namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortAlgorithms sortAlgorithms = new SortAlgorithms();
            int[] array = {1,2,4,3,9,7,3,1};
            
            sortAlgorithms.shellSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }



        
    }
}
