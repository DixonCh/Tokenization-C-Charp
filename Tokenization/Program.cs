using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tokinization
{
    public class itemWithFrequency
    {
        public string itemname;
        public int frequency = 0;
        public itemWithFrequency(string itemname, int ferquency)
        {
            this.itemname = itemname;
            this.frequency = frequency;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<itemWithFrequency> frequencycount = new List<itemWithFrequency>();
            string[] lines = System.IO.File.ReadAllLines(@"E:\Lab Works 2nd SEM\WSA\Tokinization\dataset.txt");
            string status = TokenizeFunction(lines);
            //to count frequency
            //string[] tokenizetext = System.IO.File.ReadAllLines(@"C:\E:\Dixon\WSA\Tokinization\tokenizedata.txt");
            //string[] saperate = tokenizetext[0].Split(',');
            //int count = Convert.ToInt32(saperate[0]);
            //tokenizetext[0] = saperate[1];
            //string[] individualWords = new string[count];
            //individualWords = individualcharacter(tokenizetext);
            //string[] distinctData = individualWords.Distinct().ToArray();
            //int distinctCount = distinctData.Count();
            //for (int i = 0; i < distinctCount; i++)
            //{
            //    itemWithFrequency item1 = new itemWithFrequency(distinctData[i], 0);
            //    for (int j = 0; j < count; j++)
            //    {
            //        if (string.Equals(item1.itemname, individualWords[j]) == true)
            //        {
            //            item1.frequency += 1;
            //        }
            //    }
            //    frequencycount.Add(item1);
            //}
            ////foreach (var item in frequencycount)
            ////{
            ////    Console.WriteLine(item.itemname + " " + item.frequency);
            ////}
            //List<itemWithFrequency> sortedData = frequencycount.OrderByDescending(a => a.frequency).ToList();
            //string[] writefrequencyData = new string[distinctCount];
            //int k = 0;
            //foreach (var item in sortedData)
            //{
            //    writefrequencyData[k] = item.itemname + "     " + item.frequency;
            //    k++;
            //}
            //System.IO.File.WriteAllLines(@"E:\Dixon\WSA\Tokinization\frequencydata.txt", writefrequencyData);
            //Console.WriteLine("Finish Data Writting");
            Console.ReadKey();
        }
        public static string TokenizeFunction(string[] lines)
        {
            string status = "";
            string[] individualWords = new string[300000];
            individualWords = individualcharacter(lines);
            string tokenizedata = "";
            //  Console.WriteLine( individualWords.Count());
            int numberofWords = 0;
            foreach (var item in individualWords)
            {
                if (item != null)
                {
                    tokenizedata = tokenizedata + item + " ";
                    numberofWords++;
                }
                else
                {
                    break;
                }
            }
            tokenizedata = numberofWords + "," + tokenizedata;
            System.IO.File.WriteAllText(@"E:\Dixon\WSA\Tokinization\tokenizedata.txt", tokenizedata);
            return status;
        }
        // divide the string into array of individual words
        public static string[] individualcharacter(string[] lines)
        {
            string[] individualWords = new string[300000];
            int index = 0;
            // Console.WriteLine(lines.Count());
            foreach (var item in lines)
            {
                string[] words = item.Split(' ', '.', ',', '-');
                foreach (var word in words)
                {
                    if (word != "")
                    {
                        individualWords[index] = word;
                        index++;
                    }

                }
            }
            return individualWords;
        }

    }
}
