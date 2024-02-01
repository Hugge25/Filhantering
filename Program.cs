using System;
using System.IO;

class WriteToFile{
    public void Data()
    {
        StreamWriter sw = new StreamWriter("H://geeksforgeeks.txt");
        Console.WriteLine("Enter the text that you want to write on File");
        string str = Console.ReadLine();

        sw.WriteLine(str);

        sw.Flush();

        sw.Close();
    }
    WriteToFile wr = new WriteToFile();
}