using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UserAuthenticationAPI.Models
{
    public class UserRole
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        [Required(ErrorMessage = "Role name must be provided.")]
        public string RoleName { get; set; }


        [Column(TypeName = "varchar(MAX)")]
        [Required(ErrorMessage = "Role type must be provided.")]
        public string RoleType { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        [Required(ErrorMessage = "Role priority must be provided.")]
        public string RolePriority { get; set; }

        [ForeignKey("User")]
        [Required(ErrorMessage = "CreatorId must be provided.")]
        public Guid CreatorId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        public DateTime Updated { get; set; }
    }
}