using System;
namespace CSharp
{
    class CProgram
    {
        static void Main(string[]args)
        {
            int[] list=new int[] {8,6,4,5,7,2,1,3};
            System.Console.WriteLine("The array in ascending order");
            Array.Sort(list);
            foreach (int i in list)
            {
                Console.Write(i +" ");
            }
        }
    }
}

