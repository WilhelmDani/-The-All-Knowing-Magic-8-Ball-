using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Monday
{
    class Magic8Ball
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Eight Ball is ALL KNOWING...";
            Console.WriteLine(@"                
                                     
            ./(########((,             
         /(#%%&&&@@@&&&%%%%#(          
      .(#%@@@@@@@@@@@@@@@&&%%%#/       
     (#@%%@@@@@@@@@@@@@@@@@@@&%%#,     
   .(@%##&@@@@@@@@@@@@@@@@@@@@@&%#(    
   #@%#%@@@@@@@@@@@@@@%%##%&&@@@@%#/   
  (@@%%@@@@@@@@@@@@...........#@@@%#.  
 ,%@@@@@@@@@@@@@@.......#&......#@@@(  
 /&@@@@@@@@@@@@@......&    #.....@@%#  
 /%@@@@@@@@@@@@@......&....%.....@&%#  
 .#%&@@@@@@@@@@@......,&***&.....&&%(  
  (%%%%%%%%%&@@@ .....&     % ...&&%#   
   #%%%%%%%&&&&&& .....`%#&`...&&%%.   
    (%%%&&&&&&&&&&&..........&&&%#,    
     (%%%&&&&&&&&&&&&&&%%&&&&&%%#      
       (%%&&&&&&&&&&&&&&&&&&&%%        
          #%%&&&&&&&&&&&&%%%.          
              *#%%%%%%%%               

");

            Random randomAnswerGen = new Random();
            bool leave = false;
            

            string[] answers = new string[8];
            answers[0] = "\nWithout a doubt.\n";
            answers[1] = "\nSigns point to yes.\n";
            answers[2] = "\nHmmm....It's hazy, concentrate and ask again.\n";
            answers[3] = "\nMy sources say no.\n";
            answers[5] = "\nThe outlook is good!\n";
            answers[6] = "\nCannot predict now.\n";
            answers[7] = "\nDon't count on it\n";

            do
            {
                
                Console.WriteLine("Would you like to play? Y/N: ");
                ConsoleKey askQuestion = Console.ReadKey().Key;
                Console.Clear();


                if (askQuestion == ConsoleKey.Y)

                {
                   
                    Console.WriteLine("What do you want to ask the All Knowing Magic 8 Ball?:\n");
                    string userAnswer = Console.ReadLine();
                    int randomAnswer = randomAnswerGen.Next(answers.Length);
                    Console.WriteLine(answers[randomAnswer]);
                }


                else if (askQuestion == ConsoleKey.N)
                {
                    Console.WriteLine("You are leaving now, but the Magic 8 Ball will be waiting....");
                    leave = true;
                }

            } while (!leave);
            
        }

    }
}
