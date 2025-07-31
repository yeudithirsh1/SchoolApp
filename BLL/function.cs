using DAL;
using ENTITES.Models;
using ENTITES;
namespace BLL
{
    public class function
    {
        Database Database = new Database();
        List<Student> StudentsList = new List<Student>();
        List<Teacher> TeachersList = new List<Teacher>();
        List<string> ClassList = new List<string>();

        public List<Student> LoadStudentsDetails()
        {
            var reader = Database.ReadFromDbStudents();
            while (reader.Read())
            {
                Student student = new Student
                {
                    Id = (int)reader["Id"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    HomePhone = reader["HomePhone"].ToString(),
                    BirthdayYear = (int)reader["BirthdayYear"],
                    Class = reader["Class"].ToString(),
                    Address = reader["Address"].ToString()
                };
                StudentsList.Add(student);
            }
            reader.Close();
            return StudentsList;
        }
        public List<Teacher> LoadTeachersDetails()
        {
            var reader = Database.ReadFromDbTeachers();
            while (reader.Read())
            {
                Teacher teacher = new Teacher()
                {
                    Id = (int)reader["Id"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    MailAddress = reader["MailAddress"].ToString(),
                };
                TeachersList.Add(teacher);
            }
            reader.Close();
            return TeachersList;
        }
        public List<string> LoadClass()
        {
            var reader = Database.ReadFromDbClass();
            while (reader.Read())
            {

                string Class = reader["Class"].ToString();
                ClassList.Add(Class);
            }
            reader.Close();
            return ClassList;
        }
    }
}
