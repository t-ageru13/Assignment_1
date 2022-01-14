using System;

namespace Assignment_1
{
    public class Program
    {
       public static void Main(string[] args)
        {
           menu();
        }
        public static void menu(){
                Console.WriteLine("Please choice what you went to do with \n1. To reverse string\n2. To find String palindrome\n3. To see reversed word Order\n4. To count character Occurence\n5. To find Substring\n6. To find second largest intiger\n7. To convert 2D array in to 1D\n8. To find an angel b/n hour and minute\n9. To Exit");
           string N = Console.ReadLine();
           if (N=="1"){
               Revers.Reverss();
           }
           else {
               if (N == "2"){
               palindrom.palindrom1();
           }
            else{
                if (N == "3"){
                    wordOrder.wordOrders();
                }
                else{
                    if (N == "4"){
                    wordoccurence.wordoccurence1();
                }
                else{
                    if (N == "5"){
                    Substring.Substring1();
                }
                else{
                    if(N=="6"){
                        Largint.Largint1();
                    }
                    else{
                        if(N=="7"){
                            Arraydem.conversion();
                        }
                        else{
                            if(N=="8"){
                                hourminute.hourminute1();
                            }
                            else{
                                if(N=="9"){
                                }
                                else { Console.WriteLine("\n>>>Incorrect Input<<<\n");
                                menu();}
                            }
                        }
                    }
                }
                }
                
                }
            }
           }
            }
    }
}
