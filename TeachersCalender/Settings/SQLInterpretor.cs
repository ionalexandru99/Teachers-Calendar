using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using TeachersCalender.Entities;

namespace TeachersCalender.Settings
{
    class SQLInterpretor
    {
        public string ConnectionString { get; }

        public dynamic Json { get; }

        public SQLInterpretor()
        {
            var jsonString = new StreamReader(@".\Settings\config.json").ReadToEnd();
            Json = JsonConvert.DeserializeObject(jsonString);
            ConnectionString = Json?.ConnectionString;
        }

        #region Add Value to table

        public void AddRoom(Room room, List<Room> rooms = null, SQLiteConnection connection = null)
        {

            var queryString = "insert into ROOMS(Name, Size) values (@name, @size)";
            if (connection == null)
            {
                using (connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    var command = new SQLiteCommand(queryString, connection);
                    command.Parameters.AddWithValue("@name", room.Name);
                    command.Parameters.AddWithValue("@size", room.Size);

                    if (command.ExecuteNonQuery() != 0)
                    {
                        if (rooms != null)
                            rooms.Add(room);
                    }
                }
            }
            else
            {
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@name", room.Name);
                command.Parameters.AddWithValue("@size", room.Size);

                if (command.ExecuteNonQuery() != 0)
                {
                    if (rooms != null)
                        rooms.Add(room);
                }
            }

        }

        public void AddTeacher(Teacher teacher, List<Teacher> teachers = null, SQLiteConnection connection = null)
        {

            var queryString = "insert into TEACHERS(Name) values (@name)";
            if (connection == null)
            {
                using (connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    var command = new SQLiteCommand(queryString, connection);
                    command.Parameters.AddWithValue("@name", teacher.Name);

                    if (command.ExecuteNonQuery() != 0)
                    {
                        if (teachers != null)
                            teachers.Add(teacher);
                    }
                }
            }
            else
            {
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@name", teacher.Name);

                if (command.ExecuteNonQuery() != 0)
                {
                    if (teachers != null)
                        teachers.Add(teacher);
                }
            }

        }

        public void AddSubject(Subject subject, List<Subject> subjects = null, SQLiteConnection connection = null)
        {

            var queryString = "insert into SUBJECTS(Name, Credits) values (@name, @credits)";
            if (connection == null)
            {
                using (connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    var command = new SQLiteCommand(queryString, connection);
                    command.Parameters.AddWithValue("@name", subject.Name);
                    command.Parameters.AddWithValue("@credits", subject.Credits);

                    if (command.ExecuteNonQuery() != 0)
                    {
                        if (subjects != null)
                            subjects.Add(subject);
                    }
                }
            }
            else
            {
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@name", subject.Name);
                command.Parameters.AddWithValue("@credits", subject.Credits);

                if (command.ExecuteNonQuery() != 0)
                {
                    if (subjects != null)
                        subjects.Add(subject);
                }
            }

        }
        public void AddLecture(Lecture lecture, List<Lecture> lectures = null, SQLiteConnection connection = null)
        {

            var queryString = "insert into LECTURES(Teacher_Name, Subject_Name, Room_Name, Date) values (@teacherName, @subjectName, @roomsName, @date)";
            if (connection == null)
            {
                using (connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    var command = new SQLiteCommand(queryString, connection);
                    command.Parameters.AddWithValue("@teacherName", lecture.Teacher);
                    command.Parameters.AddWithValue("@subjectName", lecture.Subject);
                    command.Parameters.AddWithValue("@roomsName", lecture.Room);
                    command.Parameters.AddWithValue("@date", lecture.Date.ToShortDateString());

                    if (command.ExecuteNonQuery() != 0)
                    {
                        if (lectures != null)
                            lectures.Add(lecture);
                    }
                }
            }
            else
            {
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@teacherName", lecture.Teacher);
                command.Parameters.AddWithValue("@subjectName", lecture.Subject);
                command.Parameters.AddWithValue("@roomsName", lecture.Room);
                command.Parameters.AddWithValue("@date", lecture.Date.ToString());

                if (command.ExecuteNonQuery() != 0)
                {
                    if (lectures != null)
                        lectures.Add(lecture);
                }
            }

        }


        #endregion

        #region Load Tables
        public void LoadRooms(out List<Room> rooms)
        {
            const string stringSql = "SELECT * from ROOMS";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(stringSql, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    rooms = new List<Room>();
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        int size = (int)(long)reader["Size"];

                        Room room = new Room(name, size);
                        rooms.Add(room);
                    }
                }
            }
        }

        public void LoadTeachers(out List<Teacher> teachers)
        {
            const string stringSql = "SELECT * from TEACHERS";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(stringSql, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    teachers = new List<Teacher>();
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];

                        Teacher teacher = new Teacher(name);
                        teachers.Add(teacher);
                    }
                }
            }
        }

        public void LoadSubjects(out List<Subject> subjects)
        {
            const string stringSql = "SELECT * from SUBJECTS";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(stringSql, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    subjects = new List<Subject>();
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        int credits = (int)(long)reader["Credits"];

                        Subject subject = new Subject(name, credits);
                        subjects.Add(subject);
                    }
                }
            }
        }

        public void LoadLectures(out List<Lecture> lectures)
        {
            const string stringSql = "SELECT * from LECTURES";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(stringSql, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    lectures = new List<Lecture>();
                    while (reader.Read())
                    {
                        string teacher = (string)reader["Teacher_Name"];
                        string subject = (string)reader["Subject_Name"];
                        string room = (string)reader["Room_Name"];
                        DateTime date = DateTime.ParseExact((string)reader["Date"], "M/d/yyyy", CultureInfo.CurrentCulture);

                        Lecture lecture = new Lecture(teacher, subject, room, date);
                        lectures.Add(lecture);
                    }
                }
            }
        }

        #endregion

        #region Delete row
        public void DeleteRoom(Room room)
        {
            if (room == null)
            {
                return;
            }

            string stringSql = "DELETE FROM ROOMS WHERE name=@name";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(stringSql, connection))
                {
                    command.Parameters.AddWithValue("@name", room.Name);
                    command.ExecuteNonQuery();
                }
            }

        }
        public void DeleteTeacher(Teacher teacher)
        {
            string stringSql = "DELETE FROM TEACHERS WHERE name=@name";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(stringSql, connection))
                {
                    command.Parameters.AddWithValue("@name", teacher.Name);
                    command.ExecuteNonQuery();
                }
            }

        }
        public void DeleteSubject(Subject subject)
        {
            if (subject == null)
            {
                return;
            }

            string stringSql = "DELETE FROM SUBJECTS WHERE name=@name";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(stringSql, connection))
                {
                    command.Parameters.AddWithValue("@name", subject.Name);
                    command.ExecuteNonQuery();
                }
            }

        }
        public void DeleteLecture(string name)
        {
            string stringSql = "DELETE FROM LECTURES WHERE teacher_name=@name or subject_name=@name or room_name=@name";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(stringSql, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.ExecuteNonQuery();
                }
            }

        }

        #endregion

        #region Delete Table Content
        public void DeleteRooms()
        {
            string sqlString = "DELETE FROM ROOMS";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(sqlString, connection);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteTeachers()
        {
            string sqlString = "DELETE FROM TEACHERS";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(sqlString, connection);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteSubjects()
        {
            string sqlString = "DELETE FROM SUBJECTS";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(sqlString, connection);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteLectures()
        {
            string sqlString = "DELETE FROM LECTURES";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(sqlString, connection);
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region Filter

        public void RoomFilter(out List<Room> rooms, int min, int max)
        {
            string sqlString = "Select * FROM ROOMS WHERE size >= @min and size <= @max";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(sqlString, connection);
                command.Parameters.AddWithValue("@min", min);
                command.Parameters.AddWithValue("@max", max);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    rooms = new List<Room>();
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        int size = (int)(long)reader["Size"];

                        Room room = new Room(name, size);
                        rooms.Add(room);
                    }
                    Console.WriteLine(rooms.Count);
                }
            }
        }


        internal void SubjectFilter(out List<Subject> subjects, int min, int max)
        {
            string sqlString = "Select * FROM SUBJECTS WHERE credits >= @min and credits <= @max";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(sqlString, connection);
                command.Parameters.AddWithValue("@min", min);
                command.Parameters.AddWithValue("@max", max);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    subjects = new List<Subject>();
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        int credits = (int)(long)reader["Credits"];

                        Subject subject = new Subject(name, credits);
                        subjects.Add(subject);
                    }
                    Console.WriteLine(subjects.Count);
                }
            }
        }

        internal void TeacherFilter(List<Teacher> teachers, string name)
        {
            List<Teacher> copyTeachers = new List<Teacher>(teachers);

            foreach (Teacher teacher in copyTeachers)
            {
                if (!teacher.Name.Equals(name))
                {
                    teachers.Remove(teacher);
                }
            }
        }

        internal List<Lecture> LectureFilter(Teacher teacher, List<Lecture> lectures = null)
        {
            if (lectures == null)
            {
                lectures = new List<Lecture>();
                LoadLectures(out lectures);
            }

            List<Lecture> copyLectures = new List<Lecture>(lectures);

            foreach (Lecture lecture in copyLectures)
            {
                if (!lecture.Teacher.Equals(teacher.Name))
                {
                    lectures.Remove(lecture);
                }
            }

            return lectures;
        }

        internal List<Lecture> LectureFilter(string subject, List<Lecture> lectures = null)
        {
            if (lectures == null)
            {
                lectures = new List<Lecture>();
                LoadLectures(out lectures);
            }

            List<Lecture> list = new List<Lecture>(lectures);
            foreach (Lecture lecture in list)
            {
                if (!lecture.Subject.Equals(subject))
                {
                    lectures.Remove(lecture);
                }
            }

            return lectures;
        }

        internal List<Lecture> LectureFilter(DateTime date, List<Lecture> lectures = null)
        {
            if (lectures == null)
            {
                lectures = new List<Lecture>();
                LoadLectures(out lectures);
            }

            List<Lecture> list = new List<Lecture>(lectures);
            foreach (Lecture lecture in list)
            {
                if (!(lecture.Date == date))
                {
                    lectures.Remove(lecture);
                }
            }

            return lectures;
        }

        #endregion // work in progress

        #region Edit
        internal void EditRoom(Room oldRoom, Room newRoom, List<Room> rooms = null)
        {
            string updateString = "UPDATE ROOMS SET name=@name, size=@size WHERE name=@oldName";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(updateString, connection);
                command.Parameters.AddWithValue("@name", newRoom.Name);
                command.Parameters.AddWithValue("@size", newRoom.Size);
                command.Parameters.AddWithValue("@oldName", oldRoom.Name);

                if (command.ExecuteNonQuery() != 0)
                {
                    if (rooms != null)
                    {
                        foreach (Room listroom in rooms)
                        {
                            if (listroom.Name.Equals(oldRoom.Name))
                            {
                                listroom.Name = newRoom.Name;
                                listroom.Size = newRoom.Size;
                                break;
                            }
                        }
                    }
                }
            }
        }
        internal void EditSubject(Subject oldSubject, Subject newSubject, List<Subject> subjects)
        {
            string updateString = "UPDATE SUBJECTS SET name=@name, credits=@size WHERE name=@oldName";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(updateString, connection);
                command.Parameters.AddWithValue("@name", newSubject.Name);
                command.Parameters.AddWithValue("@size", newSubject.Credits);
                command.Parameters.AddWithValue("@oldName", oldSubject.Name);

                if (command.ExecuteNonQuery() != 0)
                {
                    if (subjects != null)
                    {
                        foreach (Subject listSubject in subjects)
                        {
                            if (listSubject.Name.Equals(oldSubject.Name))
                            {
                                listSubject.Name = newSubject.Name;
                                listSubject.Credits = newSubject.Credits;
                                break;
                            }
                        }
                    }
                }
            }
        }
        #endregion // work in progress
    }
}