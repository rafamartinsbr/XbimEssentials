// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgElements;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWindowPanelProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWindowPanelProperties : IIfcPropertySetDefinition
	{
		IfcWindowPanelOperationEnum @OperationType { get; }
		IfcWindowPanelPositionEnum @PanelPosition { get; }
		IfcPositiveLengthMeasure? @FrameDepth { get; }
		IfcPositiveLengthMeasure? @FrameThickness { get; }
		IIfcShapeAspect @ShapeAspectStyle { get; }
		
	}
}

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IFCWINDOWPANELPROPERTIES", 96)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindowPanelProperties : IfcPropertySetDefinition, IInstantiableEntity, IIfcWindowPanelProperties, IEqualityComparer<@IfcWindowPanelProperties>, IEquatable<@IfcWindowPanelProperties>
	{
		#region IIfcWindowPanelProperties explicit implementation
		IfcWindowPanelOperationEnum IIfcWindowPanelProperties.OperationType { get { return @OperationType; } }	
		IfcWindowPanelPositionEnum IIfcWindowPanelProperties.PanelPosition { get { return @PanelPosition; } }	
		IfcPositiveLengthMeasure? IIfcWindowPanelProperties.FrameDepth { get { return @FrameDepth; } }	
		IfcPositiveLengthMeasure? IIfcWindowPanelProperties.FrameThickness { get { return @FrameThickness; } }	
		IIfcShapeAspect IIfcWindowPanelProperties.ShapeAspectStyle { get { return @ShapeAspectStyle; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowPanelProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcWindowPanelOperationEnum _operationType;
		private IfcWindowPanelPositionEnum _panelPosition;
		private IfcPositiveLengthMeasure? _frameDepth;
		private IfcPositiveLengthMeasure? _frameThickness;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcWindowPanelOperationEnum @OperationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _operationType;
				((IPersistEntity)this).Activate(false);
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcWindowPanelPositionEnum @PanelPosition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _panelPosition;
				((IPersistEntity)this).Activate(false);
				return _panelPosition;
			} 
			set
			{
				SetValue( v =>  _panelPosition = v, _panelPosition, value,  "PanelPosition");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @FrameDepth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _frameDepth;
				((IPersistEntity)this).Activate(false);
				return _frameDepth;
			} 
			set
			{
				SetValue( v =>  _frameDepth = v, _frameDepth, value,  "FrameDepth");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @FrameThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _frameThickness;
				((IPersistEntity)this).Activate(false);
				return _frameThickness;
			} 
			set
			{
				SetValue( v =>  _frameThickness = v, _frameThickness, value,  "FrameThickness");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcShapeAspect @ShapeAspectStyle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shapeAspectStyle;
				((IPersistEntity)this).Activate(false);
				return _shapeAspectStyle;
			} 
			set
			{
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
                    _operationType = (IfcWindowPanelOperationEnum) System.Enum.Parse(typeof (IfcWindowPanelOperationEnum), value.EnumVal, true);
					return;
				case 5: 
                    _panelPosition = (IfcWindowPanelPositionEnum) System.Enum.Parse(typeof (IfcWindowPanelPositionEnum), value.EnumVal, true);
					return;
				case 6: 
					_frameDepth = value.RealVal;
					return;
				case 7: 
					_frameThickness = value.RealVal;
					return;
				case 8: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWindowPanelProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcWindowPanelProperties
            var root = (@IfcWindowPanelProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcWindowPanelProperties left, @IfcWindowPanelProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcWindowPanelProperties left, @IfcWindowPanelProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcWindowPanelProperties x, @IfcWindowPanelProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcWindowPanelProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}