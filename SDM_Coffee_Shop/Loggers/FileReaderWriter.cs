using System;
using System.Collections.Generic;
using System.IO;

namespace SDM_Coffee_Shop
{
    internal class FileReaderWriter
    {
        private string pATH_LOG_ORDERS = $"C:\\Users\\{Environment.UserName}\\source\\repos\\SDM_Coffee_Shop\\SDM_Coffee_Shop\\orderslog.txt";

        public string PATH_LOG_ORDERS
        {
            get { return pATH_LOG_ORDERS; }
        }

        private string dateTime = Convert.ToString(System.DateTime.Now);

        public void WriteDataToFile(string textToWriteToFile, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, true)) 
            { 
                writer.WriteLine(textToWriteToFile); 
            }             
        }

        public void WriteDataToFile(string[] lines)
        {
            WriteDataToFile(lines, PATH_LOG_ORDERS);
        }

        public void WriteDataToFile(string[] lines, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine();
                foreach (string line in lines)
                {
                    writer.Write($"{line} ");
                }
            }
            //true om nieuwe tekst toe te voegen ipv overschrijven.           
        }

        public List<string> ReadDataFromFile(string path)
        {
            List<string> lines = new List<string>();
            string line = string.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}