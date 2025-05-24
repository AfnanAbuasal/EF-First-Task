using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task1.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
    }
}
