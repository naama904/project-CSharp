using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tools;

public static class LogManager
{
    private static string logFolderPath = "Log";
   
    public static string GetCurrentFolderPath()
    {
         string folderPath = @$"{logFolderPath}\_{DateTime.Now.Year}_{DateTime.Now.Month}";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            return folderPath;
    }
    public static string GetCurrentFilePath()
    {
        string filePath = @$"{GetCurrentFolderPath()}\{DateTime.Now.Day}.txt";
        if (!File.Exists(filePath))
           File.Create(filePath).Close();
        return filePath;
    }
    public static void WriteToLog(string nameProject, string nameFunc,string message)
    {
        using (StreamWriter sw = new StreamWriter(LogManager.GetCurrentFilePath(), true))
        {
            sw.WriteLine($"{DateTime.Now}\t{nameProject}.{nameFunc}:\t{message}");
        }
    }
    public static void CleanOldFolder()
    {
        DateTime date = DateTime.Now.AddMonths(-2);
        string[]directorys=Directory.GetDirectories(logFolderPath);
        foreach (string folder in directorys )
        {
            DateTime diractionTime=Directory.GetCreationTime(folder);
            if (diractionTime < date)
                Directory.Delete(folder, true);  
        }
    }
}
