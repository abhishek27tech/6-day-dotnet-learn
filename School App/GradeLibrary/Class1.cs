namespace GradeLibrary
{
    public class GradeHelper
    {
        public static string GetGrade(double avg)
        {
            if (avg >= 90) return "A+";
            if (avg >= 75) return "A";
            if (avg >= 60) return "B";
            if (avg >= 45) return "C";
            return "Fail";
        }
    }
}