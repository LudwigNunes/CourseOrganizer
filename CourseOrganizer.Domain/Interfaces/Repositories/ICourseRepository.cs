using System.Collections.Generic;
using CourseOrganizer.Domain.Entities;

namespace CourseOrganizer.Domain.Interfaces.Repositories
{
    public interface ICourseRepository : IRepositoryBase<Course>
    {
        Course GetByCode(string code);

        IEnumerable<Course> GetAllByDepartmentCode(string departamentCode);
    }

}
