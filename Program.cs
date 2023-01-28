using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
namespace yesno
{
    class Program
    {
        static void Main(string[] args)
        {
            var syth = new SpeechSynthesizer();
            var syth1 = new SpeechSynthesizer();
            var syth2 = new SpeechSynthesizer();
            var syth3 = new SpeechSynthesizer();
            var syth4 = new SpeechSynthesizer();
            var syth5 = new SpeechSynthesizer();
            var syth6 = new SpeechSynthesizer();
            var syth7 = new SpeechSynthesizer();
            var syth8 = new SpeechSynthesizer();
            var syth9 = new SpeechSynthesizer();
            var syth10 = new SpeechSynthesizer();
            var password = new SpeechSynthesizer();
            Console.WriteLine("Enter the password");
            password.SelectVoiceByHints(VoiceGender.Male);
            password.Rate = -2;
            password.Speak("Enter Password");
            string  Password =Console.ReadLine();

            while (Password == "1222")
            {
              switch (Password)
                {
                    case "1222":
                       
                        syth1.SelectVoiceByHints(VoiceGender.Male);
                        syth1.Rate = -3;
                    
                        syth1.SelectVoiceByHints(VoiceGender.Male);
                        syth1.Rate = -3;
                        syth1.Speak("Write SomeThing");
                        Console.WriteLine("write something ");
                        Console.WriteLine(" ");
                        string a = Console.ReadLine();
                        if (a == "Bye")
                        {
                            Console.WriteLine("Bye");
                            syth3.SelectVoiceByHints(VoiceGender.Male);
                            syth3.Rate = -3;
                            Console.WriteLine("Press Keys Ctrl + c");
                            Console.ReadLine();
                        }
                        if(a == "bye")
                        {
                            Console.WriteLine("Bye");
                            syth3.SelectVoiceByHints(VoiceGender.Male);
                            syth3.Rate = -3;
                            Console.WriteLine("Press Keys Ctrl + c");
                            Console.ReadLine();
                        }
                        Random random = new Random();
                        int yesorno = random.Next(1, 10);
                      
                        if (yesorno == 1)
                        {
                          
                            Console.WriteLine("Yes");
                            syth1.SelectVoiceByHints(VoiceGender.Male);
                            syth1.Rate = -3;
                            syth1.Speak("Yes");
                        }
                        if (yesorno == 2)
                        {
                       
                            Console.WriteLine("No");
                            syth2.SelectVoiceByHints(VoiceGender.Male);
                            syth2.Rate = -3;
                            syth2.Speak("No");
                        }
                        if (yesorno == 3)
                        {

                            Console.WriteLine("No");
                            syth3.SelectVoiceByHints(VoiceGender.Male);
                            syth3.Rate = -3;
                            syth3.Speak("No");
                        }
                        if (yesorno == 4)
                        {
                
                            Console.WriteLine("Yes");
                            syth4.SelectVoiceByHints(VoiceGender.Male);
                            syth4.Rate = -3;
                            syth4.Speak("Yes");
                        }
                        if (yesorno == 5)
                        {
                      
                            Console.WriteLine("No");
                            syth5.SelectVoiceByHints(VoiceGender.Male);
                            syth5.Rate = -3;
                            syth5.Speak("No");
                        }
                        if (yesorno == 6)
                        {
                          
                            Console.WriteLine("yes");
                            syth6.SelectVoiceByHints(VoiceGender.Male);
                            syth6.Rate = -3;
                            syth6.Speak("Yes");

                        }
                        if (yesorno == 7)
                        {
                        
                            Console.WriteLine("No");
                            syth7.SelectVoiceByHints(VoiceGender.Male);
                            syth7.Rate = -3;
                            syth7.Speak("No");
                        }
                        if (yesorno == 8)
                        {
                     
                            Console.WriteLine("No");
                            syth8.SelectVoiceByHints(VoiceGender.Male);
                            syth8.Rate = -3;
                            syth8.Speak("No");
                        }
                        if (yesorno == 9)
                        {
                   
                            Console.WriteLine("No");
                            syth9.SelectVoiceByHints(VoiceGender.Male);
                            syth9.Rate = -3;
                            syth9.Speak("No");
                        }
                        if (yesorno == 10)
                        {
                           
                            Console.WriteLine("yes");
                            syth10.SelectVoiceByHints(VoiceGender.Male);
                            syth10.Rate = -3;
                            syth10.Speak("Yes");

                        }
                        if (a == "Who are you")
                        {
                            syth10.SelectVoiceByHints(VoiceGender.Male);
                            syth10.Rate = -3;
                            syth10.Speak("iam yes or no machine");

                            Console.WriteLine("iam yes or no machine");
                        }
                        if (a == "who are you")
                        {
                            Console.WriteLine("iam yes or no machine");
                            syth10.SelectVoiceByHints(VoiceGender.Male);
                            syth10.Rate = -3;
                            syth10.Speak("iam yes or no machine");


                        }
                        else if (a == "who invented you")
                        {
                            syth10.SelectVoiceByHints(VoiceGender.Male);
                            syth10.Rate = -3;
                            syth10.Speak("Iam invented by Ayush Kauhsambhi");
                            Console.WriteLine("Iam invented by Ayush Kaushambhi");

                        }
                        else if (a == "Who invented you")
                        {
                            syth10.SelectVoiceByHints(VoiceGender.Male);
                            syth10.Rate = -3;
                            syth10.Speak("Iam invented by Ayush Kauhsambhi");
                            Console.WriteLine("Iam invented by Ayush Kaushaamaabheee");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Password");
                        break;

                }

            }
           
                Console.ReadLine();
            }
        }
    }

