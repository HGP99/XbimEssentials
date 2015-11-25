// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcCovering : IIfcCovering
	{
		Ifc4.Interfaces.IfcCoveringTypeEnum? IIfcCovering.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcCoveringTypeEnum.CEILING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.CEILING;
					
					case IfcCoveringTypeEnum.FLOORING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.FLOORING;
					
					case IfcCoveringTypeEnum.CLADDING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.CLADDING;
					
					case IfcCoveringTypeEnum.ROOFING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.ROOFING;
					
					case IfcCoveringTypeEnum.INSULATION:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.INSULATION;
					
					case IfcCoveringTypeEnum.MEMBRANE:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.MEMBRANE;
					
					case IfcCoveringTypeEnum.SLEEVING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.SLEEVING;
					
					case IfcCoveringTypeEnum.WRAPPING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.WRAPPING;
					
					case IfcCoveringTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.USERDEFINED;
					
					case IfcCoveringTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		IEnumerable<IIfcRelCoversSpaces> IIfcCovering.CoversSpaces 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelCoversSpaces>(e => e.RelatedCoverings != null &&  e.RelatedCoverings.Contains(this));
			} 
		}
		IEnumerable<IIfcRelCoversBldgElements> IIfcCovering.CoversElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelCoversBldgElements>(e => e.RelatedCoverings != null &&  e.RelatedCoverings.Contains(this));
			} 
		}
	//## Custom code
	//##
	}
}