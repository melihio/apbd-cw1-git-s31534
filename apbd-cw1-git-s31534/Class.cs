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
        int sum = 0;
        foreach (var student in Students)
        {
            sum += student.Grade;
        }
        return sum / Students.Count;
    }
}