using System;

namespace Assignment_1
{

public class Revers{
public static void Reverss(){
            int length;
            string revers= "";
            Console.WriteLine("Inpute Your String");
            string input = Console.ReadLine();

            length = input.Length -1;
            while(length>=0)
            {
                revers = revers + input[length];
                length --;

            }
            Console.WriteLine("\n\n>>> the reverse is " +revers);
            Program.menu();
            }

}
}