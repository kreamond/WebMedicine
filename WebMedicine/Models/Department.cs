﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebMedicine.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название отдела")]
        [MaxLength(50, ErrorMessage = "Превышена максимальная длина записи")]
        public string Name { get; set; }
    }
}