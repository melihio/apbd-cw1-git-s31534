namespace apbd_cw1_git_s31534;

public class Class
{
    public Teacher Teacher;
    public List<Student> Students;

    public Class(Teacher teacher, List<Student> students)
    {
        Teacher = teacher;
        Students = students;
    }

    public int GetAverage()
    {
        int total = 0;
        foreach (var student in Students)
        {
            total += student.Grade;
        }
        return total / Students.Count;
    }

    public int GetMax()
    {
        return  Students.Max(student => student.Grade);
    }

    public int GetMin()
    {
        return  Students.Min(student => student.Grade);
    }
}