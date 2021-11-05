using System;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use StreamReader to read file
            StreamReader file = new StreamReader(@"Numbers.txt");

            //Implement try catch to handle errors
            try
            {
                //Use StreamWriter to write to an evens file and an odds file
                StreamWriter evens = new StreamWriter("Evens.txt");
                StreamWriter odds = new StreamWriter("Odds.txt");

                //Loop while there is still data in reading file
                while (!file.EndOfStream)
                {
                    //Store parsed integers in num varibale
                    int num = Int32.Parse(file.ReadLine());

                    //If num mod 2 is 0, num is even
                    if (num % 2 == 0)
                    {
                        evens.WriteLine(num);
                    }
                    //If num mod 2 is not 0, num is odd
                    else if (num % 2 != 0)
                    {
                        odds.WriteLine(num);
                    }
                }
                //Close all readers/writers
                evens.Close();
                odds.Close();
                file.Close();
            }
            //Catch error and display to user
            catch (Exception e)
            {
                Console.WriteLine("File could not be read.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
