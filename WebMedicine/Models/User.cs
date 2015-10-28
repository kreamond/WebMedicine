using System;
using System.ComponentModel.DataAnnotations;

namespace WebMedicine.Models
{
    public class User
    {
        //ID
        public int Id { get; set; }
        
        //Фамилия Имя Отчество
        [Required]
        [Display(Name = "Фамилия Имя Отчество")]
        [MaxLength(50, ErrorMessage = "Превышена максимальная длина записи")]
        public string Name { get; set; }
        
        //Логин
        [Required]
        [Display(Name ="Логин")]
        [MaxLength(50, ErrorMessage ="Превышена максимальная длина записи")]
        public string Login { get; set; }

        //Пароль
        [Required]
        [Display(Name ="Пароль")]
        [MaxLength(50, ErrorMessage ="Превышена максимальная длина записи")]
        public string Password { get; set; }

        //Дожность
        [Display(Name ="Должность")]
        [MaxLength(50, ErrorMessage ="Превышена максимальная длина записи")]
        public string Position { get; set; }

        //Статус
        [Required]
        [Display(Name ="Статус")]
        public int RoleId { get; set; }
        public Role Role { get; set; }


    }
}