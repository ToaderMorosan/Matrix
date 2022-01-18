using Matrix.DbContexts;
using Matrix.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix.Services
{
    public class SkillMatrixRepository : ISkillMatrixRepository, IDisposable
    {
        private readonly SkillMatrixContext _context;

        public SkillMatrixRepository(SkillMatrixContext context )
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddStudy(Guid employeeId, Study study)
        {
            if (employeeId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(employeeId));
            }

            if (study == null)
            {
                throw new ArgumentNullException(nameof(study));
            }
            // always set the AuthorId to the passed-in authorId
            study.EmployeeId = employeeId;
            _context.Studies.Add(study); 
        }         

        public void DeleteStudy(Study study)
        {
            _context.Studies.Remove(study);
        }
  
        public Study GetStudy(Guid employeeId, Guid studyId)
        {
            if (employeeId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(employeeId));
            }

            if (studyId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(studyId));
            }

            return _context.Studies
              .Where(c => c.EmployeeId == employeeId && c.Id == studyId).FirstOrDefault();
        }

        public IEnumerable<Study> GetStudies(Guid employeeId)
        {
            if (employeeId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(employeeId));
            }

            return _context.Studies
                        .Where(c => c.EmployeeId == employeeId)
                        .ToList();
        }

        public void UpdateStudy(Study study)
        {
            // no code in this implementation
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            // the repository fills the id (instead of using identity columns)
            employee.Id = Guid.NewGuid();

            foreach (var study in employee.Studies)
            {
                study.Id = Guid.NewGuid();
            }

            _context.Employees.Add(employee);
        }

        public bool EmployeeExists(Guid employeeId)
        {
            if (employeeId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(employeeId));
            }

            return _context.Employees.Any(a => a.Id == employeeId);
        }

        public void DeleteEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            _context.Employees.Remove(employee);
        }
        
        public Employee GetEmployee(Guid employeeId)
        {
            if (employeeId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(employeeId));
            }

            return _context.Employees.FirstOrDefault(a => a.Id == employeeId);
        }
        public IEnumerable<Study> GetAllStudies()
        {
            return _context.Studies.ToList<Study>();
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList<Employee>();
        }
         
        public IEnumerable<Employee> GetEmployees(IEnumerable<Guid> employeeIds)
        {
            if (employeeIds == null)
            {
                throw new ArgumentNullException(nameof(employeeIds));
            }

            return _context.Employees.Where(a => employeeIds.Contains(a.Id))
                .ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            // no code in this implementation
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
               // dispose resources when needed
            }
        }
    }
}
