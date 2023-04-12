using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MVC_Web_App.Models;

namespace MVC_Web_App.Controllers
{

    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            return View();
        }

        public List<StudentModel> students = new List<StudentModel>();
        public string info = "Hello student info";
        public IActionResult Index()
        {

            string connectionString = "Data Source=5CG9410FHM;Initial Catalog=StudentDetails; Integrated Security = True; Encrypt=False";

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM dbo.StudentInfo";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                StudentModel s1 = new StudentModel();


                s1.studentId = reader.GetInt32((0));
                s1.studentName =  "" + reader[1];
                s1.studentDept = "" +  reader[2];

                students.Add(s1);
            }

            ViewBag.students = students;
            ViewBag.info = info;


            return View();
        }
    }
}
