using CourseOrganizer.Domain.Entities;

namespace CourseOrganizer.Domain.Interfaces.Repositories
{
    public interface IDepartmentRepository : IRepositoryBase<Department>
    {
        Department GetByCode(string Code);
    }
}
