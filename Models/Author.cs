﻿using System.ComponentModel.DataAnnotations;

namespace Nistor_Anamaria_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [Display(Name = "FullName")]

        public string FullName => FirstName + " " + LastName;


    }
    
}
