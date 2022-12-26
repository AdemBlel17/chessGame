using System;
using System.IO;
class movement
{

    public static void rightOne(ref int i, ref int j, ref string[,] arr)
    {
        //fisrt
        i += 1;
        arr[i, j] = " *";
        i += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " $";
        //second
       

        i -= 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " $";
        //third
        

        i -= 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " $";
    }
    public static void leftOne(ref int i, ref int j, ref string[,] arr)
    {
        //fisrt
        i += 1;
        arr[i, j] = " *";
        i += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " $";
        //second
        

        i += 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " $";
        //third


        i -= 1;
        arr[i, j] = " *";
        i -= 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " $";
    }
    public static void downOne(ref int i, ref int j, ref string[,] arr)
    {
 
        //fisrt
        i += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " $";
        //second

        i += 1;
        arr[i, j] = " *";
        i += 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " $";
        //third


        i -= 1;
        arr[i, j] = " *";
        i -= 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " $";
    }
    public static void topOne(ref int i, ref int j, ref string[,] arr)
    {
    

        //fisrt
        i += 1;
        arr[i, j] = " *";
        i += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " $";
        //second
      
        i -= 1;
        arr[i, j] = " *";
        i -= 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " $";
        //third


        i -= 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " $";
    }
    public static void x_down_1(ref int i, ref int j,ref  string[,] arr)
    {
       
        i += 1;
        arr[i, j] = " *";
        i += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " $";
        
    }
    public static void x_down_2(ref int i,ref int j,ref string[,] arr)
    {
        
        i += 1;
        arr[i, j] = " *";
        i += 1;
        arr[i, j] = " *";
        j -= 1;
        arr[i, j] = " $";

    }
    public static void y_right_1(ref int i, ref int j, ref string[,] arr)
    {

        i += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " $";

    }
    public static void y_right_2(ref int i, ref int j, ref string[,] arr)
    {

      
        i -= 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " *";
        j += 1;
        arr[i, j] = " $";

    }


}
namespace ex1
{

    class program
    {
        static void Main(string[] args)
        {

            //arrivé
            //Console.Write(" matrix size = ");
            //int N = int.Parse(Console.ReadLine());
            int N =50;
            Console.Write(" x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write(" y = ");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                N= x+ 5;
            }
            else
            {
                N = y +5;
            }
            

            int i=0, j=0;
            
            string[,] arr = new string[N, N];
            //remplir 
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    arr[i, j] = " o";
                }

            } 
            
            arr[0,0]=" $" ;


            j = 0;
            i= 0;
            //traitement
            while ((i < x-2) && (i<N-2)) {
                
                movement.x_down_1(ref i, ref j,ref  arr);
                if ((i < x - 2) && (i < N - 2)) {
                    movement.x_down_2(ref  i, ref j ,ref arr) ;
                }
            }

            while ((j < y - 2) && (y < N - 2))
            {

                movement.y_right_1(ref i, ref j, ref arr);
                if ((j < y - 2) && (j < N - 2))
                {
                    movement.y_right_2(ref i, ref j, ref arr);
                }
            }
            while (i<x) {
                movement.downOne(ref i, ref j, ref arr);
            }
            while (i+1 > x)
            {
                movement.topOne(ref i, ref j, ref arr);
            }


            while (j <y-1 )
            {
                movement.rightOne(ref i, ref j, ref arr);
            }
            while (j > y )
            {
                movement.leftOne(ref i, ref j, ref arr);

            }








            //after treatment
            File.Delete("filename.txt");
            for (i = N-1; i >=0; i--)
            {
                for (j = 0; j < N; j++)
                {
                  
                    File.AppendAllText("filename.txt", arr[i, j]);
                }

                File.AppendAllText("filename.txt" , Environment.NewLine);



            }
            Console.WriteLine("                        Open The File 'filename' to see the result ..!    ");

        }
    }
}