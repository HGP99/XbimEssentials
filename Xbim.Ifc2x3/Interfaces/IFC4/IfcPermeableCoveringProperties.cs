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
namespace Xbim.Ifc2x3.ArchitectureDomain
{
	public partial class @IfcPermeableCoveringProperties : IIfcPermeableCoveringProperties
	{
		Ifc4.Interfaces.IfcPermeableCoveringOperationEnum IIfcPermeableCoveringProperties.OperationType 
		{ 
			get
			{
				switch (OperationType)
				{
					case IfcPermeableCoveringOperationEnum.GRILL:
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.GRILL;
					
					case IfcPermeableCoveringOperationEnum.LOUVER:
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.LOUVER;
					
					case IfcPermeableCoveringOperationEnum.SCREEN:
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.SCREEN;
					
					case IfcPermeableCoveringOperationEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.USERDEFINED;
					
					case IfcPermeableCoveringOperationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPermeableCoveringOperationEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.Interfaces.IfcWindowPanelPositionEnum IIfcPermeableCoveringProperties.PanelPosition 
		{ 
			get
			{
				switch (PanelPosition)
				{
					case SharedBldgElements.IfcWindowPanelPositionEnum.LEFT:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.LEFT;
					
					case SharedBldgElements.IfcWindowPanelPositionEnum.MIDDLE:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.MIDDLE;
					
					case SharedBldgElements.IfcWindowPanelPositionEnum.RIGHT:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.RIGHT;
					
					case SharedBldgElements.IfcWindowPanelPositionEnum.BOTTOM:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.BOTTOM;
					
					case SharedBldgElements.IfcWindowPanelPositionEnum.TOP:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.TOP;
					
					case SharedBldgElements.IfcWindowPanelPositionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWindowPanelPositionEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcPermeableCoveringProperties.FrameDepth 
		{ 
			get
			{
				if (!FrameDepth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FrameDepth.Value);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcPermeableCoveringProperties.FrameThickness 
		{ 
			get
			{
				if (!FrameThickness.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FrameThickness.Value);
			} 
		}
		IIfcShapeAspect IIfcPermeableCoveringProperties.ShapeAspectStyle 
		{ 
			get
			{
				return ShapeAspectStyle;
			} 
		}
	//## Custom code
	//##
	}
}