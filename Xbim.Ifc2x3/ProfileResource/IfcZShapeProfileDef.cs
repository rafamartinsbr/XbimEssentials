// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfileResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcZShapeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcZShapeProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @Depth { get; }
		IfcPositiveLengthMeasure @FlangeWidth { get; }
		IfcPositiveLengthMeasure @WebThickness { get; }
		IfcPositiveLengthMeasure @FlangeThickness { get; }
		IfcPositiveLengthMeasure? @FilletRadius { get; }
		IfcPositiveLengthMeasure? @EdgeRadius { get; }
		
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IFCZSHAPEPROFILEDEF", 528)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcZShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcZShapeProfileDef, IEqualityComparer<@IfcZShapeProfileDef>, IEquatable<@IfcZShapeProfileDef>
	{
		#region IIfcZShapeProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcZShapeProfileDef.Depth { get { return @Depth; } }	
		IfcPositiveLengthMeasure IIfcZShapeProfileDef.FlangeWidth { get { return @FlangeWidth; } }	
		IfcPositiveLengthMeasure IIfcZShapeProfileDef.WebThickness { get { return @WebThickness; } }	
		IfcPositiveLengthMeasure IIfcZShapeProfileDef.FlangeThickness { get { return @FlangeThickness; } }	
		IfcPositiveLengthMeasure? IIfcZShapeProfileDef.FilletRadius { get { return @FilletRadius; } }	
		IfcPositiveLengthMeasure? IIfcZShapeProfileDef.EdgeRadius { get { return @EdgeRadius; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcZShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure _flangeWidth;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _flangeThickness;
		private IfcPositiveLengthMeasure? _filletRadius;
		private IfcPositiveLengthMeasure? _edgeRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _depth;
				((IPersistEntity)this).Activate(false);
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @FlangeWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flangeWidth;
				((IPersistEntity)this).Activate(false);
				return _flangeWidth;
			} 
			set
			{
				SetValue( v =>  _flangeWidth = v, _flangeWidth, value,  "FlangeWidth");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _webThickness;
				((IPersistEntity)this).Activate(false);
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @FlangeThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flangeThickness;
				((IPersistEntity)this).Activate(false);
				return _flangeThickness;
			} 
			set
			{
				SetValue( v =>  _flangeThickness = v, _flangeThickness, value,  "FlangeThickness");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @FilletRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _filletRadius;
				((IPersistEntity)this).Activate(false);
				return _filletRadius;
			} 
			set
			{
				SetValue( v =>  _filletRadius = v, _filletRadius, value,  "FilletRadius");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @EdgeRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _edgeRadius;
				((IPersistEntity)this).Activate(false);
				return _edgeRadius;
			} 
			set
			{
				SetValue( v =>  _edgeRadius = v, _edgeRadius, value,  "EdgeRadius");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_depth = value.RealVal;
					return;
				case 4: 
					_flangeWidth = value.RealVal;
					return;
				case 5: 
					_webThickness = value.RealVal;
					return;
				case 6: 
					_flangeThickness = value.RealVal;
					return;
				case 7: 
					_filletRadius = value.RealVal;
					return;
				case 8: 
					_edgeRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : FlangeThickness < (Depth / 2.);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcZShapeProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcZShapeProfileDef
            var root = (@IfcZShapeProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcZShapeProfileDef left, @IfcZShapeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcZShapeProfileDef left, @IfcZShapeProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcZShapeProfileDef x, @IfcZShapeProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcZShapeProfileDef obj)
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