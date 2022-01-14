 using System;
using static Assignment_1.Program;

namespace Assignment_1
{

public class wordOrder{
    public static void wordOrders(){
            int length;
            string rev= "";
            Console.Write("Please Enter your Sentence : ");
            string sent = Console.ReadLine();

            length = sent.Length -1;
            while(length>=0)
            {
                rev = rev + sent[length];
                length --;

            }
            Console.WriteLine("\n_________________________________\n\n>>> The reverse of "+ sent+ " is => \n" + rev +" <<<\n_________________________________");
            
            }
    }
}
