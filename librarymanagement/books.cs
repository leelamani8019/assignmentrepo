using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace librarymanagement
{
    public class books
    {
        public void createfile()
        {
            FileStream File = new FileStream(@"E:\laxman\librarymanagement\books.txt", FileMode.Append, FileAccess.Write);
            StreamWriter write = new StreamWriter(File);
            Console.WriteLine("enter the name of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the rent of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the author of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the name of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the rent of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the author of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the name of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the rent of the book");
            write.Write(Console.ReadLine());
            Console.WriteLine("enter the author of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            write.Write(",");
            Console.WriteLine("enter the name of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the rent of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the author of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the name of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the rent of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            Console.WriteLine("enter the author of the book");
            write.Write(Console.ReadLine());
            write.Write(",");
            write.Close();
            File.Close();
        }
        
    }
}
