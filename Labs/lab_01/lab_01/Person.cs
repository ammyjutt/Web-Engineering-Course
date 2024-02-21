using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//public class Person
//{

//    public String Name { get; set; }
//    public int Age { get; set; }
//    public String Email { get; set; }




//    public Person(String  name, int age , String email)
//    {
//        Name = name;
//        Age = age;
//        Email = email;
//    }

//}






public class Person
{

    public String Name { get; set; }
    public int Age { get; set; }
    private List<String> emails; 



    public Person() {
        this.emails = new List<String>();
    }


    public Person(String name, int age , params String[] mails) { 

        this.Name = name;
        this.Age = age;
        this.emails = new List<string>();


        foreach (String mail in mails)
        {
            this.emails.Add(mail);
        }
    
    }

    public void AddEmails(params String[] emails)
    {
        foreach(var email in emails)
        {
            this.emails.Add(email);
        }
    }


    public override string ToString()
    {
        String s = Name +","+ Age+",";
        foreach(var email in emails)
        {
            s += email;
            s += ",";
        }
        return s;
    }


    public void SaveToFile(String fileName)
    {

        //FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
        //StreamWriter sw = new StreamWriter(fs);
        //sw.WriteLine(this.ToString());
        //sw.Close();
        //fs.Close();


        FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);

        BinaryWriter bw = new BinaryWriter(fs);

        String person_str = this.ToString();

        foreach(char c in person_str)
        {
            bw.Write(c);
        }
        bw.Write('\n');
        bw.Close();
        fs.Close();

    }


}






