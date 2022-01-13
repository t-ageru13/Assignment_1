using System;
using static Assignment_1.Program;

namespace Assignment_1
{

public class wordoccurence{

    public static void wordoccurence1(){
                Console.WriteLine("Please Input somting");
                string input = Console.ReadLine();
                Console.WriteLine("Now Insert the word you want to search");
                string find = Console.ReadLine();
                int counter = 0;
                foreach(char item in input){
                    if (item == find[0]){
                        counter++;
                    }
                    
                }
                Console.WriteLine("\nit occures "+counter+" times \n");
                Program.menu();
            }
}}