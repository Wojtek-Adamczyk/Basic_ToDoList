using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class State
    {
        private static string filePath = "todos.txt";

        public static void Save(List<string> ToDos)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (string s in ToDos)
                    sw.WriteLine(s);
            }
        }

        public static List<string> Load()
        {
            List<string> ToDos = new List<string>();

            using(StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ToDos.Add(line);
                }
                return ToDos;
            }
        }
    }
}
