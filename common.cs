using Microsoft.Win32.TaskScheduler;
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
                            Globals.Logger.Info("[mod]_1 " + filePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing file {filePath}: {ex.Message}");
                    Globals.Logger.Error($"Error processing file {filePath}: {ex.Message}");
                }
            }
        }

        public void GrepByUsbDevice(string usbFile, string sVolNo, string sMainFolders = @"C:\BackupConf")
        {
            if (usbFile == "usb3") usbFile = "lbd";
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
                            Globals.Logger.Info("[mod]_2 " + filePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing file {filePath}: {ex.Message}");
                    Globals.Logger.Error($"Error processing file {filePath}: {ex.Message}");
                }
            }
        }

        public void GrepByUsbDeviceLetter(string usbFile, string sLetter, string sMainFolders = @"C:\BackupConf")
        {
            if (usbFile == "usb3") usbFile = "lbd";
            string pattern = "assign letter (.{1,3})";
            string replacement = "assign letter " + sLetter;
            bool foundMatch = false;
            string searchPattern = "*" + usbFile + "*.*";
            string modifiedContent = string.Empty;

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
                        modifiedContent = Regex.Replace(content, pattern, replacement, RegexOptions.IgnoreCase | RegexOptions.Multiline);

                        // Write the modified content back to the file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.Write(modifiedContent);
                            Debug.WriteLine("[mod]_3 " + filePath);
                            Globals.Logger.Info("[mod]_3 " + filePath);
                        }
                    }
                    
                    // disk_letter change
                    string contentA = string.Empty;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        contentA = reader.ReadToEnd();
                    }
                    modifiedContent = string.Empty;
                    pattern = "disk_letter=(.{1,1})";
                    replacement = "disk_letter=" + sLetter;
                    foundMatch = false;
                    foundMatch = Regex.IsMatch(contentA, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    if (foundMatch)
                    {
                        modifiedContent = Regex.Replace(contentA, pattern, replacement, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.Write(modifiedContent);
                            Debug.WriteLine("[mod]_3.A " + filePath);
                            Globals.Logger.Info("[mod]_3.A " + filePath);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing file {filePath}: {ex.Message}");
                    Globals.Logger.Error($"Error processing file {filePath}: {ex.Message}");
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
                            Globals.Logger.Info("[mod]_4 " + filePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing file {filePath}: {ex.Message}");
                    Globals.Logger.Error($"Error processing file {filePath}: {ex.Message}");
                }
            }
        }


        public void GrepByUsbDevice12Letter(string usbFile, string sLetter, string sMainFolders = @"C:\BackupConf")
        {
            if (usbFile == "usb3") usbFile = "lbd";
            string pattern = "assign letter (.{1,3})";
            string replacement = "assign letter " + sLetter;
            bool foundMatch = false;
            string searchPattern = "*.*";
            string modifiedContent = string.Empty;

            foreach (string filePath in Directory.EnumerateFiles(sMainFolders, searchPattern, SearchOption.AllDirectories))
            {
                try
                {
                    //disk1_letter disk2_letter
                    string contentB = string.Empty;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        contentB = reader.ReadToEnd();
                    }
                    modifiedContent = string.Empty;
                    int usbNO = 0;
                    if (usbFile == "usb1") usbNO = 1;
                    if (usbFile == "usb2") usbNO = 2;

                    if (usbNO > 0)
                    {
                        pattern = "disk" + usbNO + "_letter=(.{1,1})";
                        replacement = "disk" + usbNO + "_letter=" + sLetter;
                        foundMatch = false;
                        foundMatch = Regex.IsMatch(contentB, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                        if (foundMatch)
                        {
                            modifiedContent = Regex.Replace(contentB, pattern, replacement, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                writer.Write(modifiedContent);
                                Debug.WriteLine("[mod]_3.B " + filePath);
                                Globals.Logger.Info("[mod]_3.B " + filePath);
                            }
                        }
                    }
                }
                catch (Exception ex) 
                {
                    Debug.WriteLine("error 3.B " + ex.ToString());
                    Globals.Logger.Error("error 3.B " + ex.ToString());
                }
            }
        }

        public void CreateJob()
        {
            // Create a new TaskService instance
            using (TaskService taskService = new TaskService())
            {
                // Define the task properties
                TaskDefinition taskDefinition = taskService.NewTask();
                taskDefinition.RegistrationInfo.Description = "My Scheduled Task";
                taskDefinition.Principal.UserId = "NT AUTHORITY\\SYSTEM"; // Run as System account

                // Define the trigger (e.g., run daily at 3:00 AM)
                taskDefinition.Triggers.Add(new DailyTrigger { DaysInterval = 1, StartBoundary = DateTime.Today.AddHours(5) });

                // Define the action (e.g., run a console application)
                taskDefinition.Actions.Add(new ExecAction("MyConsoleApp.exe", null, null));

                // Register the task with the Task Scheduler
                taskService.RootFolder.RegisterTaskDefinition("MyTask", taskDefinition);
            }

            Console.WriteLine("Task created successfully.");
            Globals.Logger.Info("Task created successfully.");
        }



    }
}
