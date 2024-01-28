using System.ComponentModel.DataAnnotations;

namespace VpAssignment2.Models
{
    public class StudentModel
    {
        [Key, Required]
        public int Roll_num { get; set; }
        public string Name { get; set; }

        public string Department { get; set; }
        public float CGPA { get; set; }

        public StudentModel() { 
        
            Roll_num = 0;
            Name = string.Empty;
            Department = string.Empty;
            CGPA = 0;
        }
    }
}
