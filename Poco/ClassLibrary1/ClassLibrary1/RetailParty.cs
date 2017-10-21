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

    [Table("RetailParty", Schema = "dbo")]
    public class RetailParty
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_Party", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column(@"EnName", Order = 3, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "En name")]
        public string EnName { get; set; }

        [Column(@"FirstName", Order = 4, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Column(@"EnFirstName", Order = 5, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "En first name")]
        public string EnFirstName { get; set; }

        [Column(@"LastName", Order = 6, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Column(@"EnLastName", Order = 7, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "En last name")]
        public string EnLastName { get; set; }

        [Column(@"FatherName", Order = 8, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Father name")]
        public string FatherName { get; set; }

        [Column(@"EnFatherName", Order = 9, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "En father name")]
        public string EnFatherName { get; set; }

        [Column(@"NationalId", Order = 10, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "National ID")]
        public string NationalId { get; set; }

        [Column(@"NationalityPlaceId", Order = 11, TypeName = "int")]
        [Display(Name = "Nationality place ID")]
        public int? NationalityPlaceId { get; set; }

        [Column(@"CityId", Order = 12, TypeName = "int")]
        [Display(Name = "City ID")]
        public int? CityId { get; set; }

        [Column(@"FullName", Order = 13, TypeName = "nvarchar")]
        [MaxLength(220)]
        [StringLength(220)]
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Column(@"Address", Order = 14, TypeName = "nvarchar(max)")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Column(@"PhoneNumber", Order = 15, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Column(@"MobileNumber", Order = 16, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Phone]
        [Display(Name = "Mobile number")]
        public string MobileNumber { get; set; }

        [Column(@"BirthDate", Order = 17, TypeName = "date")]
        [Display(Name = "Birth date")]
        public System.DateTime? BirthDate { get; set; }

        [Column(@"BirthPlace", Order = 18, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Birth place")]
        public string BirthPlace { get; set; }

        [Column(@"Gender", Order = 19, TypeName = "int")]
        [Display(Name = "Gender")]
        public int? Gender { get; set; }

        [Column(@"MilitaryServiceStatus", Order = 20, TypeName = "int")]
        [Display(Name = "Military service status")]
        public int? MilitaryServiceStatus { get; set; }

        [Column(@"MaritalStatus", Order = 21, TypeName = "int")]
        [Display(Name = "Marital status")]
        public int? MaritalStatus { get; set; }

        [Column(@"UserId", Order = 22, TypeName = "nvarchar")]
        [Required]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "User ID")]
        public string UserId { get; set; }

        [Column(@"UserName", Order = 23, TypeName = "nvarchar")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Column(@"ValidFrom", Order = 24, TypeName = "date")]
        [Display(Name = "Valid from")]
        public System.DateTime? ValidFrom { get; set; }

        [Column(@"ValidUntil", Order = 25, TypeName = "date")]
        [Display(Name = "Valid until")]
        public System.DateTime? ValidUntil { get; set; }

        [Column(@"Modified", Order = 26, TypeName = "datetime")]
        [Display(Name = "Modified")]
        public System.DateTime? Modified { get; set; }

        [Column(@"Created", Order = 27, TypeName = "datetime")]
        [Display(Name = "Created")]
        public System.DateTime? Created { get; set; }

        [Column(@"ModifiedBy", Order = 28, TypeName = "nvarchar")]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Modified by")]
        public string ModifiedBy { get; set; }

        [Column(@"CreatedBy", Order = 29, TypeName = "nvarchar")]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; }

        public virtual System.Collections.Generic.ICollection<Document> Documents { get; set; }
        public virtual System.Collections.Generic.ICollection<JobPrefer> JobPrefers { get; set; }
        public virtual System.Collections.Generic.ICollection<PartyUniversity> PartyUniversities { get; set; }
        public virtual System.Collections.Generic.ICollection<WorkExperience> WorkExperiences { get; set; }


        [ForeignKey("CityId")] public virtual Region City { get; set; }

        [ForeignKey("NationalityPlaceId")] public virtual Region NationalityPlace { get; set; }

        public RetailParty()
        {
            Documents = new System.Collections.Generic.List<Document>();
            JobPrefers = new System.Collections.Generic.List<JobPrefer>();
            PartyUniversities = new System.Collections.Generic.List<PartyUniversity>();
            WorkExperiences = new System.Collections.Generic.List<WorkExperience>();
        }
    }

}
// </auto-generated>
