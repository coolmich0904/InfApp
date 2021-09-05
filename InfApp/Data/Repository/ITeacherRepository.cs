using InfApp.Models;
using System.Collections.Generic;

namespace InfApp.Data.Repository
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
    }
}