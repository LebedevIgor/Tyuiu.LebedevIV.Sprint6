using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;


namespace Tyuiu.LebedevIV.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string result = "";

            foreach (string line in lines)
            {
                string[] words = line.Split(' ');

                if (words.Length >= 1)
                {
                    result += words[0] + " ";
                }
            }

            return result.Trim();
        }
    }
}
