using System.ComponentModel.DataAnnotations;

namespace BusinessManager.Classes
{
    public enum Level
    {
        Low = 0,
        Medium = 1,
        High = 2,
        Critical = 3
    }
    public abstract class Common
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public Level Importance { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deadline { get; set; }
        public List<Guid>? EmployeeIdsAssigned { get; set; }
    }
    public class Project : Common
    {
        [Key]
        public Guid SupervisorId { get; set; }
        public List<Task>? Tasks { get; set; }

        public Project(Guid supervisorId, List<Guid>? employeeIdsAssigned)
        {
            Id = Guid.NewGuid();
            SupervisorId = supervisorId;
            EmployeeIdsAssigned = employeeIdsAssigned;
        }
    }
    public class Task : Common
    {
        [Key]
        public string? Type { get; set; }
        public Task(string? type, List<Guid>? employeeIdsAssigned)
        {
            Id = Guid.NewGuid();
            Type = type;
            EmployeeIdsAssigned = employeeIdsAssigned;
        }
    }
}
