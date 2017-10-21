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

    public class AspNetUserMapper : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetUser>
    {
        public AspNetUserMapper()
            : this("sec")
        {
        }

        public AspNetUserMapper(string schema)
        {
            Property(x => x.Hometown).IsOptional();
            Property(x => x.Email).IsOptional();
            Property(x => x.PasswordHash).IsOptional();
            Property(x => x.SecurityStamp).IsOptional();
            Property(x => x.PhoneNumber).IsOptional();
            Property(x => x.LockoutEndDateUtc).IsOptional();
            Property(x => x.DisplayName).IsOptional();
            Property(x => x.CreateDate).IsOptional();
            Property(x => x.Status).IsOptional();
        }
    }

}
// </auto-generated>