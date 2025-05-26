namespace MvcMovie.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public double PointA { get; set; }  
        public double PointB { get; set; }  
        public double PointC { get; set; }  

    
        public double CalculateFinalScore()
        {
            return PointA * 0.6 + PointB * 0.3 + PointC * 0.1;
        }
    }
}