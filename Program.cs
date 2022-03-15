using System;

namespace csharp_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[8];
            int[,,] arr3d = new int[4,4,4];
            for (int i=0;i<4;i++){
                for (int j=0;j<4;j++){
                    for (int k=0;k<4;k++){
                        arr3d[i,j,k]=(i+1)*(j+1)*(k+1);
                    }
                }
            }
            Console.WriteLine("Length of array is {0}",arr3d.Length);
            Console.WriteLine("Dimensions of array are {0}, {1}, {2}",arr3d.GetLength(0),arr3d.GetLength(1),arr3d.GetLength(2));
            for (int i=0;i<4;i++){
                for (int j=0;j<4;j++){
                    for (int k=0;k<4;k++){
                        Console.WriteLine("({0},{1},{2}) = {3}",i,j,k,arr3d[i,j,k]);
                    }
                }
            }


            for (int i=0;i<arr.Length;i++){
                arr[i]=i+1;
            }
            int a = 5;
            int b = 3;
            Console.WriteLine("a is {0} and b is {1}",a,b);
            Console.WriteLine(myfunc(ref a,ref b));
            Console.WriteLine("a is {0} and b is {1}",a,b);
            for (int i=0;i<arr.Length;i++){
                Console.Write(arr[i]);
            }
            myArrFunc(ref arr);
            Console.WriteLine("\nAfter myArrFunc:");
            for (int i=0;i<arr.Length;i++){
                Console.Write(arr[i]);
            }

        }

        static int myfunc(ref int a, ref int b) {
            a = 100*a;
            b = 10*b;
            return a + b;
        }

        static void myArrFunc(ref int[] arr2) {
            int temp = arr2[arr2.Length-1];
            arr2[arr2.Length-1]=arr2[0];
            arr2[0]=temp;

        }

    
    }
}
