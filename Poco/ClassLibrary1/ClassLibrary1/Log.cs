// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IranMarketer.Domain.Entity
{

    [Table("Logs", Schema = "dbo")]
    public class Log
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_Logs", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"EventDateTime", Order = 2, TypeName = "datetime")]
        [Required]
        [Display(Name = "Event date time")]
        public System.DateTime EventDateTime { get; set; }

        [Column(@"EventLevel", Order = 3, TypeName = "nvarchar")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Event level")]
        public string EventLevel { get; set; }

        [Column(@"UserName", Order = 4, TypeName = "nvarchar")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Column(@"MachineName", Order = 5, TypeName = "nvarchar")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Machine name")]
        public string MachineName { get; set; }

        [Column(@"EventMessage", Order = 6, TypeName = "nvarchar(max)")]
        [Required]
        [Display(Name = "Event message")]
        public string EventMessage { get; set; }

        [Column(@"ErrorSource", Order = 7, TypeName = "nvarchar(max)")]
        [Display(Name = "Error source")]
        public string ErrorSource { get; set; }

        [Column(@"ErrorClass", Order = 8, TypeName = "nvarchar")]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Error class")]
        public string ErrorClass { get; set; }

        [Column(@"ErrorMethod", Order = 9, TypeName = "nvarchar(max)")]
        [Display(Name = "Error method")]
        public string ErrorMethod { get; set; }

        [Column(@"InnerErrorMessage", Order = 10, TypeName = "nvarchar(max)")]
        [Display(Name = "Inner error message")]
        public string InnerErrorMessage { get; set; }
    }

}
// </auto-generated>
