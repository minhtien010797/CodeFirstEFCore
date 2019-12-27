using CodeFirstEFCore.Context;

namespace CodeFirstEFCore.Manager
{
    public class CourseManager : ICourseManager
    {
        private readonly SchoolContext _schoolContext;

        public CourseManager(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

    }
}