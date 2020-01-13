using System;
using System.Diagnostics;

namespace testnote
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debugger.Break();
            int numberStudents = Convert.ToInt32(Console.ReadLine());
            string[] students = new string[numberStudents];
            for (int i = 0; i < numberStudents; i++)
            {
                students[i] = Console.ReadLine();
            }
            int[] grades = new int[numberStudents + 2];

            grades[0] = 100;
            for (int i = 0; i < numberStudents; i++)
            {
                grades[i + 1] = Convert.ToInt32(Console.ReadLine());
            }
            grades[numberStudents + 1] = 0;
            int[] payOf = new int[numberStudents];

            payOf[0] = 1;

            for (var i = 1; i < grades.Length - 1; i++) // ASTA E PERFECTY SAFE
            {
                payOf[i] = 1; // se porneste de la 1
                
                var gradeValue = grades[i]; // aici e JMECHERIA
                if (grades[i - 1] < gradeValue)
                {
                    payOf[i ]++;
                }
                else
                {
                    if (grades[i + 1] < gradeValue)
                    {
                        payOf[i]++;
                    }
                }
            }


                    // ok. las- pe maine asta. ar trebuii mai facut ceva in plus. 
                    //tre sa plec da vin cu o idee. 
                    // sper ca te-a ajutat sa vezi cum fac debug. 
                    // n-am mai lucrat in visual studio de 7 ani cread
                    // ai fost super. multumesc foarte mult

            // de ce irina are 3? cred ca e gresala
            //La consolă se va afișa:
//            Ionel 1
//Mihai 3
//Elena 2
//Maria 1
//George 2
//Irina 3

            //irina nu are cum sa aiba 3 pt ca E ULTIMA
            //are nota 10. inainte e 6 si 9, 1 ban 2 bani, si 3 bani . nu poate avea 2 ca george
            // ceva nu inteleg;;; vecinu irinei e numai george deci nota e 2.
            // e vorba de toti vecinii si din stanga si  dindreapta? 
            //nota irinei e 10. deci trebuie sa primeasca mai mult decat george si geoge trebuie sa primeasca 
            //mai mult decat maria dar mai putin decat irina
            // ok :)) 

                for (int j= 0; j < numberStudents; j++)
                {
                    Console.WriteLine(students[j] + " " + payOf[j]);
                }

            
            }
        }
    }


    