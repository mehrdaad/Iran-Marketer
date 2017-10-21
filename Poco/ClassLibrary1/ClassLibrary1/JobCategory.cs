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

    [Table("JobCategories", Schema = "dbo")]
    public class JobCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_JobCategories", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"TitleFa", Order = 2, TypeName = "nvarchar")]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Title fa")]
        public string TitleFa { get; set; }

        [Column(@"TitleEn", Order = 3, TypeName = "nvarchar")]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Title en")]
        public string TitleEn { get; set; }

        [Column(@"Created", Order = 4, TypeName = "datetime")]
        [Display(Name = "Created")]
        public System.DateTime? Created { get; set; }

        [Column(@"CreatedBy", Order = 5, TypeName = "nvarchar")]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; }

        [Column(@"Modified", Order = 6, TypeName = "datetime")]
        [Display(Name = "Modified")]
        public System.DateTime? Modified { get; set; }

        [Column(@"ModifiedBy", Order = 7, TypeName = "nvarchar")]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Modified by")]
        public string ModifiedBy { get; set; }

        public virtual System.Collections.Generic.ICollection<JobPrefer> JobPrefers { get; set; }
        public virtual System.Collections.Generic.ICollection<WorkExperience> WorkExperiences { get; set; }

        public JobCategory()
        {
            WorkExperiences = new System.Collections.Generic.List<WorkExperience>();
            JobPrefers = new System.Collections.Generic.List<JobPrefer>();
        }
    }

}
// </auto-generated>