// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveStyle : IIfcPresentationStyle, IfcPresentationStyleSelect
	{
		IfcCurveFontOrScaledCurveFontSelect @CurveFont { get; }
		IfcSizeSelect @CurveWidth { get; }
		IfcColour @CurveColour { get; }
		
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IFCCURVESTYLE", 118)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyle : IfcPresentationStyle, IInstantiableEntity, IIfcCurveStyle, IEqualityComparer<@IfcCurveStyle>, IEquatable<@IfcCurveStyle>
	{
		#region IIfcCurveStyle explicit implementation
		IfcCurveFontOrScaledCurveFontSelect IIfcCurveStyle.CurveFont { get { return @CurveFont; } }	
		IfcSizeSelect IIfcCurveStyle.CurveWidth { get { return @CurveWidth; } }	
		IfcColour IIfcCurveStyle.CurveColour { get { return @CurveColour; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurveFontOrScaledCurveFontSelect _curveFont;
		private IfcSizeSelect _curveWidth;
		private IfcColour _curveColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurveFontOrScaledCurveFontSelect @CurveFont 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveFont;
				((IPersistEntity)this).Activate(false);
				return _curveFont;
			} 
			set
			{
				SetValue( v =>  _curveFont = v, _curveFont, value,  "CurveFont");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @CurveWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveWidth;
				((IPersistEntity)this).Activate(false);
				return _curveWidth;
			} 
			set
			{
				SetValue( v =>  _curveWidth = v, _curveWidth, value,  "CurveWidth");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColour @CurveColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveColour;
				((IPersistEntity)this).Activate(false);
				return _curveColour;
			} 
			set
			{
				SetValue( v =>  _curveColour = v, _curveColour, value,  "CurveColour");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_curveFont = (IfcCurveFontOrScaledCurveFontSelect)(value.EntityVal);
					return;
				case 2: 
					_curveWidth = (IfcSizeSelect)(value.EntityVal);
					return;
				case 3: 
					_curveColour = (IfcColour)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:              (CurveWidth = 'by layer'));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCurveStyle
            var root = (@IfcCurveStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCurveStyle left, @IfcCurveStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCurveStyle left, @IfcCurveStyle right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCurveStyle x, @IfcCurveStyle y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCurveStyle obj)
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