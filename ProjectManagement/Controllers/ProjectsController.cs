using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace ProjectManagement.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private List<Project> _projectList;
        //private ILogger<ProjectsController> _logger; //base logger
        private ILoggerManager _logger;
        //private RepositoryContext _context;// doğrudan veritabanına bağlantı
        private IRepositoryManager _repository;
        public ProjectsController(ILoggerManager logger,
            /*RepositoryContext context*/
            /*ILogger<ProjectsController> logger*/
            IRepositoryManager repository
            
            )
        {
           // _context = context;
           _repository = repository;
            _logger = logger; //DI
            _projectList = new List<Project>
            {
                new Project{ Id = Guid.NewGuid(), Name ="Project 1"},
                new Project{ Id = Guid.NewGuid(), Name ="Project 2"},
                new Project{ Id = Guid.NewGuid(), Name ="Project 3"},
            };
        }

       

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //var list=_context.Projects.ToList();
                var list = _repository.Project.GetAllProjects(false);
                //int c = 10;
                //int a = 0;
                //int d = c / a;
                // _logger.LogInformation("Projects.Get() has been run.");
                _logger.LogInfo("Projects.Get() has been run.");
                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError("Projects.Get() has been crashed! : "+ex.Message);
                throw;
            }
         
        }
    }
}
