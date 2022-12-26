internal class Program
{
    private static void Main(string[] args)
    {
        int[] array1 = new int[5] {13,53,55,7,19};
    
        ImprimirArray(array1,5);
    }

    public static void  ImprimirArray(int[] array, int tamano)
    {
        for(int i=0; i< tamano; i++)
        {
        Console.WriteLine ("Array posicion:  "+i+ " Valor:  "+array[i]);
        }
    }
}