using ConnectToDB.Models;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ConnectToDB.Data
{
    public class DBLayer
    {
        private IConfiguration _config;
        private string conn;

        public DBLayer(IConfiguration configuration)
        {
            _config = configuration;
            conn = _config.GetConnectionString("dbConnect");
        }
        public List<Student> AllStudents()
        {
            string id = "", name = "", surname = "";
            List<Student> stList = new List<Student>();
            using (SqlConnection myConn = new SqlConnection(conn))
            {
                SqlDataAdapter cmdSelect = new SqlDataAdapter($"SELECT * FROM STUDENTS", myConn);
                DataTable dt = new DataTable();
                DataRow dr;

                myConn.Open();
                cmdSelect.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];
                        id = (string)dr[0];
                        name = (string)dr[1];
                        surname = (string)dr[2];
                        Student st = new Student()
                            .WithID((string)dr[0]).WithName((string)dr[1], (string)dr[2])
                            .WithEmail((string)dr["Email"])
                            .Build();
                        stList.Add(st);
                    }
                }
            }

            return stList;
        }

        public List<Modules> StudentModules(string stID)
        {
            List<Modules> stModules = new List<Modules>();
            using (SqlConnection myConn = new SqlConnection(conn))
            {
                SqlDataAdapter cmdSelect = new SqlDataAdapter($"SELECT M.MODULE_ID, M.MODULE_NAME, M.MODULE_CREDITS " +
                    $"FROM STUDENT_MODULES SM INNER JOIN STUDENTS S ON S.STUDENT_ID = SM.STUDENT_ID " +
                    $"INNER JOIN MODULES M ON M.MODULE_ID = SM.MODULE_ID " +
                    $"WHERE S.STUDENT_ID = '{stID}'", myConn);
                DataTable dt = new DataTable();
                DataRow dr;

                myConn.Open();
                cmdSelect.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];

                        Modules stMod = new Modules((string)dr[0], (string)dr[1], Convert.ToInt16(dr[2]));
                        stModules.Add(stMod);
                    }
                }
            }

            return stModules;
        }

        public Student ValidLogin(string id)
        {
            Student st = new Student();
            using (SqlConnection myConn = new SqlConnection(conn))
            {
                SqlCommand cmdSelect = new SqlCommand($"SELECT * FROM STUDENTS WHERE STUDENT_ID = '{id}'", myConn);
             
                myConn.Open();
                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        st.WithCredentials((string)reader["EMAIL"], (string)reader["PASSWORD"])
                            .Build();
                    }
                }
            }
            return st;
        }
    }
}
