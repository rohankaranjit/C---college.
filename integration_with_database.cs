using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DatabaseOperation_26795
{
internal class Program
{
static void Main(string[] args)
{
StudentInsert_Select obj = new StudentInsert_Select();
for (int i = 0; i < 2; i++)
{
Console.WriteLine("Enter Student:" + (i + 1));
Console.Write("Enter Name:");
string name = Console.ReadLine();
Console.Write("Enter Address:");
string address = Console.ReadLine();
Console.Write("Enter Gender:");
string gender = Console.ReadLine();
obj.Insert(name, address, gender);
Console.WriteLine("Record Inserted");
}
Console.WriteLine();
Console.WriteLine("*********************");
Console.WriteLine("All Student");
DataTable dt = obj.GetAllStudent();
for (int i = 0; i < dt.Rows.Count; i++)
{
string name = dt.Rows[i]["Name"].ToString();
string address = dt.Rows[i]["Address"].ToString();
string gender = dt.Rows[i]["Gender"].ToString();
Console.WriteLine("Name:{0} Address:{1} Gender:{2}", name, address, gender);
}
Console.WriteLine("*******************");
Console.WriteLine("Total No of Student: " + dt.Rows.Count);
Console.ReadLine();
}
}

