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

    [Table("Consents", Schema = "sec")]
    public class Consent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Subject", Order = 1, TypeName = "nvarchar")]
        [Index(@"PK_dbo.Consents", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [MaxLength(200)]
        [StringLength(200)]
        [Key]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ClientId", Order = 2, TypeName = "nvarchar")]
        [Index(@"PK_dbo.Consents", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [MaxLength(200)]
        [StringLength(200)]
        [Key]
        [Display(Name = "Client ID")]
        public string ClientId { get; set; }

        [Column(@"Scopes", Order = 3, TypeName = "nvarchar")]
        [Required]
        [MaxLength(2000)]
        [StringLength(2000)]
        [Display(Name = "Scopes")]
        public string Scopes { get; set; }
    }

}
// </auto-generated>
