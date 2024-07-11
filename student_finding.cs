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
            foreach (var item in st)
            {
                Console.WriteLine("Name:{0} Address:{1} Gender:{1}", item.Name, item.Address, item.Gender);
            }
            Console.WriteLine();
            Console.WriteLine("********************STUDENTS WITH ADDRESS KATHMANDU********************");
            List<Student> filterStudent = FindStudentByAddress(st, "Kathmandu");
            foreach (var item in filterStudent)
            {
                Console.WriteLine("Name:{0} Address:{1} Gender:{2}", item.Name, item.Address, item.Gender);
            }
            Console.ReadLine();
        }
        public static List<Student> FindStudentByAddress(List<Student> students, string searchAddress)
        {
            List<Student> filterStudent = new List<Student>();
            foreach (Student item in students)
            {

                if (item.Address == searchAddress)
                {
                    filterStudent.Add(item);
                }
            }
            return filterStudent;
        }
    }

