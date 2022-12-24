using System.ComponentModel.DataAnnotations;

namespace BusinessManager.Classes
{
    public abstract class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ManagerId { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? Department { get; set; }
        public string? PhoneNo { get; set; }
        public string? Address { get; set; }
        public List<string>? BenefitsPackage { get; set; }
        public int Salary { get; set; }
    }
    public class ResearchEmployee : Employee
    {
        [Key]
        public string? CurrentTopic { get; set; }
        public string? ResearchField { get; set; }
        public int FinishedProjectsNo { get; set; }

        public ResearchEmployee(string? currentTopic, string? researchField, int finishedProjectsNo)
        {
            Id = Guid.NewGuid();
            CurrentTopic = currentTopic;
            ResearchField = researchField;
            FinishedProjectsNo = finishedProjectsNo;
        }
    }
    public class MarketingEmployee : Employee
    {
        [Key]
        public string? CurrentTopic { get; set; }
        public List<string>? Clients { get; set; }
        public int ConnectedClientsNo { get; set; }

        public MarketingEmployee(string? currentTopic, List<string>? clients, int connectedClientsNo)
        {
            Id = Guid.NewGuid();
            CurrentTopic = currentTopic;
            Clients = clients;
            ConnectedClientsNo = connectedClientsNo;
        }
    }
    public class HumanResourcesEmployee : Employee
    {
        [Key]
        public List<Guid>? HiredEmployeesIds { get; set; }
        public List<string>? TrainingsBought { get; set; }

        public HumanResourcesEmployee(List<Guid>? hiredEmployeesIds, List<string>? trainingsBought)
        {
            Id = Guid.NewGuid();
            HiredEmployeesIds = hiredEmployeesIds;
            TrainingsBought = trainingsBought;
        }
    }
    public class FinanceEmployee : Employee
    {
        [Key]
        public int MoneySaved { get; set; }

        public FinanceEmployee(int moneySaved)
        {
            Id = Guid.NewGuid();
            MoneySaved = moneySaved;
        }
    }
    public class OperationsEmployee : Employee
    {
        [Key]
        public List<string>? ResponsibleForParts { get; set; }
        public int MoneyGenerated { get; set; }

        public OperationsEmployee(List<string>? responsibleForParts, int moneyGenerated)
        {
            Id = Guid.NewGuid();
            ResponsibleForParts = responsibleForParts;
            MoneyGenerated = moneyGenerated;
        }
    }
    public class InformationTechnologyEmployee : Employee
    {
        [Key]
        public List<string>? ResponsibleForComputers { get; set; }
        public int ComputersFixed { get; set; }

        public InformationTechnologyEmployee(List<string>? responsibleForComputers, int computersFixed)
        {
            Id = Guid.NewGuid();
            ResponsibleForComputers = responsibleForComputers;
            ComputersFixed = computersFixed;
        }
    }
}
