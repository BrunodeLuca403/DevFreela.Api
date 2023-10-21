using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModel
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int Id, string title, DateTime createAt)
        {
            Title = title;
            CreateAt = createAt;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime  CreateAt { get; set; }
    }
}
