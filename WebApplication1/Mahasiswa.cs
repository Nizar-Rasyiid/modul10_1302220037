using System.Numerics;

namespace WebApplication1
{
    public class Mahasiswa
    {
        public string Name { get; set; }
        public string NIM { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa(string Name,string NIM,List<string> Course,int Year) {
            this.Name = Name;
            this.NIM = NIM; 
            this.Course = Course;
            this.Year = Year;
        }
    }
}
