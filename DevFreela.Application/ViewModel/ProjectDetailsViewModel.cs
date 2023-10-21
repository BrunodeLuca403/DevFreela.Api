using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModel
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, string description, DateTime? startAt, DateTime? finishAt, decimal custo, string clientFullName, string freelancerFullName)
        {
            Id = id;
            Title = title;
            Description = description;
            StartAt = startAt;
            FinishAt = finishAt;
            Custo = custo;
            ClientFullName = ClientFullName;
            FreelancerFullName = FreelancerFullName;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? FinishAt { get; set; }
        public decimal Custo { get; set; }
        public string ClientFullName { get; set; }
        public string FreelancerFullName { get; set; }
    }
}
