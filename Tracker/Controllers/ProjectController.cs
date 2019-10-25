using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Tracker.Model;

namespace Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        readonly TrackerContext trackerContext;
        [HttpGet]
        public ActionResult<IEnumerable<Project>> Get()
        {
            return trackerContext.Projects.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Project> Get(int projectId)
        {
            Project projectFilter = trackerContext.Projects.SingleOrDefault(pr => pr.ProjectID == projectId);

            if (projectFilter == null)
            {
                return NotFound("Project not found");
            }
            else
            {
                return projectFilter;
            }
        }


    }
}