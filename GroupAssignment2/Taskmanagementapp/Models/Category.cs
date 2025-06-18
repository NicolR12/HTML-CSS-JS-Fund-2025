using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taskmanagementapp.Models
{
    public class Category
    {
        public int categoryID
        {
            get; set;
        }
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
