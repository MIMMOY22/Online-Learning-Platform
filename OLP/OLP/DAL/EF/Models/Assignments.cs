using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Assignments
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime deadline { get; set; }
        [ForeignKey("teacher")]
        public int tid { get; set; }
        [ForeignKey("course")]
        public int cid { get; set; }
        public virtual Teacher teacher { get; set; }
        public virtual Course course { get; set; }
        public virtual ICollection<Submission> submissions { get; set; }
        public Assignments()
        {
            submissions = new List<Submission>();
        }
    }
}