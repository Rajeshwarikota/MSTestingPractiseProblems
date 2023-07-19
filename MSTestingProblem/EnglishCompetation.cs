using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestingProblem
{
    public class EnglishCompetation
    {
        public class EnglishCompetion
        {
            public string SwappingCompetion(string word1, string word2)
            {
                bool eligible = true;
                for (int i = 0; i < word2.Length; i++)
                {
                    bool found = false;
                    for (int j = 0; j < word1.Length; j++)
                    {
                        if (word2[i] == word1[j])
                        {
                            word1 = word1.Remove(j, 1);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        eligible = false;
                        break;
                    }
                }
                if (eligible)
                {
                    return "YES,Batch is Eligible";
                }
                else
                {
                    return "NO,Batch is not Eligible";
                }
            }
        }
    }
}
