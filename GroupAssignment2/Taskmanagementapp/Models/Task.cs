using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taskmanagementapp.Models
{
    public class Task
    {
        public int Taskid {  get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        [DataType(DataType.Date)]
        public DateTime TaskDueDate { get; set; }
        public string TaskStatus {  get; set; }
        public int categoryID {  get; set; }
        [ForeignKey("categoryID")]
        public Category Category { get; set; }
    }
}
