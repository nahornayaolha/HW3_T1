using System;
using System.Collections.Generic;

namespace HW3
{
    class ClassBook
    {
        string surname;
        int mark;
        private Dictionary<string, int> classbook = new Dictionary<string, int>();

        public void AddToClassBook(string added)
        {
            string[] surname_mark = added.Split(':');
            surname = surname_mark[0];
            mark = Convert.ToInt32(surname_mark[1]);
            if (mark < 1 || mark > 5)
            {
                Console.WriteLine("Mark should be a number from 1 to 5. Try again");
            }
            classbook.Add(surname, mark);

        }

        public void listOfPupils()
        {
            foreach (KeyValuePair<string, int> keyValue in classbook)
            {
                Console.WriteLine(keyValue.Key + ":" + keyValue.Value);
            }
        }

        public bool isNumber(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public void findBook()
        {

            foreach (KeyValuePair<string, int> keyValue in classbook)
            {
                Console.WriteLine("Please enter surname to see student`s mark or enter 'exit' to exit");
                
                surname = Console.ReadLine();

                if (classbook.TryGetValue(surname, out mark))
                {
                    Console.WriteLine("Student " + surname + " received a " + mark);
                }
                else if (surname == "exit")
                {
                    break;
                }
                else if (!classbook.ContainsKey(surname))
                {
                    Console.WriteLine("Input has wrong format");
                }
                
                
             }
        }

    }
}



