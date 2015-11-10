﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebMedicine.Models
{
    public class Activ
    {
        public int Id { get; set; }
        // номер кабинета
        [Required]
        [Display(Name = "Номер кабинета")]
        [MaxLength(50, ErrorMessage = "Превышена максимальная длина записи")]
        public string CabNumber { get; set; }

        // Внешний ключ
        // ID Отдела - обычное свойство
        [Required]
        [Display(Name = "Отдел")]
        public int? DepartmentId { get; set; }
        // Отдел - Навигационное свойство
        public Department Department { get; set; }
    }
}