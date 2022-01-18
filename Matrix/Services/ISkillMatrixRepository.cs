
using Matrix.Entities;

namespace Matrix.Services
{
    public interface ISkillMatrixRepository
    {    
        IEnumerable<Study> GetStudies(Guid Id);
        Study GetStudy(Guid employeeId, Guid studyId);
        void AddStudy(Guid employeeId, Study study);
        void UpdateStudy(Study study);
        void DeleteStudy(Study study);
        IEnumerable<Study> GetAllStudies();
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(Guid employeeId);
        IEnumerable<Employee> GetEmployees(IEnumerable<Guid> employeesIds);
        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        bool EmployeeExists(Guid employeeId);
        bool Save();
    }
}
