using System;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Security.Cryptography;
using System.Text;

class Program
{
public static void Main()
    {
        
        Program p = new Program();
        p.Readtext();
       
    }


    public  void Readtext()
    {
        try
        {
            
            string text = File.ReadAllText(@"E:\Designite\pushkar.txt");
            
            string now = Convert.ToString(DateTime.UtcNow.ToShortDateString());
            File.AppendAllText(@"E:\Designite\pushkar.txt", now);
            Console.WriteLine(text);
         
            byte[] b = ASCIIEncoding.ASCII.GetBytes(text);
            string encrypted = Convert.ToBase64String(b);
            File.AppendAllText(@"E:\Designite\pushkar.txt", encrypted);
            string Etext = encrypted;
            File.WriteAllText(@"E:\Designite\push.txt", Etext);
            string text1 = File.ReadAllText(@"E:\Designite\push.txt");
            Console.WriteLine(text1);

            Console.ReadKey();
           
        }
            catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);

        }
            Console.ReadKey();
    }
   
}