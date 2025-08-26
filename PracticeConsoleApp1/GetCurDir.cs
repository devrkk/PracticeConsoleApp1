using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp1
{
    internal class GetCurDir    
    {
        public GetCurDir() 
        {
           string currentDirectory = Environment.CurrentDirectory;
              Console.WriteLine(currentDirectory);

            string str = "A B  C";
            string part = str.Replace(" ", "");
            Console.WriteLine(part);

            string[] parts = str.Split((char[])null, StringSplitOptions.RemoveEmptyEntries); 
            Console.WriteLine(parts[1]);

            foreach (string p in parts) 
            {
                Console.WriteLine(p);
            }
        }
    }
}
