using Microsoft.CodeAnalysis.Options;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVCTechCrew.Models
{
    public class Dept
    {
        [Key]
        public int DeptID { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }
        public ICollection<Emp> emps { get; set; }  // navigation key   
    }

    public class Emp
    {
        [Key]
        public int EmpID { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public int DeptID { get; set; }  // foreign key
        public Dept dept { get; set; }  // navigation key
    }
}
