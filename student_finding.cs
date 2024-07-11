using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
namespace rohan_26819
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> st = new List<Student>();
            st.Add(new Student() { ID = 1, Name = "Sunil Chaudhary", Address = "Kathmandu", Gender = "Male" });
            st.Add(new Student() { ID = 1, Name = "Rohan Karanjit", Address = "Bhaktapur", Gender = "Male" });
            st.Add(new Student() { ID = 1, Name = "Mashin Maharjan", Address = "Bhaktapur", Gender = "Male" });
            st.Add(new Student() { ID = 1, Name = "Gita Shrestha", Address = "Lalitpur", Gender = "Female" });
            st.Add(new Student() { ID = 1, Name = "Sita Gautam", Address = "Kathmandu", Gender = "Female" });
            st.Add(new Student() { ID = 1, Name = "Ramesh Acharya", Address = "Kathmandu", Gender = "Male" });
            st.Add(new Student() { ID = 1, Name = "Mina THpaliya", Address = "Lalitpur", Gender = "Female" });
            st.Add(new Student() { ID = 1, Name = "Jivan Dhunagna", Address = "Kathmandu", Gender = "Male" });
            st.Add(new Student() { ID = 1, Name = "Hari Adhikari", Address = "Bhaktapur", Gender = "Male" });
            st.Add(new Student() { ID = 1, Name = "Mukesh Shah", Address = "Kathmandu", Gender = "Male" });
            Console.WriteLine("********************LIST OF STUDENTS********************");

