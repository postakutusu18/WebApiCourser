using Contracts;
using Service.Contracts;

namespace Service;

public class ServiceManager : IServiceManager
{
    private readonly IProjectService _projectService;
    public ServiceManager(IRepositoryManager repository,ILoggerManager logger)
    {
        _projectService=new ProjectService(repository, logger);
    }

    public IProjectService ProjectService => _projectService;
}
