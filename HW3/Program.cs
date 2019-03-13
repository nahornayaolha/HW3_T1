using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter students and their marks: (enter 'stop' to finish):");
            ClassBook list = new ClassBook();

            string added;
            bool isInputStoped = true;
            
            while (isInputStoped)
            {
                try
                {
                    added = Console.ReadLine();

                    if (added == "stop")
                    {
                        isInputStoped = false;
                        break;
                    }
                   else
                    {
                        list.AddToClassBook(added);
                    }
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("Input has wrong format! Desired format: 'Surname:Mark'");
                    Console.WriteLine("Mark should be a number from 1 to 5'");
                    continue;
                }
            }
            list.listOfPupils();
            list.findBook();
                            
            Console.ReadKey();
        }
    }
}
