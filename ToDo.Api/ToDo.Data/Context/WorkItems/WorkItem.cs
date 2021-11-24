using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Persistence.Context.TaskItems;
using ToDo.Persistence.Context.Users;

namespace ToDo.Persistence.Context.WorkItems
{
    public class WorkItem:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkItemId { get; set; }

        public string Title { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public IList<TaskItem> TaskItems { get; set; }

    }
}
