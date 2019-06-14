using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Enums.Generated.Shared
{
    public enum ProductStatus:int
	{
		[EnumMember]
		[Display(Name = "One")]
		One= 1,

		[EnumMember]
		[Display(Name = "Two")]
		Two= 2,

		[EnumMember]
		[Display(Name = "Three")]
		Three= 3
	}
}
