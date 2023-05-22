using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _15_BazaDanychWlasne
{
    internal class DbService
    {
        private string _connectionString = "Server=.\\;Initial Catalog=Baza;User ID=stefix;Password=123456QWErty;MultipleActiveResultSets=True;TrustServerCertificate=True";

        private SqlConnection _connection;
        public DbService()
        {
            _connection = new SqlConnection(_connectionString);
        }

        public List<Student> GetStudentsFromDb()
        {
            _connection.Open();
            var result = new List<Student>();
            using var selectStudent = new SqlCommand("select * from Students", _connection);
            var reader = selectStudent.ExecuteReader();
            while (reader.Read())
            {
                var student = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5));
                result.Add(student);
            }

            _connection.Close();
            return result;
        }


        public void AddStudent(Student student)
        {
            _connection.Open();
            var arg1 = new SqlParameter("arg1", student.LastName);
            var arg2 = new SqlParameter("arg2", student.FirstName);
            var arg3 = new SqlParameter("arg3", student.Major);
            var arg4 = new SqlParameter("arg4", student.Year);
            var arg5 = new SqlParameter("arg5", student.GPA);


            using var selectStudent = new SqlCommand("insert into Students values(@arg1, @arg2, @arg3, @arg4, @arg5)", _connection);
            selectStudent.Parameters.Add(arg1);
            selectStudent.Parameters.Add(arg2);
            selectStudent.Parameters.Add(arg3);
            selectStudent.Parameters.Add(arg4);
            selectStudent.Parameters.Add(arg5);

            selectStudent.ExecuteNonQuery();

            _connection.Close();
        }
        public void DeleteStudent (int id)
        {
            var allStudnets = GetStudentsFromDb();
            var existingStudnet = allStudnets.FirstOrDefault(s => s.Id == id);
            if (existingStudnet == null)
            {
                Console.WriteLine("podano nieistniejacy numer id");
                return;
            }
            _connection.Open();
            using var selectStudent = new SqlCommand($"delete from Students where id = {id}", _connection);
            selectStudent.ExecuteNonQuery();
            _connection.Close();
        }
        public void EditStudent(Student student)
        {
            var allStudents = GetStudentsFromDb();

            var existingStudent = allStudents.FirstOrDefault(u => u.Id == student.Id);

            if (existingStudent == null)
            {
                Console.WriteLine("nie ma takiego studenciaka");
                return;
            }

            _connection.Open();

            using var selectStudent = new SqlCommand(@$"
            update Students set
            [LastName] = '{student.LastName}'
            ,[FirstName] = '{student.FirstName}'
            ,[Major] = '{student.Major}'
            ,[Year] = '{student.Year}'
            ,[GPA] = '{(student.GPA)}'
            where id = '{student.Id}'
            ", _connection);

            selectStudent.ExecuteNonQuery();

            _connection.Close();
        }
    }


}

