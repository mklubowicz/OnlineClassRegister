﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClassRegister.Models
{
    public class Subject
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [Display(Name = "Classes")]
        public virtual ICollection<StudentClass>? classes { get; set; }
        [Display(Name = "Teachers")]
        public virtual ICollection<Teacher>? teachers { get; set; }

    }
}
