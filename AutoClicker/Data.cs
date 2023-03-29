using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class Data
    {
        const string DATA_FILE = "./Resources/SaveFile.txt";
        public static async Task Overwrite(List<(int x, int y, int delay)> data)
        {
            string[] newData = TupleListToStringArray(data);
            await File.WriteAllLinesAsync(DATA_FILE, newData);
        }
        public static List<(int id, int x, int y)> LoadAsTupleList()
        {
            List<(int id, int x, int y)> data = new List<(int id, int x, int y)>();
            List<int> singleObjectData = new List<int>();
            int count = 0;

            foreach (string line in System.IO.File.ReadLines(DATA_FILE))
            {
                //Debug.Log(line);
                singleObjectData.Add(Convert.ToInt32(line));
                count++;
                if (count == 3)
                {
                    data.Add((singleObjectData[0], singleObjectData[1], singleObjectData[2]));
                    singleObjectData.Clear();
                    count = 0;
                }
            }
            return data;
        }
        private static string[] TupleListToStringArray(List<(int id, int x, int y)> data)
        {
            List<string> dataInStringList = new List<string>();
            foreach ((int id, int x, int y) entry in data)
            {
                dataInStringList.Add(entry.id.ToString());
                dataInStringList.Add(entry.x.ToString());
                dataInStringList.Add(entry.y.ToString());
            }
            string[] dataFinal = dataInStringList.ToArray();
            return dataFinal;
        }
    }
}
