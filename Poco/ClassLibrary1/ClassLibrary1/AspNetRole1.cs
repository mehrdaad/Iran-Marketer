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

    [Table("AspNetRoles", Schema = "dbo")]
    public class AspNetRole1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Id", Order = 1, TypeName = "nvarchar")]
        [Index(@"PK_dbo.AspNetRoles", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [MaxLength(128)]
        [StringLength(128)]
        [Key]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Index(@"RoleNameIndex", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public virtual System.Collections.Generic.ICollection<AspNetUser1> AspNetUser1 { get; set; }

        public AspNetRole1()
        {
            AspNetUser1 = new System.Collections.Generic.List<AspNetUser1>();
        }
    }

}
// </auto-generated>