using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person p1 = new Person(name: "amir", age: 21, email: "7mramir@gmail.com");

            //Person p1 = new Person();

            //p1.AddEmails("amir@" , "ahmad@");



            Person p1 = new Person(name: "amir", age: 21, "amir@", "ahmad@");
            Console.WriteLine(p1);
            p1.AddEmails("zubair@");
            p1.SaveToFile("file_one.txt");



        }
    }
}
