﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class Data
    {
        const string DATA_FILE = "./Resources/SaveFile.txt";
        public static async Task Overwrite(List<(Action a, string key, int delay, int x, int y)> data)
        {
            string[] newData = TupleListToStringArray(data);
            await File.WriteAllLinesAsync(DATA_FILE, newData);
        }
        public static List<(Action a, string key, int d, int x, int y)> LoadAsTupleList()
        {
            List<(Action a, string key, int d, int x, int y)> data = new List<(Action a, string key, int d, int x, int y)>();

            List<string> singleDataLine = new List<string>() { };

            int count = 0;
            foreach (string line in File.ReadLines(DATA_FILE))
            {
                //Debug.Log(line);
                singleDataLine.Add(line);
                count++;
                if (count == 5)
                {
                    data.Add(ReturnCorrectAction(singleDataLine[0], singleDataLine[1], singleDataLine[2], singleDataLine[3], singleDataLine[4]));
                    singleDataLine.Clear();
                    count = 0;
                }
            }
            return data;
        }
        static (Action a, string key, int d, int x, int y) ReturnCorrectAction(string a, string key, string d, string x, string y)
        {
            int delay = Convert.ToInt32(d);
            int X = Convert.ToInt32(x);
            int Y = Convert.ToInt32(y);

            if (a == "AutoClicker.MouseAction")
            {
                return (new MouseAction(new Point(0, 0), 0), key, delay, X, Y);
            }
            else
            {
                return (new KeyAction("", 0), key, delay, X, Y);
            }
        }
        private static string[] TupleListToStringArray(List<(Action a, string key, int d, int x, int y)> data)
        {
            List<string> dataInStringList = new List<string>();
            foreach ((Action a, string k, int d, int x, int y) entry in data)
            {
                dataInStringList.Add(entry.a.ToString());
                dataInStringList.Add(entry.k.ToString());
                dataInStringList.Add(entry.d.ToString());
                dataInStringList.Add(entry.x.ToString());
                dataInStringList.Add(entry.y.ToString());
            }
            string[] dataFinal = dataInStringList.ToArray();
            return dataFinal;
        }
    }
}