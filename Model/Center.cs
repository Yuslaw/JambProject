using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JambRegProject.Model
{
    public class Center
    {
        public int id {get; set;}
        public string CenterName {get; set;}
        public int AvailableSpace {get; set;}
        public List<Student> Students { get; set; } = new List<Student>();
    }
}