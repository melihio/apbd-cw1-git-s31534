namespace apbd_cw1_git_s31534;

public class Student
{
    public String Name { get; set; }
    public int Grade { get; set; }

    public Student(String name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    static int GetAverage(List<Student> students)
    {
        int sum = 0;
        foreach (var student in students)
        {
            sum += student.Grade;
        }
        return sum / students.Count;
    }
}