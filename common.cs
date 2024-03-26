using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DisCO
{
    public class Common
    {        

        public void GetPropertyValue(string fileName, string sProperty)
        {
            string[] lines = File.ReadAllLines(fileName);
            Dictionary<string, string> properties = new Dictionary<string, string>();
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith(";") || line.StartsWith("#"))
                    continue;
                string[] parts = line.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    string property = parts[0].Trim();
                    string value = parts[1].Trim();
                    properties[property] = value;
                }
                else
                {
                    Debug.WriteLine($"Invalid line format: {line}");
                }
            }
        }

        public void SetPropertyValue(string fileName, string propertyToSet, string newValue ) {
            string[] lines = File.ReadAllLines(fileName);
            for(int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line.StartsWith(propertyToSet + "="))
                {
                    lines[i] = propertyToSet + "=" + newValue;
                    break;
                }
            }

            File.WriteAllLines(fileName, lines);
        }

    }
}
