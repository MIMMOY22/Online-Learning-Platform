using System;
﻿using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Gender { get; set; }
        public virtual ICollection<MyCourse> MyCourses { get; set; }
        public virtual ICollection<Submission> submissions { get; set; }
        public virtual ICollection<Enrollments> enrollments { get; set; }
        public Student()
        {
            MyCourses = new List<MyCourse>();
            submissions = new List<Submission>();
            enrollments = new List<Enrollments>();
        }
    }
}