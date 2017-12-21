using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Entities
{
    public class Parent_Student_Link
    {
        public int PSLinkID { get; set; }
        [ForeignKey("Parent")]
        public int ParentID { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
    }
}
