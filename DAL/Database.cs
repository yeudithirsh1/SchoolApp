using System.Data.SQLite;

namespace DAL
{
    public class Database
    {
        public SQLiteDataReader ReadFromDbStudents()
        {
            var conn = new SQLiteConnection(@"Data Source=C:\Users\This User\Desktop\חומרים בתחנות\C#\שיעור 9 - Sqlite\School.db");
            conn.Open();
            var command = new SQLiteCommand("SELECT * FROM Students", conn);
            var reader = command.ExecuteReader();
            return reader;
        }
        public SQLiteDataReader ReadFromDbTeachers()
        {
            var conn = new SQLiteConnection(@"Data Source=C:\Users\This User\Desktop\חומרים בתחנות\C#\שיעור 9 - Sqlite\School.db");
            conn.Open();
            var command = new SQLiteCommand("SELECT * FROM Teachers", conn);
            var reader = command.ExecuteReader();
            return reader;
        }
        public SQLiteDataReader ReadFromDbClass()
        {
            var conn = new SQLiteConnection(@"Data Source=C:\Users\This User\Desktop\חומרים בתחנות\C#\שיעור 9 - Sqlite\School.db");
            conn.Open();
            var command = new SQLiteCommand("SELECT Class FROM HomeroomTeacherOfClass", conn);
            var reader = command.ExecuteReader();
            return reader;
        }
    }
}
