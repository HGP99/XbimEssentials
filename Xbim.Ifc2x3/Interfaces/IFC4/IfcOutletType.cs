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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcOutletType : IIfcOutletType
	{
		Ifc4.Interfaces.IfcOutletTypeEnum IIfcOutletType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcOutletTypeEnum.AUDIOVISUALOUTLET:
						return Ifc4.Interfaces.IfcOutletTypeEnum.AUDIOVISUALOUTLET;
					
					case IfcOutletTypeEnum.COMMUNICATIONSOUTLET:
						return Ifc4.Interfaces.IfcOutletTypeEnum.COMMUNICATIONSOUTLET;
					
					case IfcOutletTypeEnum.POWEROUTLET:
						return Ifc4.Interfaces.IfcOutletTypeEnum.POWEROUTLET;
					
					case IfcOutletTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcOutletTypeEnum.USERDEFINED;
					
					case IfcOutletTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcOutletTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}