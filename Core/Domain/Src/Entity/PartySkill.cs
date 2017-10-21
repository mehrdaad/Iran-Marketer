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

    // PartySkills
    [Table("PartySkills", Schema = "dbo")]
    public class PartySkill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        //[Index(@"PK_PartySkills", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; } // Id (Primary key)

        [Column(@"PartyId", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Party ID")]
        public int PartyId { get; set; } // PartyId

        [Column(@"SkillId", Order = 3, TypeName = "int")]
        [Display(Name = "Skill ID")]
        public int? SkillId { get; set; } // SkillId

        [Column(@"SkillLevel", Order = 4, TypeName = "int")]
        [Display(Name = "Skill level")]
        public int? SkillLevel { get; set; } // SkillLevel

        // Foreign keys

        /// <summary>
        /// Parent RetailParty pointed by [PartySkills].([PartyId]) (FK_PartySkills_RetailParty)
        /// </summary>
        [ForeignKey("PartyId")] public virtual RetailParty RetailParty { get; set; } // FK_PartySkills_RetailParty

        /// <summary>
        /// Parent Skill pointed by [PartySkills].([SkillId]) (FK_PartySkills_Skills)
        /// </summary>
        [ForeignKey("SkillId")] public virtual Skill Skill { get; set; } // FK_PartySkills_Skills
    }

}
// </auto-generated>
