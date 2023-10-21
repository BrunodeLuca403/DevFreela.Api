using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entitys
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idCliente, int idFreelancer, decimal totalConst)
        {
            Title = title;
            Description = description;
            IdCliente = idCliente;
            IdFreelancer = idFreelancer;
            TotalConst = totalConst;
            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = new List<ProjectComment>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdCliente { get; private set; }
        public User Client { get; set; }
        public int IdFreelancer { get; private set; }
        public  User Freelancer { get; set; }
        public decimal TotalConst { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime StarteAt { get; private set; }
        public DateTime FinishAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }

        public void Cancel()
        {
            if(Status == ProjectStatusEnum.InProgress || Status == ProjectStatusEnum.InProgress)
            Status = ProjectStatusEnum.Cancelled;
        }
        public void Start()
        {
            if(Status == ProjectStatusEnum.Created)
            {
                Status = ProjectStatusEnum.InProgress;
                StarteAt = DateTime.Now;
            }
        }
        public void Finish()
        {
            if(Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Finished;
                FinishAt = DateTime.Now;    
            }
        }

        public void Update(string title, string description, decimal totalconst)
        {
            Title = title;
            Description = description;
            TotalConst = totalconst;
        }
    }
}
