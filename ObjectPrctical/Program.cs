using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;

namespace ObjectPrctical
{
    public class Program
    {
        private const string Value = "The file could not be read:";

        public static void Main()
        {
            var program = new Program();
            Program p = program;
            p.ReadTextarea();
        }

        public void ReadTextarea()
        {
            try
            {
                var text = File.ReadAllText(@"E:\Designite\pushkar.txt");

                using (var response = WebRequest.Create("http://www.google.com").GetResponse())
                {
                    var now = Convert.ToString(
                        DateTime.ParseExact(response.Headers["date"], "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                            CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal),
                        CultureInfo.CurrentCulture);
                    File.AppendAllText(@"E:\Designite\pushkar.txt", now);
                }

                Console.WriteLine(text);
                var b = Encoding.ASCII.GetBytes(text);
                var encrypted = Convert.ToBase64String(b);
                File.AppendAllText(@"E:\Designite\pushkar.txt", encrypted);
                string tex = encrypted;
                File.WriteAllText(@"E:\Designite\push.txt", tex);
                var text1 = File.ReadAllText(@"E:\Designite\push.txt");
                Console.WriteLine(value: text1);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(Value);
                if (e.Message != null)
                {
                    Console.WriteLine(value: e.Message);
                }
            }

            Console.ReadKey();
        }
    }
}