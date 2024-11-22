using System.Reflection.Metadata.Ecma335;

public class SubjectGrade
{
    public string Subject { get; set; }
    public int CreditUnit { get; set; }
    public int GradePoint { get; set; }
}

public class GPAInputModel
{
    public List<SubjectGrade> Subjects { get; set; } = new List<SubjectGrade>();
}