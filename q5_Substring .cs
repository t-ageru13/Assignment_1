using System;
using static Assignment_1.Program;

namespace Assignment_1
{

public class Substring{

public static void Substring1(){  
                
                Console.WriteLine("Please Enter your String");
                string str = Console.ReadLine();
                int n = str.Length; 
                for (int len = 1; len <= n; len++)
            {
                
                for (int i = 0; i <= n - len; i++)
                {
                    
                    int j = i + len - 1;

                    for (int k = i; k <= j; k++) 
                    System.Console.Write(str[k]);
                    System.Console.WriteLine();
                    
                }
                
            }
            Program.menu();
                
            }
            
            
                     }


}