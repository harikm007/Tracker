using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tracker.Model
    [Table("Project")]
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public int ProjectLocationId { get; set; }
        public string ProjectStatusId { get; set; }
        public string Description { get; set; }

    }
}
