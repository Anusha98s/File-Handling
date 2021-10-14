using System;
using System.IO;

namespace File_Handling
{ 

    class Program
    {
        static void Main(string[] args)
        {
            
    
            Console.WriteLine("File Handling......!");
            FileStream fs = new FileStream("C:\\Users\\Anusha.Sana\\OneDrive - Trianz\\Desktop\\My Details.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("We can Read and Display from file");

            string str = sr.ReadLine();
            while(str!= null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }

          
            sr.Close();


            FileStream fWrite = new FileStream("C:\\Users\\Anusha.Sana\\OneDrive - Trianz\\Desktop\\My Details.txt", FileMode.Append);
            StreamWriter swrite = new StreamWriter(fWrite);
            Console.WriteLine("Writing content to file.........\n");
            string content = Console.ReadLine();

            //string content = Console.ReadLine();
            swrite.Write(content);
            swrite.Flush();
            fWrite.Flush();

            fWrite.Close();
        }
    }
}
