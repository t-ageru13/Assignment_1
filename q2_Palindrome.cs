using System;
using static Assignment_1.Program;

namespace Assignment_1
{

public class palindrom{
public static void palindrom1(){
                int length;
            string revers= "";
            Console.WriteLine("Please Enter your String");
            string input = Console.ReadLine();
            string cap ="";
            for (int i=0;i<input.Length;i++){
                if (input[i]>='a'&&input[i]<='z'){
                    cap += (char)(input[i]-32 );
                }
                else{
                    cap += input[i];
                }
            }

            length = cap.Length -1;
            while(length>=0)
            {
                revers = revers + cap[length];
                length --;

            }
            
            
            if(cap==revers){
                Console.WriteLine("\n Your Input is palindrome String");
                menu();
            }
            else {Console.WriteLine("\nThis One is not palindrome String ");
            Program.menu();}
            }
}}