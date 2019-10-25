using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tracker.Model
{ 
    [Table("Project")]
    public class Project
    {
        [Required(ErrorMessage ="ProjectID is Required.")]
        [Key]
        public int ProjectID { get; set; }
        [Required(ErrorMessage ="Project name is required.")]
        public string ProjectName { get; set; }
        public int ProjectLocationId { get; set; }
        [Required(ErrorMessage ="Project status is required.")]
        public string ProjectStatusId { get; set; }
        public string Description { get; set; }

    }
}
