using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inteligentne_systemy_decyzyjne
{
    class TFM : List<List<int>>
    {
        static List<dItem> d = new List<dItem>();
        static List<string> t = new List<string>()
        {
            "pszczoly","ul ","zdrowie","uzadlenie","pasieka","hodowla","ramki","miod","roj"
        };
        public TFM()
        {
            d = dItem.FillMe();
        }
        public TFM Licz(string StringFormat = "{0,2:#} | ")
        {
            for (int i = 0; i < d.Count; i++)
            {
                //   d[i].textFromFile = Helper.ReadFile(d[i].FileName).ToLowerInvariant();
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = d[i].FileName;

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    d[i].textFromFile = reader.ReadToEnd().ToLowerInvariant();
                }

                d[i].textFromFile = d[i].textFromFile.Replace("ą", "a").Replace("ę", "e").Replace("ś", "s").Replace("ć", "c").Replace("ł", "l").Replace("ń", "n").Replace("ó", "o").Replace("ź", "z").Replace("ż", "z");
                Add(new List<int>());
                for (int j = 0; j < t.Count; j++)
                    this[i].Add(Regex.Matches(d[i].textFromFile, t[j]).Count);
            }
            return this;
        }
        public void Wyswietl(string StringFormat = "{0,2:#} | ")
        {
            Console.WriteLine("TFM");
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < this[i].Count; j++)
                    Console.Write(String.Format(StringFormat, this[i][j]));
                Console.WriteLine();
            }
        }
    }
    class dItem
    {
        public dItem(string name)
        {
            FileName = "Inteligentne_systemy_decyzyjne.txtFiles."+ name;
        }
        public string FileName { get; set; }
        public string textFromFile { get; set; }
        public static List<dItem> FillMe()
        {
            return
                new List<dItem>()
                {
                    new dItem("d0.txt"),
                    new dItem("d1.txt"),
                    new dItem("d2.txt"),
                    new dItem("d3.txt"),
                    new dItem("d4.txt"),

                    new dItem("d5.txt"),
                    new dItem("d6.txt"),
                    new dItem("d7.txt"),
                    new dItem("d8.txt"),
                    new dItem("d9.txt"),

                    new dItem("d10.txt"),
                    new dItem("d11.txt"),
                    new dItem("d12.txt"),
                    new dItem("d13.txt"),
                    new dItem("d14.txt"),
                };
        }
    }
}
