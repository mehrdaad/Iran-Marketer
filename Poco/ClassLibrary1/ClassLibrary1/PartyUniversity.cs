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

    [Table("PartyUniversity", Schema = "dbo")]
    public class PartyUniversity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_PartyUniversity", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"DegreeLevel", Order = 2, TypeName = "int")]
        [Display(Name = "Degree level")]
        public int? DegreeLevel { get; set; }

        [Column(@"AcademicFieldId", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Academic field ID")]
        public int AcademicFieldId { get; set; }

        [Column(@"University", Order = 4, TypeName = "nvarchar")]
        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "University")]
        public string University { get; set; }

        [Column(@"CountryId", Order = 5, TypeName = "int")]
        [Display(Name = "Country ID")]
        public int? CountryId { get; set; }

        [Column(@"CityId", Order = 6, TypeName = "int")]
        [Display(Name = "City ID")]
        public int? CityId { get; set; }

        [Column(@"FromDate", Order = 7, TypeName = "int")]
        [Display(Name = "From date")]
        public int? FromDate { get; set; }

        [Column(@"ToDate", Order = 8, TypeName = "int")]
        [Display(Name = "To date")]
        public int? ToDate { get; set; }

        [Column(@"Average", Order = 9, TypeName = "decimal")]
        [Display(Name = "Average")]
        public decimal? Average { get; set; }

        [Column(@"PartyId", Order = 10, TypeName = "int")]
        [Required]
        [Display(Name = "Party ID")]
        public int PartyId { get; set; }

        [Column(@"Created", Order = 11, TypeName = "datetime")]
        [Display(Name = "Created")]
        public System.DateTime? Created { get; set; }

        [Column(@"CreatedBy", Order = 12, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; }

        [Column(@"Modified", Order = 13, TypeName = "datetime")]
        [Display(Name = "Modified")]
        public System.DateTime? Modified { get; set; }

        [Column(@"ModifiedBy", Order = 14, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Modified by")]
        public string ModifiedBy { get; set; }


        [ForeignKey("AcademicFieldId")] public virtual AcademicField AcademicField { get; set; }

        [ForeignKey("CityId")] public virtual Region City { get; set; }

        [ForeignKey("CountryId")] public virtual Region Country { get; set; }

        [ForeignKey("PartyId")] public virtual RetailParty RetailParty { get; set; }
    }

}
// </auto-generated>
