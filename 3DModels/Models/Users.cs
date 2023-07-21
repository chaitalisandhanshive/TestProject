using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DModels.Models
{
    public partial class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }
        public string Username { get; set; } = null!;

        public string UserEmail { get; set; } = null!;
        public string UserPassword { get; set; } = null!;

        public string City { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Phonenumber { get; set; }


    }
}