using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Data.SqlClient;
using System.Collections;





public class Store
{ 
    public Store(int id , string name)
    {
        this.Name = name;
        this.Id = id;   
    }
    public int Id {  get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return Id +","+ Name;
    }

}
public class Product
{
 
    public Store s {  get; set; }

    public Product(String name , int id , string desc , int Price , int storeId , string storeName)
    {
        this.Name = name;
        this.Id = id;
        this.Description = desc;
        this.Price = Price;
        this.s = new Store(storeId ,storeName);
   
    }


    // auto implemented properties
    public int Id { get; set; }
    public string Name { get; set; }
    [JsonIgnore]
    public string Description { get; set; }
    public int Price { get; set; }


    public override string ToString()
    {
        return Id + "," + Description + "," + Name;
    }

}



class Program
{


    public static void Main()
    {


        //Product p = new Product(id: 1, name: "amir", desc: "very good product", Price: 2300 , storeId:100 , storeName:"Amanah");

        //string per_json_str = JsonSerializer.Serialize(p);
        //Console.WriteLine(per_json_str);

        //StreamWriter sw = new StreamWriter("output_file.txt" , true);

        //sw.WriteLine(per_json_str);

        //sw.Close();


        //StreamReader sr = new StreamReader("output_file.txt");
        //string str = sr.ReadLine();

        //Product p = JsonSerializer.Deserialize<Product>(str);

        //Console.WriteLine(p);


        //String connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_01;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //SqlConnection connection = new SqlConnection(connectionString);
        //connection.Open();

        //string q = "select * from MYUSER";

        //SqlCommand cmd = new SqlCommand(q , connection);

        //SqlDataReader dr = cmd.ExecuteReader();

        //while(dr.Read())
        //{
        //    Console.WriteLine(dr[0].ToString());
        //    Console.WriteLine(dr[1].ToString());

        //}



        //ArrayList ar = new ArrayList();

        //ar.Add(1);
        //ar.Add("my");

        //foreach(var i in ar)
        //{
        //    Console.WriteLine(i);
        //}
       


        

    }


}





