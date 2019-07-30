using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmExample
{
    public class Employee : RealmObject
    {
        [PrimaryKey]
        public int EmpId { get; set; }
        public string EmpName
        { get; set; }
        public string Company
        { get; set; }
        public string Designation
        { get; set; }
        public string Department
        { get; set; }
        public string Qualification
        { get; set; }
    }
}
