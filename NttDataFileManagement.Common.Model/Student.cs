using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttDataFileManagement.Common.Model
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; } 
        public DateTime Birthday { get; set; }
        public int Age { get; set; }    


    }
}
