using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

        public void GrepIpByEveryFiles(string sIPAddress, string sMainFolders = @"C:\BackupConf")
        {
            string pattern = @"ping (\d{1,3})\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})";
            string replacement = "ping " + sIPAddress;
            bool foundMatch = false;

            foreach (string filePath in Directory.EnumerateFiles(sMainFolders, "*", SearchOption.AllDirectories))
            {
                try
                {
                    string content;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        content = reader.ReadToEnd();
                    }
                    foundMatch = false;
                    foundMatch = Regex.IsMatch(content, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    if (foundMatch)
                    {
                        // Perform the replacement
                        string modifiedContent = Regex.Replace(content, pattern, replacement, RegexOptions.IgnoreCase | RegexOptions.Multiline);

                        // Write the modified content back to the file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.Write(modifiedContent);
                            Debug.WriteLine("[mod]_1 " + filePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing file {filePath}: {ex.Message}");
                }
            }
        }

        public void GrepByUsbDevice(string usbFile, string sVolNo, string sMainFolders = @"C:\BackupConf")
        {
            string pattern = @"select volume (\d{1,3})";
            string replacement = "select volume " + sVolNo;
            bool foundMatch = false;
            string searchPattern = "*" + usbFile + "*.*";

            foreach (string filePath in Directory.EnumerateFiles(sMainFolders, searchPattern, SearchOption.AllDirectories))
            {
                try
                {
                    string content;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        content = reader.ReadToEnd();
                    }
                    foundMatch = false;
                    foundMatch = Regex.IsMatch(content, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    if (foundMatch)
                    {
                        // Perform the replacement
                        string modifiedContent = Regex.Replace(content, pattern, replacement, RegexOptions.IgnoreCase | RegexOptions.Multiline);

                        // Write the modified content back to the file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.Write(modifiedContent);
                            Debug.WriteLine("[mod]_2 " + filePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing file {filePath}: {ex.Message}");
                }
            }
        }

        public void GrepByUsbDeviceLetter(string usbFile, string sLetter, string sMainFolders = @"C:\BackupConf")
        {
            string pattern = "assign letter (.{1,3})";
            string replacement = "assign letter " + sLetter;
            bool foundMatch = false;
            string searchPattern = "*" + usbFile + "*.*";

            foreach (string filePath in Directory.EnumerateFiles(sMainFolders, searchPattern, SearchOption.AllDirectories))
            {
                try
                {
                    string content;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        content = reader.ReadToEnd();
                    }
                    foundMatch = false;
                    foundMatch = Regex.IsMatch(content, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    if (foundMatch)
                    {
                        // Perform the replacement
                        string modifiedContent = Regex.Replace(content, pattern, replacement, RegexOptions.IgnoreCase | RegexOptions.Multiline);

                        // Write the modified content back to the file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.Write(modifiedContent);
                            Debug.WriteLine("[mod]_3 " + filePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing file {filePath}: {ex.Message}");
                }
            }
        }


        public void GrepByUsbDeviceDisk(string usbFile, string sDiskNo, string sMainFolders = @"C:\BackupConf")
        {
            if (usbFile == "usb3") usbFile = "lbd";
            string pattern = @"select disk (\d{1,3})";
            string replacement = "select disk " + sDiskNo;
            bool foundMatch = false;
            string searchPattern = "*" + usbFile + "*.*";

            foreach (string filePath in Directory.EnumerateFiles(sMainFolders, searchPattern, SearchOption.AllDirectories))
            {
                try
                {
                    string content;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        content = reader.ReadToEnd();
                    }
                    foundMatch = false;
                    foundMatch = Regex.IsMatch(content, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    if (foundMatch)
                    {
                        // Perform the replacement
                        string modifiedContent = Regex.Replace(content, pattern, replacement, RegexOptions.IgnoreCase | RegexOptions.Multiline);

                        // Write the modified content back to the file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.Write(modifiedContent);
                            Debug.WriteLine("[mod]_4 " + filePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing file {filePath}: {ex.Message}");
                }
            }
        }



    }
}
