namespace CollegeApp1.Models
{
    public class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>()
        {
            new Student
             {
                Id = 1,
                StudentName = "Afifa",
                Email = "afifa@gmail.com",
                Address = "Bengaluru"
            },
            new Student
            {
                Id = 2,
                StudentName = "Akshatha",
                Email = "akshatha@gmail.com",
                Address = "Bengaluru"
            },
            new Student
            {
                Id = 3,
                StudentName = "Jayanth",
                Email = "jayanth@gmail.com",
                Address = "Bengaluru"
            },
            new Student
            {
                Id = 4,
                StudentName = "Meghana",
                Email = "meghana@gmail.com",
                Address = "Bengaluru"
            },
             new Student
            {
                Id = 5,
                StudentName = "Spandana",
                Email = "spandana@gmail.com",
                Address = "Bengaluru"
            }
        }; 
    }
}
