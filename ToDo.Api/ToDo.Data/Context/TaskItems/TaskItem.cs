using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Persistence.Context.WorkItems;

namespace ToDo.Persistence.Context.TaskItems
{
    public class TaskItem: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskItemId { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public int WorkItemId { get; set; }
        public WorkItem WorkItem { get; set; }
    }
}
