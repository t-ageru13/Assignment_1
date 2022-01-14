using System;
using static Assignment_1.Program;

namespace Assignment_1
{

public class wordoccurence{

    public static void wordoccurence1(){
                Console.WriteLine("Please can you Enter what you need");
                string input = Console.ReadLine();
                Console.WriteLine("Now Enter the word you want to search");
                string find = Console.ReadLine();
                int counter = 0;
                foreach(char item in input){
                    if (item == find[0]){
                        counter++;
                    }
                    
                }
                Console.WriteLine("\nIt occures "+counter+" times \n");
                Program.menu();
            }
}}