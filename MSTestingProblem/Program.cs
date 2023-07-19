using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MSTestingProblem.EnglishCompetation;

namespace MSTestingProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....MSTesting Problems....");
            Console.WriteLine("Enter the below option");
            Console.WriteLine("\n1:English competation\n22:default");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    EnglishCompetion ec = new EnglishCompetion();
                    string word1 = "part";
                    string word2 = "trap";
                    string result = ec.SwappingCompetion(word1, word2);
                    Console.WriteLine(result);
                    break;
            }
            Console.ReadLine();
        }
    }
}
