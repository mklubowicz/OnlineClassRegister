﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineClassRegister.Models
{
    public class Teacher
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Surname")]
        public string surname { get; set; }
        public virtual ICollection<Subject>? subjects { get; set; }
        [DisplayName("Student Class")]
        public int? classTutoringId { get; set; }
        [DisplayName("Class Tutoring")]
        public virtual StudentClass? classTutoring { get; set; }
        public Teacher()
        {
            subjects = new HashSet<Subject>();
        }
    }
}
