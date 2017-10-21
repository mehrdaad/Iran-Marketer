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
using Pikad.Framework.Repository;

namespace IranMarketer.Domain.Entity
{

    // Skills
    [Table("Skills", Schema = "dbo")]
    public class Skill : Entity<int>
    {
       

        [Column(@"TitleFa", Order = 2, TypeName = "nvarchar")]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Title fa")]
        public string TitleFa { get; set; } // TitleFa (length: 500)

        [Column(@"TitleEn", Order = 3, TypeName = "nvarchar")]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Title en")]
        public string TitleEn { get; set; } // TitleEn (length: 500)

        [Column(@"SkillType", Order = 4, TypeName = "int")]
        [Display(Name = "Skill type")]
        public int? SkillType { get; set; } // SkillType

        // Reverse navigation

        /// <summary>
        /// Child PartySkills where [PartySkills].[SkillId] point to this entity (FK_PartySkills_Skills)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PartySkill> PartySkills { get; set; } // PartySkills.FK_PartySkills_Skills

        public Skill()
        {
            PartySkills = new System.Collections.Generic.List<PartySkill>();
        }
    }

}
// </auto-generated>
