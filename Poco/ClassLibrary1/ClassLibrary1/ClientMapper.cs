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

    public class ClientMapper : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Client>
    {
        public ClientMapper()
            : this("sec")
        {
        }

        public ClientMapper(string schema)
        {
            Property(x => x.ClientUri).IsOptional();
            Property(x => x.LogoUri).IsOptional();
            Property(x => x.LogoutUri).IsOptional();
        }
    }

}
// </auto-generated>
