using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuthenticationAPI.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        
        [Column(TypeName = "varchar(MAX)")]
        [Required(ErrorMessage = "Username must be provided.")]
        [StringLength(20, ErrorMessage = "Username can't be longer than 20 characters.")]
        public string Username { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        [Required(ErrorMessage = "Password must be provided.")]
        [StringLength(16, ErrorMessage = "Password can't be longer than 16 characters.")]
        [MinLength(8, ErrorMessage = "Password can't be shorter than 8 characters")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        [Required(ErrorMessage = "Email address must be provided.")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        [Required(ErrorMessage = "Firstname must be provided.")]
        [StringLength(20, ErrorMessage = "Firstname can't be longer than 20 characters.")]
        public string Firstname { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        [Required(ErrorMessage = "Lastname must be provided.")]
        [StringLength(20, ErrorMessage = "Lastname can't be longer than 20 characters.")]
        public string Lastname { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        public DateTime Updated { get; set; }
    }
}