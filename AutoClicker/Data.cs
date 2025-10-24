using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace AutoClicker
{
    internal class Data
    {
        public const string DATA_FILE = "./Resources/SaveFile.txt";
        public static async Task Overwrite(List<(Action a, VirtualKeyCode key, int delay, int x, int y)> data)
        {
            string[] newData = TupleListToStringArray(data);
            await File.WriteAllLinesAsync(DATA_FILE, newData);
        }
        public static List<(Action a, VirtualKeyCode key, int d, int x, int y)> LoadAsTupleList()
        {
            List<(Action a, VirtualKeyCode key, int d, int x, int y)> data = new List<(Action a, VirtualKeyCode key, int d, int x, int y)>();

            List<string> singleDataLine = new List<string>() { };

            int count = 0;
            foreach (string line in File.ReadLines(DATA_FILE))
            {
                //Debug.Log(line);
                singleDataLine.Add(line);
                count++;
                if (count == 5)
                {
                    data.Add(ReturnCorrectAction(singleDataLine[0], ConvertStringToKey(singleDataLine[1]), singleDataLine[2], singleDataLine[3], singleDataLine[4], "Your text isnt saved sorry"));
                    singleDataLine.Clear();
                    count = 0;
                }
            }
            return data;
        }
        public static List<(Action a, VirtualKeyCode key, int d, int x, int y)> LoadAsTupleList(string path)
        {
            List<(Action a, VirtualKeyCode key, int d, int x, int y)> data = new List<(Action a, VirtualKeyCode key, int d, int x, int y)>();

            List<string> singleDataLine = new List<string>() { };

            int count = 0;
            foreach (string line in File.ReadLines(path))
            {
                //Debug.Log(line);
                singleDataLine.Add(line);
                count++;
                if (count == 5)
                {
                    data.Add(ReturnCorrectAction(singleDataLine[0], ConvertStringToKey(singleDataLine[1]), singleDataLine[2], singleDataLine[3], singleDataLine[4], "Your text isnt saved sorry"));
                    singleDataLine.Clear();
                    count = 0;
                }
            }
            return data;
        }
        public static string[] LoadDataAsStringArray(string filePath)
        {
            string[] data = File.ReadAllLines(filePath);
            return data;
        }
        static VirtualKeyCode ConvertStringToKey(string key)
        {
            // covert string to keys
            VirtualKeyCode keything = VirtualKeyCode.CONTROL;

            if (key == "ESCAPE")
            {
                keything = VirtualKeyCode.ESCAPE;
            }

            return keything;
        }
        static (Action a, VirtualKeyCode key, int d, int x, int y) ReturnCorrectAction(string a, VirtualKeyCode key, string d, string x, string y, string t)
        {
            int delay = Convert.ToInt32(d);
            int X = Convert.ToInt32(x);
            int Y = Convert.ToInt32(y);

            if (a == "AutoClicker.MouseAction")
            {
                return (new MouseAction(new Point(0, 0), 0, KeyActionTypes.Down), key, delay, X, Y);
            }
            else if (a == "AutoClicker.KeyAction")
            {
                return (new KeyAction(VirtualKeyCode.CONTROL, 0, KeyActionTypes.Down), key, delay, X, Y);
            }
            else if (a == "AutoClicker.TextAction")
            {
                return (new TextAction(t, delay), key, delay, X, Y);
            }
            else 
            {
                return (new KeyAction(VirtualKeyCode.CONTROL, 0, KeyActionTypes.Down), key, delay, X, Y);
            }
        }
        static string[] TupleListToStringArray(List<(Action a, VirtualKeyCode key, int d, int x, int y)> data)
        {
            List<string> dataInStringList = new List<string>();
            foreach ((Action a, VirtualKeyCode k, int d, int x, int y) entry in data)
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
