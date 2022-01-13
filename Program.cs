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
                Console.WriteLine("\n1. Revers String\n2. palindrome String\n3. word Order\n4. word Occurence\n5. Substring\n6. 2nd largest integer\n7. Arraye deminsion\n8. angel of hour and minute\n9. Exit");
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
                    wordorder.Wordorder1();
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
                            Arraydem.Arraydem1();
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
