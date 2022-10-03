/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld
{
  static void Main ()
  {
    int N;
    Console.Write ("ANAK AYAM TURUN ");
    N = int.Parse (Console.ReadLine ());
    if (N > 10)
      {
	Console.WriteLine ("anak ayam lebih dari 10");
      } //end if
      
      else{//start else
        for (int n = N; n >= 1; n--)
        {//start for
    
            if(n==1)
            {
            Console.WriteLine($"Anak ayam turunlah {n}, mati satu tingggal induknya");
            }//end if2
            
            else
            {
                Console.WriteLine($"Anak ayam turunlah {n}, mati satu tingggal {n-1}");
            }//end else2
        
        }//end for
        }//end else
        
  }//end static void Main ()
}//end class HelloWorld

